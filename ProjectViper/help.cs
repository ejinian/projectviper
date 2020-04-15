using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProjectViper
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Process.Start("X:\\help.exe");
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\morespookymusic2.wav");
            begin.PlayLooping();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            button1.Visible = true;
        }

        private void help_Load(object sender, EventArgs e)
        {

        }
    }
}
