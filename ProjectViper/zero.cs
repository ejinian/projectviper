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
    public partial class zero : Form
    {
        public zero()
        {
            InitializeComponent();
        }
        
        private void zero_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string value = label1.Text;
            int number = int.Parse(value);
            if (number >= 9)
            {
                number = 0;
            }
            label1.Text = (number + 1).ToString();
            label3.Text = (number + 1).ToString();
            label5.Text = (number + 1).ToString();
            label7.Text = (number + 1).ToString();
            label9.Text = (number + 1).ToString();
            label11.Text = (number + 1).ToString();
            label13.Text = (number + 1).ToString();
            label15.Text = (number + 1).ToString();
            label17.Text = (number + 1).ToString();
            label19.Text = (number + 1).ToString();
            label21.Text = (number + 1).ToString();
            label23.Text = (number + 1).ToString();
            label25.Text = (number + 1).ToString();
            label27.Text = (number + 1).ToString();
            label29.Text = (number + 1).ToString();
            label31.Text = (number + 1).ToString();
            label33.Text = (number + 1).ToString();
            label35.Text = (number + 1).ToString();
            label37.Text = (number + 1).ToString();
            label39.Text = (number + 1).ToString();
            label41.Text = (number + 1).ToString();
            label43.Text = (number + 1).ToString();
            label45.Text = (number + 1).ToString();
            label47.Text = (number + 1).ToString();
            label49.Text = (number + 1).ToString();
            label51.Text = (number + 1).ToString();
            label53.Text = (number + 1).ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string value = label53.Text;
            int number = int.Parse(value);
            if (number <= 0)
            {
                number = 9;
            }
            label2.Text = (number - 1).ToString();
            label4.Text = (number - 1).ToString();
            label6.Text = (number - 1).ToString();
            label8.Text = (number - 1).ToString();
            label10.Text = (number - 1).ToString();
            label12.Text = (number - 1).ToString();
            label14.Text = (number - 1).ToString();
            label16.Text = (number - 1).ToString();
            label18.Text = (number - 1).ToString();
            label20.Text = (number - 1).ToString();
            label22.Text = (number - 1).ToString();
            label24.Text = (number - 1).ToString();
            label26.Text = (number - 1).ToString();
            label28.Text = (number - 1).ToString();
            label30.Text = (number - 1).ToString();
            label32.Text = (number - 1).ToString();
            label34.Text = (number - 1).ToString();
            label36.Text = (number - 1).ToString();
            label38.Text = (number - 1).ToString();
            label40.Text = (number - 1).ToString();
            label42.Text = (number - 1).ToString();
            label44.Text = (number - 1).ToString();
            label46.Text = (number - 1).ToString();
            label48.Text = (number - 1).ToString();
            label50.Text = (number - 1).ToString();
            label52.Text = (number - 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            label10.ForeColor = Color.Black;
            label11.ForeColor = Color.Black;
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            label19.ForeColor = Color.Black;
            label20.ForeColor = Color.Black;
            label21.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            label23.ForeColor = Color.Black;
            label24.ForeColor = Color.Black;
            label25.ForeColor = Color.Black;
            label26.ForeColor = Color.Black;
            label27.ForeColor = Color.Black;
            label28.ForeColor = Color.Black;
            label29.ForeColor = Color.Black;
            label30.ForeColor = Color.Black;
            label31.ForeColor = Color.Black;
            label32.ForeColor = Color.Black;
            label33.ForeColor = Color.Black;
            label34.ForeColor = Color.Black;
            label35.ForeColor = Color.Black;
            label36.ForeColor = Color.Black;
            label37.ForeColor = Color.Black;
            label38.ForeColor = Color.Black;
            label39.ForeColor = Color.Black;
            label40.ForeColor = Color.Black;
            label41.ForeColor = Color.Black;
            label42.ForeColor = Color.Black;
            label43.ForeColor = Color.Black;
            label44.ForeColor = Color.Black;
            label45.ForeColor = Color.Black;
            label46.ForeColor = Color.Black;
            label47.ForeColor = Color.Black;
            label48.ForeColor = Color.Black;
            label49.ForeColor = Color.Black;
            label50.ForeColor = Color.Black;
            label51.ForeColor = Color.Black;
            label52.ForeColor = Color.Black;
            label53.ForeColor = Color.Black;
            button1.Visible = false;
            button2.Visible = true;
            timer4.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            label10.ForeColor = Color.White;
            label11.ForeColor = Color.White;
            label12.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            label16.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label18.ForeColor = Color.White;
            label19.ForeColor = Color.White;
            label20.ForeColor = Color.White;
            label21.ForeColor = Color.White;
            label22.ForeColor = Color.White;
            label23.ForeColor = Color.White;
            label24.ForeColor = Color.White;
            label25.ForeColor = Color.White;
            label26.ForeColor = Color.White;
            label27.ForeColor = Color.White;
            label28.ForeColor = Color.White;
            label29.ForeColor = Color.White;
            label30.ForeColor = Color.White;
            label31.ForeColor = Color.White;
            label32.ForeColor = Color.White;
            label33.ForeColor = Color.White;
            label34.ForeColor = Color.White;
            label35.ForeColor = Color.White;
            label36.ForeColor = Color.White;
            label37.ForeColor = Color.White;
            label38.ForeColor = Color.White;
            label39.ForeColor = Color.White;
            label40.ForeColor = Color.White;
            label41.ForeColor = Color.White;
            label42.ForeColor = Color.White;
            label43.ForeColor = Color.White;
            label44.ForeColor = Color.White;
            label45.ForeColor = Color.White;
            label46.ForeColor = Color.White;
            label47.ForeColor = Color.White;
            label48.ForeColor = Color.White;
            label49.ForeColor = Color.White;
            label50.ForeColor = Color.White;
            label51.ForeColor = Color.White;
            label52.ForeColor = Color.White;
            label53.ForeColor = Color.White;
            button1.Visible = true;
            button2.Visible = false;
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            timer2.Stop();
            timer1.Stop();
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";
            label18.Text = "0";
            label19.Text = "0";
            label20.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
            label23.Text = "0";
            label24.Text = "0";
            label25.Text = "0";
            label26.Text = "0";
            label27.Text = "0";
            label28.Text = "0";
            label29.Text = "0";
            label30.Text = "0";
            label31.Text = "0";
            label32.Text = "0";
            label33.Text = "0";
            label34.Text = "0";
            label35.Text = "0";
            label36.Text = "0";
            label37.Text = "0";
            label38.Text = "0";
            label39.Text = "0";
            label40.Text = "0";
            label41.Text = "0";
            label42.Text = "0";
            label43.Text = "0";
            label44.Text = "0";
            label45.Text = "0";
            label46.Text = "0";
            label47.Text = "0";
            label48.Text = "0";
            label49.Text = "0";
            label50.Text = "0";
            label51.Text = "0";
            label52.Text = "0";
            label53.Text = "0";
            button1.Visible = false;
            button2.Visible = false;
            timer4.Stop();
            timer5.Stop();
            this.Opacity = 1.00;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.Play();
            timer7.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            this.Opacity = 0.85;
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            this.Opacity = 1.00;
            timer4.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\afterlifestretched.wav");
            begin.Play();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timer7.Stop();
            label45.Visible = false;
            label54.Visible = true;
            timer8.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timer8.Stop();
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }
    }
}
