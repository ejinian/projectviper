namespace ProjectViper
{
    partial class decoy2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(decoy2));
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startUpBar = new System.Windows.Forms.Timer(this.components);
            this.globalTimer1 = new System.Windows.Forms.Timer(this.components);
            this.globalTimer2 = new System.Windows.Forms.Timer(this.components);
            this.globalTimer3 = new System.Windows.Forms.Timer(this.components);
            this.globalTimer4 = new System.Windows.Forms.Timer(this.components);
            this.globalTimer5 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.theEnd = new System.Windows.Forms.Timer(this.components);
            this.toWinScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arimo", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(204, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(572, 44);
            this.label10.TabIndex = 45;
            this.label10.Text = "Project_Viper is starting up!111";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 375);
            this.progressBar1.Maximum = 70;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1031, 73);
            this.progressBar1.TabIndex = 46;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arimo", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(462, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 44);
            this.label1.TabIndex = 47;
            this.label1.Text = "Loading components...";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arimo", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(195, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 44);
            this.label2.TabIndex = 48;
            this.label2.Text = "Allocating memory space...";
            this.label2.Visible = false;
            // 
            // startUpBar
            // 
            this.startUpBar.Tick += new System.EventHandler(this.startUpBar_Tick);
            // 
            // globalTimer1
            // 
            this.globalTimer1.Interval = 1500;
            this.globalTimer1.Tick += new System.EventHandler(this.globalTimer1_Tick);
            // 
            // globalTimer2
            // 
            this.globalTimer2.Interval = 3000;
            this.globalTimer2.Tick += new System.EventHandler(this.globalTimer2_Tick);
            // 
            // globalTimer3
            // 
            this.globalTimer3.Interval = 1900;
            this.globalTimer3.Tick += new System.EventHandler(this.globalTimer3_Tick);
            // 
            // globalTimer4
            // 
            this.globalTimer4.Interval = 1700;
            this.globalTimer4.Tick += new System.EventHandler(this.globalTimer4_Tick);
            // 
            // globalTimer5
            // 
            this.globalTimer5.Interval = 2100;
            this.globalTimer5.Tick += new System.EventHandler(this.globalTimer5_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // theEnd
            // 
            this.theEnd.Interval = 52000;
            this.theEnd.Tick += new System.EventHandler(this.theEnd_Tick);
            // 
            // toWinScreen
            // 
            this.toWinScreen.Interval = 2000;
            this.toWinScreen.Tick += new System.EventHandler(this.toWinScreen_Tick);
            // 
            // decoy2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectViper.Properties.Resources.dankeem;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 750);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "decoy2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.decoy2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.decoy2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer startUpBar;
        public System.Windows.Forms.Timer globalTimer1;
        public System.Windows.Forms.Timer globalTimer2;
        public System.Windows.Forms.Timer globalTimer3;
        public System.Windows.Forms.Timer globalTimer4;
        public System.Windows.Forms.Timer globalTimer5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Timer theEnd;
        public System.Windows.Forms.Timer toWinScreen;
    }
}