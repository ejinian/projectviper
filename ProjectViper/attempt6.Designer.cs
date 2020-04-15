namespace ProjectViper
{
    partial class attempt6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.declaringStatus = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Timer(this.components);
            this.confirmtoinstr = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notepad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.blue = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.colortesttimer = new System.Windows.Forms.Timer(this.components);
            this.bluelabel = new System.Windows.Forms.Label();
            this.greenlabel = new System.Windows.Forms.Label();
            this.yellowlabel = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attempt #6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Permissions Page";
            // 
            // declaringStatus
            // 
            this.declaringStatus.Enabled = true;
            this.declaringStatus.Interval = 2000;
            this.declaringStatus.Tick += new System.EventHandler(this.declaringStatus_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Declaring 00100 status...";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(392, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmation complete";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Awaiting instructions...";
            this.label5.Visible = false;
            // 
            // confirm
            // 
            this.confirm.Interval = 2000;
            this.confirm.Tick += new System.EventHandler(this.confirm_Tick);
            // 
            // confirmtoinstr
            // 
            this.confirmtoinstr.Interval = 1500;
            this.confirmtoinstr.Tick += new System.EventHandler(this.confirmtoinstr_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 36);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Return to Alpha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 4000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notepad
            // 
            this.notepad.AutoSize = true;
            this.notepad.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notepad.Location = new System.Drawing.Point(983, 2);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(131, 24);
            this.notepad.TabIndex = 42;
            this.notepad.Text = "Click for notes";
            this.notepad.Click += new System.EventHandler(this.notepad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(549, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 22);
            this.label10.TabIndex = 47;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(150, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(545, 566);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 49;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 7000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 7000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 7000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 7000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Interval = 8000;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 17);
            this.label13.TabIndex = 50;
            // 
            // timer8
            // 
            this.timer8.Interval = 11000;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label14.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(375, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 22);
            this.label14.TabIndex = 51;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            this.label14.MouseLeave += new System.EventHandler(this.label14_MouseLeave);
            this.label14.MouseHover += new System.EventHandler(this.label14_MouseHover);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label15.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(552, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 22);
            this.label15.TabIndex = 52;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            this.label15.MouseLeave += new System.EventHandler(this.label15_MouseLeave);
            this.label15.MouseHover += new System.EventHandler(this.label15_MouseHover);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.Font = new System.Drawing.Font("Rockwell Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(552, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 22);
            this.label16.TabIndex = 53;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            this.label16.MouseLeave += new System.EventHandler(this.label16_MouseLeave);
            this.label16.MouseHover += new System.EventHandler(this.label16_MouseHover);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.blue.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blue.ForeColor = System.Drawing.Color.DarkBlue;
            this.blue.Location = new System.Drawing.Point(523, 86);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(82, 34);
            this.blue.TabIndex = 54;
            this.blue.TabStop = false;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Visible = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.green.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.green.ForeColor = System.Drawing.Color.LimeGreen;
            this.green.Location = new System.Drawing.Point(389, 86);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(82, 34);
            this.green.TabIndex = 55;
            this.green.TabStop = false;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = false;
            this.green.Visible = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.yellow.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellow.ForeColor = System.Drawing.Color.Gold;
            this.yellow.Location = new System.Drawing.Point(660, 86);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(82, 34);
            this.yellow.TabIndex = 56;
            this.yellow.TabStop = false;
            this.yellow.Text = "Yellow";
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Visible = false;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // colortesttimer
            // 
            this.colortesttimer.Interval = 2000;
            this.colortesttimer.Tick += new System.EventHandler(this.colortesttimer_Tick);
            // 
            // bluelabel
            // 
            this.bluelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bluelabel.AutoSize = true;
            this.bluelabel.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bluelabel.Location = new System.Drawing.Point(530, 165);
            this.bluelabel.Name = "bluelabel";
            this.bluelabel.Size = new System.Drawing.Size(0, 25);
            this.bluelabel.TabIndex = 57;
            this.bluelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greenlabel
            // 
            this.greenlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.greenlabel.AutoSize = true;
            this.greenlabel.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenlabel.Location = new System.Drawing.Point(530, 190);
            this.greenlabel.Name = "greenlabel";
            this.greenlabel.Size = new System.Drawing.Size(0, 25);
            this.greenlabel.TabIndex = 58;
            this.greenlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yellowlabel
            // 
            this.yellowlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yellowlabel.AutoSize = true;
            this.yellowlabel.Font = new System.Drawing.Font("Imprint MT Shadow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowlabel.Location = new System.Drawing.Point(530, 215);
            this.yellowlabel.Name = "yellowlabel";
            this.yellowlabel.Size = new System.Drawing.Size(0, 25);
            this.yellowlabel.TabIndex = 59;
            this.yellowlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.check.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.Black;
            this.check.Location = new System.Drawing.Point(523, 295);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(82, 34);
            this.check.TabIndex = 60;
            this.check.TabStop = false;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(494, 424);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 17);
            this.label17.TabIndex = 61;
            // 
            // timer9
            // 
            this.timer9.Interval = 8000;
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // attempt6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1117, 616);
            this.ControlBox = false;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.check);
            this.Controls.Add(this.yellowlabel);
            this.Controls.Add(this.greenlabel);
            this.Controls.Add(this.bluelabel);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.green);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.notepad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "attempt6";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.attempt6_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.attempt6_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer declaringStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer confirm;
        private System.Windows.Forms.Timer confirmtoinstr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label notepad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Timer colortesttimer;
        private System.Windows.Forms.Label bluelabel;
        private System.Windows.Forms.Label greenlabel;
        private System.Windows.Forms.Label yellowlabel;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer timer9;
    }
}