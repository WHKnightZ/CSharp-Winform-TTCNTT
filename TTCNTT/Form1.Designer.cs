namespace TTCNTT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.cbShowStep = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtCountLine = new System.Windows.Forms.TextBox();
            this.txtCountPoint = new System.Windows.Forms.TextBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.cbShowStep);
            this.grpControl.Controls.Add(this.label1);
            this.grpControl.Controls.Add(this.lblPoint);
            this.grpControl.Controls.Add(this.btnFind);
            this.grpControl.Controls.Add(this.btnGenerate);
            this.grpControl.Controls.Add(this.txtCountLine);
            this.grpControl.Controls.Add(this.txtCountPoint);
            this.grpControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpControl.Location = new System.Drawing.Point(29, 25);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(146, 269);
            this.grpControl.TabIndex = 0;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Control";
            // 
            // cbShowStep
            // 
            this.cbShowStep.AutoSize = true;
            this.cbShowStep.Location = new System.Drawing.Point(36, 169);
            this.cbShowStep.Name = "cbShowStep";
            this.cbShowStep.Size = new System.Drawing.Size(78, 17);
            this.cbShowStep.TabIndex = 11;
            this.cbShowStep.Text = "Show Step";
            this.cbShowStep.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Line:";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(22, 46);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(34, 13);
            this.lblPoint.TabIndex = 9;
            this.lblPoint.Text = "Point:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(36, 211);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(36, 118);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtCountLine
            // 
            this.txtCountLine.Location = new System.Drawing.Point(70, 77);
            this.txtCountLine.MaxLength = 3;
            this.txtCountLine.Name = "txtCountLine";
            this.txtCountLine.Size = new System.Drawing.Size(55, 20);
            this.txtCountLine.TabIndex = 1;
            this.txtCountLine.Text = "10";
            this.txtCountLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCountPoint
            // 
            this.txtCountPoint.Location = new System.Drawing.Point(70, 43);
            this.txtCountPoint.MaxLength = 2;
            this.txtCountPoint.Name = "txtCountPoint";
            this.txtCountPoint.Size = new System.Drawing.Size(55, 20);
            this.txtCountPoint.TabIndex = 0;
            this.txtCountPoint.Text = "5";
            this.txtCountPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.ForeColor = System.Drawing.Color.Green;
            this.lblDest.Location = new System.Drawing.Point(24, 75);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(49, 18);
            this.lblDest.TabIndex = 7;
            this.lblDest.Text = "Dest: ";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblStart.Location = new System.Drawing.Point(24, 43);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(50, 18);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start: ";
            // 
            // lblChoose
            // 
            this.lblChoose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblChoose.Location = new System.Drawing.Point(13, 116);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(124, 16);
            this.lblChoose.TabIndex = 8;
            this.lblChoose.Text = "By Nguyen Khanh";
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMap
            // 
            this.picMap.BackColor = System.Drawing.Color.White;
            this.picMap.Location = new System.Drawing.Point(200, 20);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(750, 600);
            this.picMap.TabIndex = 1;
            this.picMap.TabStop = false;
            this.picMap.Click += new System.EventHandler(this.picMap_Click);
            this.picMap.Paint += new System.Windows.Forms.PaintEventHandler(this.picMap_Paint);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblChoose);
            this.grpInfo.Controls.Add(this.lblStart);
            this.grpInfo.Controls.Add(this.lblDest);
            this.grpInfo.Location = new System.Drawing.Point(29, 324);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(146, 149);
            this.grpInfo.TabIndex = 9;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // timer
            // 
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.grpControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTCNTT";
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtCountLine;
        private System.Windows.Forms.TextBox txtCountPoint;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.CheckBox cbShowStep;
        private System.Windows.Forms.Timer timer;
    }
}

