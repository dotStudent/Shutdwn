namespace Shutdwn
{
    partial class frmMain
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
            this.rBSD = new System.Windows.Forms.RadioButton();
            this.rBRS = new System.Windows.Forms.RadioButton();
            this.rBLO = new System.Windows.Forms.RadioButton();
            this.nUPHour = new System.Windows.Forms.NumericUpDown();
            this.nUPMinute = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.rbAt = new System.Windows.Forms.RadioButton();
            this.rBIn = new System.Windows.Forms.RadioButton();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.lbMinute = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbCountdown = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUPHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPMinute)).BeginInit();
            this.gbTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBSD
            // 
            this.rBSD.AutoSize = true;
            this.rBSD.Location = new System.Drawing.Point(168, 24);
            this.rBSD.Margin = new System.Windows.Forms.Padding(2);
            this.rBSD.Name = "rBSD";
            this.rBSD.Size = new System.Drawing.Size(73, 17);
            this.rBSD.TabIndex = 0;
            this.rBSD.TabStop = true;
            this.rBSD.Text = "Shutdown";
            this.rBSD.UseVisualStyleBackColor = true;
            // 
            // rBRS
            // 
            this.rBRS.AutoSize = true;
            this.rBRS.Location = new System.Drawing.Point(168, 46);
            this.rBRS.Margin = new System.Windows.Forms.Padding(2);
            this.rBRS.Name = "rBRS";
            this.rBRS.Size = new System.Drawing.Size(59, 17);
            this.rBRS.TabIndex = 1;
            this.rBRS.TabStop = true;
            this.rBRS.Text = "Restart";
            this.rBRS.UseVisualStyleBackColor = true;
            // 
            // rBLO
            // 
            this.rBLO.AutoSize = true;
            this.rBLO.Location = new System.Drawing.Point(168, 67);
            this.rBLO.Margin = new System.Windows.Forms.Padding(2);
            this.rBLO.Name = "rBLO";
            this.rBLO.Size = new System.Drawing.Size(57, 17);
            this.rBLO.TabIndex = 2;
            this.rBLO.TabStop = true;
            this.rBLO.Text = "LogOff";
            this.rBLO.UseVisualStyleBackColor = true;
            // 
            // nUPHour
            // 
            this.nUPHour.Location = new System.Drawing.Point(21, 56);
            this.nUPHour.Margin = new System.Windows.Forms.Padding(2);
            this.nUPHour.Name = "nUPHour";
            this.nUPHour.Size = new System.Drawing.Size(39, 20);
            this.nUPHour.TabIndex = 4;
            // 
            // nUPMinute
            // 
            this.nUPMinute.Location = new System.Drawing.Point(83, 56);
            this.nUPMinute.Margin = new System.Windows.Forms.Padding(2);
            this.nUPMinute.Name = "nUPMinute";
            this.nUPMinute.Size = new System.Drawing.Size(39, 20);
            this.nUPMinute.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(134, 153);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 19);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rbAt
            // 
            this.rbAt.AutoSize = true;
            this.rbAt.Location = new System.Drawing.Point(10, 17);
            this.rbAt.Margin = new System.Windows.Forms.Padding(2);
            this.rbAt.Name = "rbAt";
            this.rbAt.Size = new System.Drawing.Size(61, 17);
            this.rbAt.TabIndex = 7;
            this.rbAt.TabStop = true;
            this.rbAt.Text = "At Time";
            this.rbAt.UseVisualStyleBackColor = true;
            // 
            // rBIn
            // 
            this.rBIn.AutoSize = true;
            this.rBIn.Location = new System.Drawing.Point(75, 17);
            this.rBIn.Margin = new System.Windows.Forms.Padding(2);
            this.rBIn.Name = "rBIn";
            this.rBIn.Size = new System.Drawing.Size(60, 17);
            this.rBIn.TabIndex = 8;
            this.rBIn.TabStop = true;
            this.rBIn.Text = "In Time";
            this.rBIn.UseVisualStyleBackColor = true;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.lbMinute);
            this.gbTime.Controls.Add(this.lbHour);
            this.gbTime.Controls.Add(this.rBIn);
            this.gbTime.Controls.Add(this.nUPHour);
            this.gbTime.Controls.Add(this.rbAt);
            this.gbTime.Controls.Add(this.nUPMinute);
            this.gbTime.Location = new System.Drawing.Point(9, 10);
            this.gbTime.Margin = new System.Windows.Forms.Padding(2);
            this.gbTime.Name = "gbTime";
            this.gbTime.Padding = new System.Windows.Forms.Padding(2);
            this.gbTime.Size = new System.Drawing.Size(138, 81);
            this.gbTime.TabIndex = 9;
            this.gbTime.TabStop = false;
            // 
            // lbMinute
            // 
            this.lbMinute.AutoSize = true;
            this.lbMinute.Location = new System.Drawing.Point(81, 40);
            this.lbMinute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMinute.Name = "lbMinute";
            this.lbMinute.Size = new System.Drawing.Size(42, 13);
            this.lbMinute.TabIndex = 14;
            this.lbMinute.Text = "Minute:";
            this.lbMinute.DoubleClick += new System.EventHandler(this.lbMinute_DoubleClick);
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Location = new System.Drawing.Point(20, 40);
            this.lbHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(33, 13);
            this.lbHour.TabIndex = 13;
            this.lbHour.Text = "Hour:";
            this.lbHour.DoubleClick += new System.EventHandler(this.lbHour_DoubleClick);
            // 
            // lbCountdown
            // 
            this.lbCountdown.AutoSize = true;
            this.lbCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdown.Location = new System.Drawing.Point(7, 21);
            this.lbCountdown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(80, 13);
            this.lbCountdown.TabIndex = 10;
            this.lbCountdown.Text = "lbCountdown";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(194, 153);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 19);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 153);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 19);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load Last Settings";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCountdown);
            this.groupBox1.Location = new System.Drawing.Point(9, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 49);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Countdown";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 184);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rBLO);
            this.Controls.Add(this.rBRS);
            this.Controls.Add(this.rBSD);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Shutdwn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUPHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPMinute)).EndInit();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBSD;
        private System.Windows.Forms.RadioButton rBRS;
        private System.Windows.Forms.RadioButton rBLO;
        private System.Windows.Forms.NumericUpDown nUPHour;
        private System.Windows.Forms.NumericUpDown nUPMinute;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rbAt;
        private System.Windows.Forms.RadioButton rBIn;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.Label lbCountdown;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbMinute;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

