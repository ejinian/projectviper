using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectViper
{
    public partial class omen : Form
    {
        public omen()
        {
            InitializeComponent();
        }

        private void omen_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 2;
            label1.Visible = true;
            label1.ForeColor = Color.FromArgb(label1.ForeColor.R + fadingSpeed, label1.ForeColor.G + fadingSpeed, label1.ForeColor.B + fadingSpeed);
            if (label1.ForeColor.R >= this.BackColor.B)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 3;
            label2.Visible = true;
            label2.ForeColor = Color.FromArgb(label2.ForeColor.R + fadingSpeed, label2.ForeColor.G + fadingSpeed, label2.ForeColor.B + fadingSpeed);
            if (label2.ForeColor.R >= this.BackColor.B)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 3;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label3.ForeColor = Color.FromArgb(label3.ForeColor.R + fadingSpeed, label3.ForeColor.G + fadingSpeed, label3.ForeColor.B + fadingSpeed);
            label4.ForeColor = Color.FromArgb(label4.ForeColor.R + fadingSpeed, label4.ForeColor.G + fadingSpeed, label4.ForeColor.B + fadingSpeed);
            label5.ForeColor = Color.FromArgb(label5.ForeColor.R + fadingSpeed, label5.ForeColor.G + fadingSpeed, label5.ForeColor.B + fadingSpeed);
            label6.ForeColor = Color.FromArgb(label6.ForeColor.R + fadingSpeed, label6.ForeColor.G + fadingSpeed, label6.ForeColor.B + fadingSpeed);
            if (label3.ForeColor.R >= this.BackColor.B && label4.ForeColor.R >= this.BackColor.B && label5.ForeColor.R >= this.BackColor.B && label6.ForeColor.R >= this.BackColor.B)
            {
                timer3.Stop();
            }
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.Gray;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Gray;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.Gray;
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.Gray;
        }

        private void home_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            home.Stop();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            home.Start();
            timer3.Stop();
            label5.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            allothertabs.Start();
            timer3.Stop();
            label5.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            allothertabs.Start();
            timer3.Stop();
            label5.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            allothertabs.Start();
            timer3.Stop();
            label4.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
        }

        private void allothertabs_Tick(object sender, EventArgs e)
        {
            allothertabs.Stop();
            pictureBox2.Visible = false;
            error404 form = new error404();
            form.ShowDialog();
        }

        private void omen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                begin.Play();
                Hide();
                blackmarket form = new blackmarket();
                form.ShowDialog();
                Close();
            }
            else
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
