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
            this.cbShowLine = new System.Windows.Forms.CheckBox();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
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
            this.lblNodes = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.cbShowLine);
            this.grpControl.Controls.Add(this.tbSpeed);
            this.grpControl.Controls.Add(this.cbShowStep);
            this.grpControl.Controls.Add(this.label1);
            this.grpControl.Controls.Add(this.lblPoint);
            this.grpControl.Controls.Add(this.btnFind);
            this.grpControl.Controls.Add(this.btnGenerate);
            this.grpControl.Controls.Add(this.txtCountLine);
            this.grpControl.Controls.Add(this.txtCountPoint);
            this.grpControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.grpControl.Location = new System.Drawing.Point(29, 25);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(146, 351);
            this.grpControl.TabIndex = 0;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Control";
            // 
            // cbShowLine
            // 
            this.cbShowLine.AutoSize = true;
            this.cbShowLine.Checked = true;
            this.cbShowLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowLine.Location = new System.Drawing.Point(36, 207);
            this.cbShowLine.Name = "cbShowLine";
            this.cbShowLine.Size = new System.Drawing.Size(86, 20);
            this.cbShowLine.TabIndex = 13;
            this.cbShowLine.Text = "Show Line";
            this.cbShowLine.UseVisualStyleBackColor = true;
            this.cbShowLine.CheckedChanged += new System.EventHandler(this.cbShowLine_CheckedChanged);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(21, 247);
            this.tbSpeed.Maximum = 80;
            this.tbSpeed.Minimum = 10;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbSpeed.TabIndex = 12;
            this.tbSpeed.Value = 10;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // cbShowStep
            // 
            this.cbShowStep.AutoSize = true;
            this.cbShowStep.Checked = true;
            this.cbShowStep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowStep.Location = new System.Drawing.Point(36, 169);
            this.cbShowStep.Name = "cbShowStep";
            this.cbShowStep.Size = new System.Drawing.Size(89, 20);
            this.cbShowStep.TabIndex = 11;
            this.cbShowStep.Text = "Show Step";
            this.cbShowStep.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Line:";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(22, 46);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(41, 16);
            this.lblPoint.TabIndex = 9;
            this.lblPoint.Text = "Point:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(36, 298);
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
            this.txtCountLine.Size = new System.Drawing.Size(55, 23);
            this.txtCountLine.TabIndex = 1;
            this.txtCountLine.Text = "10";
            this.txtCountLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCountPoint
            // 
            this.txtCountPoint.Location = new System.Drawing.Point(70, 43);
            this.txtCountPoint.MaxLength = 2;
            this.txtCountPoint.Name = "txtCountPoint";
            this.txtCountPoint.Size = new System.Drawing.Size(55, 23);
            this.txtCountPoint.TabIndex = 0;
            this.txtCountPoint.Text = "5";
            this.txtCountPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDest.ForeColor = System.Drawing.Color.Green;
            this.lblDest.Location = new System.Drawing.Point(22, 67);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(49, 18);
            this.lblDest.TabIndex = 7;
            this.lblDest.Text = "Dest: ";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Crimson;
            this.lblStart.Location = new System.Drawing.Point(22, 35);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(50, 18);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start: ";
            // 
            // lblChoose
            // 
            this.lblChoose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChoose.Location = new System.Drawing.Point(41, 397);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(124, 16);
            this.lblChoose.TabIndex = 8;
            this.lblChoose.Text = "By Khanh.Nguyen";
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
            this.grpInfo.Controls.Add(this.lblNodes);
            this.grpInfo.Controls.Add(this.lblSteps);
            this.grpInfo.Controls.Add(this.lblStart);
            this.grpInfo.Controls.Add(this.lblDest);
            this.grpInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.grpInfo.Location = new System.Drawing.Point(29, 426);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(146, 182);
            this.grpInfo.TabIndex = 9;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            // 
            // lblNodes
            // 
            this.lblNodes.AutoSize = true;
            this.lblNodes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNodes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblNodes.Location = new System.Drawing.Point(22, 139);
            this.lblNodes.Name = "lblNodes";
            this.lblNodes.Size = new System.Drawing.Size(48, 16);
            this.lblNodes.TabIndex = 10;
            this.lblNodes.Text = "Nodes:";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblSteps.Location = new System.Drawing.Point(22, 110);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(45, 16);
            this.lblSteps.TabIndex = 9;
            this.lblSteps.Text = "Steps:";
            // 
            // timer
            // 
            this.timer.Interval = 800;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.grpControl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTCNTT";
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
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
        private System.Windows.Forms.Label lblNodes;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.CheckBox cbShowLine;
    }
}

