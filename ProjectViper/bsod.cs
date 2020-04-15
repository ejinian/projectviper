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
    public partial class bsod : Form
    {
        public bsod()
        {
            InitializeComponent();
        }

        private void bsod_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label9.Visible = true;
            pictureBox1.Visible = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\finalambientstretched.wav");
            begin.Play();
            Close();
        }
    }
}
