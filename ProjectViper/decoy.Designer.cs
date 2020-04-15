namespace ProjectViper
{
    partial class decoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(decoy));
            this.scare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moveToSecondDecoy = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scare
            // 
            this.scare.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.scare.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scare.ForeColor = System.Drawing.Color.Red;
            this.scare.Location = new System.Drawing.Point(218, 93);
            this.scare.MaxLength = 1;
            this.scare.Name = "scare";
            this.scare.Size = new System.Drawing.Size(204, 59);
            this.scare.TabIndex = 17;
            this.scare.TabStop = false;
            this.scare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.scare.Click += new System.EventHandler(this.a2textbox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Attempt #328402964118529033";
            // 
            // moveToSecondDecoy
            // 
            this.moveToSecondDecoy.Interval = 1000;
            this.moveToSecondDecoy.Tick += new System.EventHandler(this.moveToSecondDecoy_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(581, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "As everyday passes, more and more is forgotten.";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "About the once glorious project";
            this.label3.Visible = false;
            // 
            // decoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(655, 590);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scare);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "decoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.decoy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.decoy_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer moveToSecondDecoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}