using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace TTCNTT
{
    public partial class Form1 : Form
    {
        private const int W = 750, H = 600;
        private const int radius = 20, radius2 = radius * 2, radius3 = radius + 3;
        private const int size = 150;
        private Random random = new Random();
        private Font drawFont = new Font("Arial", 18);
        private StringFormat sf = new StringFormat();
        private Pen pen = new Pen(Color.Black) { Width = 2 };
        private Pen penStart = new Pen(Color.DarkViolet) { Width = 4 };
        private Pen penDest = new Pen(Color.LimeGreen) { Width = 4 };
        private Pen penBlackArrow = new Pen(Color.Black) { Width = 2, CustomEndCap = new AdjustableArrowCap(5, 5, false) };
        private Pen penStepArrow = new Pen(Color.Aqua) { Width = 3, CustomEndCap = new AdjustableArrowCap(3, 3, false) };
        private Pen penPathArrow = new Pen(Color.Blue) { Width = 4, CustomEndCap = new AdjustableArrowCap(3, 3, false) };

        private int countPoint, countLine;
        private Point[] points = new Point[20];
        private PairPoint[,] lines = new PairPoint[20, 20];
        private int[,] distance = new int[20, 20];
        private int[] newDistance = new int[20];

        private int start = -1, dest = -1;
        private Point[] listStep = new Point[400];
        private int countStep = 0, maxStep = 0;
        private List<int> listPath = new List<int>();
        private bool isFounded = false;

        private int chooseState = 0;
        private string[] textChoose = { "By Nguyen Khanh", "Choose Start ...", "Choose Dest ..." };

        public Form1()
        {
            InitializeComponent();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            countPoint = Convert.ToInt32(txtCountPoint.Text);
            countLine = Convert.ToInt32(txtCountLine.Text);
            reset();
            generate();
        }

        void reset()
        {
            start = dest = -1;
            countStep = maxStep = 0;
            listPath.Clear();
            chooseState = 0;
            lblChoose.Text = textChoose[chooseState];
            lblStart.Text = "Start: ";
            lblDest.Text = "Dest: ";
            isFounded = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            reset();

            bool ok = false;
            try
            {
                countPoint = Convert.ToInt32(txtCountPoint.Text);
                countLine = Convert.ToInt32(txtCountLine.Text);
                if (countPoint > 0 && countPoint <= 20 && countLine > 0 && countLine <= countPoint * (countPoint - 1))
                    ok = true;
            }
            catch { }
            if (ok)
                generate();
            else
                MessageBox.Show("Wrong amount of points", "Information");
        }

        void picMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (isFounded)
            {
                int old, n;
                if (cbShowStep.Checked)
                {
                    for (int i = 0; i < countStep; i++)
                    {
                        old = listStep[i].Y;
                        n = listStep[i].X;
                        g.DrawLine(penStepArrow, lines[old, n].p1, lines[old, n].p2);
                    }
                    old = listStep[countStep].Y;
                    n = listStep[countStep].X;
                    g.DrawLine(penPathArrow, lines[old, n].p1, lines[old, n].p2);
                }
                if (countStep == maxStep-1)
                {
                    old = dest;
                    foreach (int i in listPath)
                    {
                        if (i == dest)
                            continue;
                        g.DrawLine(penPathArrow, lines[i, old].p1, lines[i, old].p2);
                        old = i;
                    }
                }
            }

            if (start != -1)
                g.DrawEllipse(penStart, new Rectangle(points[start].X - radius, points[start].Y - radius, radius2, radius2));
            if (dest != -1)
                g.DrawEllipse(penDest, new Rectangle(points[dest].X - radius, points[dest].Y - radius, radius2, radius2));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            countStep++;
            picMap.Invalidate();
            if (countStep == maxStep-1)
            {
                grpControl.Enabled = true;
                timer.Enabled = false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            start = dest = -1;
            isFounded = false;
            picMap.Invalidate();
            grpControl.Enabled = false;
            chooseState = 1;
            lblChoose.Text = textChoose[chooseState];
        }

        private void picMap_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (chooseState == 1)
            {
                for (int i = 0; i < countPoint; i++)
                {
                    if (me.X > points[i].X - radius && me.X < points[i].X + radius && me.Y > points[i].Y - radius && me.Y < points[i].Y + radius)
                    {
                        start = i;
                        lblStart.Text = "Start: " + i;
                        chooseState = 2;
                        lblChoose.Text = textChoose[chooseState];
                        picMap.Invalidate();
                        break;
                    }
                }
            }
            else if (chooseState == 2)
            {
                for (int i = 0; i < countPoint; i++)
                {
                    if (me.X > points[i].X - radius && me.X < points[i].X + radius && me.Y > points[i].Y - radius && me.Y < points[i].Y + radius)
                    {
                        dest = i;
                        lblDest.Text = "Dest: " + i;
                        chooseState = 0;
                        lblChoose.Text = textChoose[chooseState];
                        picMap.Invalidate();

                        if (dijkstra())
                        {
                            picMap.Invalidate();
                            if (cbShowStep.Checked)
                            {
                                countStep = 0;
                                timer.Enabled = true;
                            }
                            else
                            {
                                countStep = maxStep - 1;
                                grpControl.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not found!", "Information");
                            grpControl.Enabled = true;
                        }

                        break;
                    }
                }
            }
        }

        void generate()
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int count = 20;
            int n, k = 0, region;
            Point[] listLine = new Point[400];
            Point p;
            int offsetX, offsetY, px1, px2, py1, py2;
            for (int i = 0; i < countPoint; i++)
            {
                for (int j = 0; j < countPoint; j++)
                {
                    distance[i, j] = 0;
                    if (i != j)
                    {
                        listLine[k] = new Point(i, j);
                        k++;
                    }
                }

                n = random.Next(count);
                region = array[n];
                count--;
                array[n] = array[count];
                p = randomInRegion(region);
                points[i] = p;
            }
            for (int i = 0; i < countLine; i++)
            {
                n = random.Next(k);
                p = listLine[n];
                k--;
                listLine[n] = listLine[k];
                distance[p.X, p.Y] = calDistance(points[p.X], points[p.Y]);
                px1 = points[p.X].X;
                px2 = points[p.Y].X;
                py1 = points[p.X].Y;
                py2 = points[p.Y].Y;
                offsetX = (px2 - px1) * radius3 / distance[p.X, p.Y];
                offsetY = (py2 - py1) * radius3 / distance[p.X, p.Y];
                lines[p.X, p.Y] = new PairPoint() { p1 = new Point(px1 + offsetX, py1 + offsetY), p2 = new Point(px2 - offsetX, py2 - offsetY) };
            }


            Bitmap bitmap = new Bitmap(W, H);
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            for (int i = 0; i < countPoint; i++)
            {
                for (int j = 0; j < countPoint; j++)
                {
                    if (distance[i, j] != 0)
                    {
                        g.DrawLine(penBlackArrow, lines[i, j].p1, lines[i, j].p2);
                    }
                }
            }
            for (int i = 0; i < countPoint; i++)
            {
                p = points[i];
                Rectangle rect = new Rectangle(p.X - radius, p.Y - radius, radius2, radius2);
                g.FillEllipse(Brushes.LightGray, rect);
                g.DrawEllipse(pen, rect);
                g.DrawString(i.ToString(), drawFont, Brushes.Black, p, sf);
            }
            picMap.Image = bitmap;
        }

        Point randomInRegion(int region)
        {
            int minX = region % 5 * size + radius, maxX = minX + size - radius2;
            int minY = region / 5 * size + radius, maxY = minY + size - radius2;
            return new Point(random.Next(minX, maxX), random.Next(minY, maxY));
        }

        static int calDistance(Point p1, Point p2)
        {
            float x = p1.X - p2.X, y = p1.Y - p2.Y;
            return (int)Math.Sqrt(x * x + y * y);
        }

        bool dijkstra()
        {
            bool[] mark = new bool[20];
            for (int i = 0; i < countPoint; i++)
            {
                mark[i] = false;
                newDistance[i] = 0;
            }
            countStep = maxStep = 0;
            listPath.Clear();

            SortedSet<Element> queue = new SortedSet<Element>();
            queue.Add(new Element(start, 0, null));
            isFounded = false;
            Element e;
            while (queue.Count > 0)
            {
                e = queue.Min;
                queue.Remove(e);
                if (e.distance != newDistance[e.n])
                    continue;
                mark[e.n] = true;
                if (e.prev != null)
                {
                    listStep[maxStep] = new Point(e.n, e.prev.n);
                    maxStep++;
                }
                if (e.n == dest)
                {
                    while (true)
                    {
                        listPath.Add(e.n);
                        e = e.prev;
                        if (e == null)
                            break;
                    }
                    isFounded = true;
                    break;
                }
                for (int i = 0; i < countPoint; i++)
                {
                    if (!mark[i] && distance[e.n, i] > 0)
                    {
                        int dis = e.distance + distance[e.n, i];
                        if (newDistance[i] == 0)
                        {
                            newDistance[i] = dis;
                            queue.Add(new Element(i, dis, e));
                        }
                        else
                        {
                            if (newDistance[i] > dis)
                            {
                                newDistance[i] = dis;
                                queue.Add(new Element(i, dis, e));
                            }
                        }
                    }
                }
            }
            return isFounded;
        }
    }

    class PairPoint
    {
        public Point p1, p2;
    }

    class Element : IComparable<Element>
    {
        public int n, distance;
        public Element prev;

        public Element(int n = 0, int distance = 0, Element prev = null)
        {
            this.n = n;
            this.distance = distance;
            this.prev = prev;
        }

        public int CompareTo(Element other)
        {
            if (this == other)
                return 0;
            if (this.distance > other.distance)
                return 1;
            return -1;
        }
    }
}
