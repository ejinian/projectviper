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
    public partial class origins : Form
    {
        public origins()
        {
            InitializeComponent();
        }

        private void origins_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label3.Visible = false;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label4.Visible = false;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            label6.Visible = false;
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            label1.Text = ".̶̡,̨̕^̷̢͟͞͠,̷̶̵͠.̧<̴̵̡͠,̵̢#̨͞͡.҉̛,̸̨͏̸/̸͞.̕͝,̷͝,҉̷̶̕.͏͏̡.̨̢͘͘,̢͟͟.̢̢̛͜[̴̀͡͞-̢̧̕͟-͠͡-̵̴̴͞-̷̢͟";
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            label6.Visible = true;
            label6.Text = "You c̡an͞nǫt ̀w͘i͞n";
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            label3.Visible = true;
            label3.Text = "Y͢o̵u͞ ҉c͞a̷n͢not ̵win";
            label7.Visible = false;
            label8.Visible = false;
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timer7.Stop();
            this.BackColor = Color.Black;
            timer8.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timer8.Stop();
            this.BackColor = Color.DimGray;
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            exit.Start();
        }

        private void exit_Tick(object sender, EventArgs e)
        {
            exit.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.Play();
            Close();
        }
    }
}
