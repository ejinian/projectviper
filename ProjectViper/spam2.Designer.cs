namespace ProjectViper
{
    partial class spam2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spam2));
            this.spam2globaltimer1 = new System.Windows.Forms.Timer(this.components);
            this.spam2globaltimer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // spam2globaltimer1
            // 
            this.spam2globaltimer1.Interval = 150;
            this.spam2globaltimer1.Tick += new System.EventHandler(this.spam1globaltimer_Tick);
            // 
            // spam2globaltimer2
            // 
            this.spam2globaltimer2.Interval = 300;
            this.spam2globaltimer2.Tick += new System.EventHandler(this.spam2globaltimer_Tick);
            // 
            // spam2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectViper.Properties.Resources.ma;
            this.ClientSize = new System.Drawing.Size(887, 587);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "spam2";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "OPTIMAL DRIVE INSTALLER";
            this.Load += new System.EventHandler(this.spam2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spam2_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer spam2globaltimer1;
        private System.Windows.Forms.Timer spam2globaltimer2;
    }
}