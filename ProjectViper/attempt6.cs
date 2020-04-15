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
    public partial class attempt6 : Form
    {
        public attempt6()
        {
            InitializeComponent();
        }

        private void attempt6_Load(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void declaringStatus_Tick(object sender, EventArgs e)
        {
            declaringStatus.Stop();
            label3.Visible = true;
            confirm.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void confirm_Tick(object sender, EventArgs e)
        {
            confirm.Stop();
            label3.Visible = false;
            label4.Visible = true;
            confirmtoinstr.Start();
        }

        private void confirmtoinstr_Tick(object sender, EventArgs e)
        {
            confirmtoinstr.Stop();
            label4.Visible = false;
            label5.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label5.Visible = false;
            colortesttimer.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\morespookymusic.wav");
            begin.Play();
            label6.Text = "Welcome back, user. After a brief scan of the next few puzzles, it seems that Attempt #4 has been compromised.";
            label12.Text = "Skip";
            timer3.Start();
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            notepad.Text = "";
            Process.Start("X:\\notes.txt");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vp6j2");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            declaringStatus.Stop();
            label3.Text = "";
            confirm.Stop();
            label4.Text = "";
            label5.Text = "";
            confirmtoinstr.Stop();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            label6.Text = "";
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            button1.Enabled = true;
            label14.Text = "Attempt #4 alphanumeric passcode - granted by (unknown)";
            label15.Text = ". . .";
            label16.Text = ". . .";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            label7.Text = "To compensate for this malfunction, we will grant you special privileges. (Puzzles subsequent to Attempt #4 have been verified to be safe)";
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            label8.Text = "Data has shown that Attempt #4 consistently crashes before reaching the puzzle itself.";
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            label9.Text = "However, you can avoid the crash by using this code provided to you. Based on our logs, Attempt #4 always terminates itself at precisely 74 seconds after initiating.";
            label10.Text = "Open";
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            label11.Text = "If you can reach any visible textboxes in time before it crashes, you can use our code and Attempt #4 will no longer be an issue to you."; 
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timer7.Stop();
            label13.Text = "From this point forward, new PVsupport requests will be operating on the Permissions Page. If additional problems arise, you know where to contact us."; 
            timer9.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timer8.Stop();
            label12.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label13.Text = "";
            label14.Text = "Attempt #4 alphanumeric passcode - granted by PVsupport";
            label15.Text = ". . .";
            label16.Text = ". . .";
            label17.Text = "";
            button1.Enabled = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vp6j2");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Greetings, user. It seems that there is no need for troubleshooting currently. Check back with us later.");
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Greetings, user. It seems that there is no need for troubleshooting currently. Check back with us later.");
        }

        private void attempt6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                //begin.Play();
                Hide();
                Alpha form = new Alpha();
                form.ShowDialog();
                Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void green_Click(object sender, EventArgs e)
        {
            green.Enabled = false;
            if (bluelabel.Text == "Blue" || bluelabel.Text == "Yellow")
            {
                if (greenlabel.Text == "Blue" || greenlabel.Text == "Yellow")
                {
                    yellowlabel.Text = "Green";
                    yellowlabel.ForeColor = Color.Green;
                }
                else
                {
                    greenlabel.Text = "Green";
                    greenlabel.ForeColor = Color.Green;
                }
            }
            else
            {
                bluelabel.Text = "Green";
                bluelabel.ForeColor = Color.Green;
            }
        }

        private void blue_Click(object sender, EventArgs e)
        {
            blue.Enabled = false;
            if (bluelabel.Text == "Green" || bluelabel.Text == "Yellow")
            {
                if (greenlabel.Text == "Green" || greenlabel.Text == "Yellow")
                {
                    yellowlabel.Text = "Blue";
                    yellowlabel.ForeColor = Color.Blue;
                }
                else
                {
                    greenlabel.Text = "Blue";
                    greenlabel.ForeColor = Color.Blue;
                }
            }
            else
            {
                bluelabel.Text = "Blue";
                bluelabel.ForeColor = Color.Blue;
            }
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            yellow.Enabled = false;
            if (bluelabel.Text  == "Blue" || bluelabel.Text == "Green")
            {
                if (greenlabel.Text == "Blue" || greenlabel.Text == "Green")
                {
                    yellowlabel.Text = "Yellow";
                    yellowlabel.ForeColor = Color.Yellow;
                }
                else
                {
                    greenlabel.Text = "Yellow";
                    greenlabel.ForeColor = Color.Yellow;
                }
            }
            else
            {
                bluelabel.Text = "Yellow";
                bluelabel.ForeColor = Color.Yellow;
            }
        }

        private void colortesttimer_Tick(object sender, EventArgs e)
        {
            colortesttimer.Stop();
            green.Visible = true;
            blue.Visible = true;
            yellow.Visible = true;
            check.Visible = true;
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (bluelabel.ForeColor == Color.Blue && greenlabel.ForeColor == Color.Green && yellowlabel.ForeColor == Color.Yellow)
            {
                timer2.Start();
                bluelabel.Visible = false;
                greenlabel.Visible = false;
                yellowlabel.Visible = false;
                blue.Visible = false;
                green.Visible = false;
                yellow.Visible = false;
                check.Visible = false;
            }
            else if (bluelabel.Text == "" && greenlabel.Text == "" && yellowlabel.Text == "")
            {

            }
            else
            {
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\incorrect.wav");
                begin.Play();
                Hide();
                Alpha form = new Alpha();
                form.ShowDialog();
                Close();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            timer9.Stop();
            label17.Text = "Ceasing PVsupport...";
            timer8.Start();
            label12.Visible = false;
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label16.BackColor = Color.Gray;
            label16.ForeColor = Color.Black;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.BackColor = SystemColors.ActiveBorder;
            label16.ForeColor = Color.Gray;
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            label15.BackColor = Color.Gray;
            label15.ForeColor = Color.Black;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = SystemColors.ActiveBorder;
            label15.ForeColor = Color.Gray;
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            label14.BackColor = Color.Gray;
            label14.ForeColor = Color.Black;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = SystemColors.ActiveBorder;
            label14.ForeColor = Color.Gray;
        }
    }
}
