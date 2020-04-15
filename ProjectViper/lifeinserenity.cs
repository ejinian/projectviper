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
    public partial class lifeinserenity : Form
    {
        Graphics g;
        Bitmap bitmap;
        Dictionary<Control, Point> ogPositions = new Dictionary<Control, Point>();
        public lifeinserenity()
        {
            InitializeComponent();
        }

        private void lifeinserenity_Load(object sender, EventArgs e)
        {
            //bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            //g = Graphics.FromImage(bitmap);
            //adding dictionary keys and values
            ogPositions.Add(pictureBox1, pictureBox1.Location);
            ogPositions.Add(label1, label1.Location);
            ogPositions.Add(pictureBox2, pictureBox2.Location);
            ogPositions.Add(pictureBox3, pictureBox3.Location);
            ogPositions.Add(pictureBox4, pictureBox4.Location);
            ogPositions.Add(pictureBox5, pictureBox5.Location);
            ogPositions.Add(pictureBox6, pictureBox6.Location);
            ogPositions.Add(label2, label2.Location);
            ogPositions.Add(label3, label3.Location);
            ogPositions.Add(linkLabel1, linkLabel1.Location);
            ogPositions.Add(button1, button1.Location);
            HorizontalScroll.Enabled = false;
            VerticalScroll.Enabled = false;
            this.MouseWheel += lifeinserenity_MouseWheel;
        }
        void lifeinserenity_MouseWheel(object sender, MouseEventArgs e)
        {
            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            //Form1.ActiveForm.Text = numberOfTextLinesToMove.ToString();
            if (numberOfTextLinesToMove > 0)
            {
                if (vScrollBar1.Value >= 30)
                {
                    vScrollBar1.Value -= 30;
                }
            }
            else if (numberOfTextLinesToMove < 0)
            {
                if (vScrollBar1.Value <= 490)
                {
                    vScrollBar1.Value += 30;
                }
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //g.Clear(BackColor);
            //g.DrawImage(pictureBox1.Image, new Rectangle(0, vScrollBar1.Value, pictureBox1.Width, pictureBox1.Height));
            //pictureBox2.Image = bitmap;
        }

        private void vScrollBar1_ValueChanged_1(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (ogPositions.ContainsKey(c))
                {
                    c.Location = new Point(ogPositions[c].X, ogPositions[c].Y - vScrollBar1.Value);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox6.Visible = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            pictureBox6.Visible = false;
            label2.Visible = true;
            linkLabel1.Enabled = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.Play();
            Close();
        }
    }
}
