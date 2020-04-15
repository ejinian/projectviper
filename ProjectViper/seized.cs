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
    public partial class seized : Form
    {
        public seized()
        {
            InitializeComponent();
        }
        private void seized_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.Play();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Visible = true;
        }
    }
}
