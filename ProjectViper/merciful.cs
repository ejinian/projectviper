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
    public partial class merciful : Form
    {
        public merciful()
        {
            InitializeComponent();
        }

        private void toGlitch_Tick(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\white_face3.wav");
            begin.Play();
            pictureBox1.Image = Properties.Resources.loadinggif3;
            timer1.Start();
            toGlitch.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.BackgroundImage = Properties.Resources.loadinggif3;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label1.ForeColor = Color.Red;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            returnToblackmarket.Start();
        }

        private void returnToblackmarket_Tick(object sender, EventArgs e)
        {
            returnToblackmarket.Stop();
            Close();
        }
    }
}
