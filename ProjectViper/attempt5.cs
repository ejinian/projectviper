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
using System.IO;

namespace ProjectViper
{
    public partial class attempt5 : Form
    {
        public attempt5()
        {
            InitializeComponent();
            load.Start();
        }
        private void attempt5_Load(object sender, EventArgs e)
        {
            Cursor.Show();
        }
        private void load_Tick(object sender, EventArgs e)
        {
            load.Stop();
            this.BackgroundImage = Properties.Resources.a5background;
            label1.Text = "Project Viper is importing essential attributes...";
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            this.BackgroundImage = null;
            label3.Visible = true;
            button5.Visible = true;
            button4.Visible = true;
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "";
            label2.Text = "One last step is required from the user to successfully run the build...";
            button1.Visible = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label2.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "7958")
            {
                this.BackgroundImage = Properties.Resources.a5background;
                downloadBar.Visible = true;
                textbox1.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                button5.Visible = false;
                label6.Visible = true;
                button4.Visible = false;
                this.Cursor = Cursors.AppStarting;
                downloadTimer.Start();
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\a5lobbymusic2.wav");
                begin.PlayLooping();
            }
            else
            {
                textbox1.Clear();
                incorrectTimer.Start();
                label4.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            label5.Visible = true;
            textbox1.Visible = true;
        }

        private void incorrectTimer_Tick(object sender, EventArgs e)
        {
            incorrectTimer.Stop();
            label4.Visible = false;
        }

        private void attempt5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                load.Stop();
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                incorrectTimer.Stop();
                downloadTimer.Stop();
                downloadTimer2.Stop();
                didntclickyesorno.Stop();
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                begin.Play();
                Hide();
                Alpha form = new Alpha();
                form.ShowDialog();
                Close();
            } else
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void downloadTimer_Tick(object sender, EventArgs e)
        {
            downloadBar.Value++;
            if (downloadBar.Value == 20)
            {
                label7.Visible = true;
            }
            if (downloadBar.Value == 50)
            {
                label6.Visible = false;
            }
            if (downloadBar.Value == 170)
            {
                label8.Visible = true;
            }
            if (downloadBar.Value == 190)
            {
                button2.Visible = true;
                button3.Visible = true;
                didntclickyesorno.Start();
            }
            if (downloadBar.Value == 100)
            {
                label12.Visible = true;
            }
            if (downloadBar.Value == 130)
            {
                label12.Visible = false;
            }
            if (downloadBar.Value == 60)
            {
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;
                linkLabel4.Visible = true;
                linkLabel5.Visible = true;
                linkLabel6.Visible = true;
            }
            if (downloadBar.Value == 900)
            {
                downloadTimer.Stop();
                downloadBar.Visible = false;
                this.Cursor = Cursors.Default;
                label10.Visible = true;
                button6.Visible = true;
                button4.Visible = true;
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\a5officemusic.wav");
                begin.PlayLooping();
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button2.Visible = false;
            label9.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            downloadTimer2.Start();
            downloadBar2.Visible = true;
            this.Cursor = Cursors.WaitCursor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button2.Visible = false;
            label9.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            downloadTimer2.Start();
            downloadBar2.Visible = true;
            this.Cursor = Cursors.WaitCursor;
        }

        private void downloadTimer2_Tick(object sender, EventArgs e)
        {
            downloadBar2.Value++;
            if (downloadBar2.Value == 400)
            {
                downloadTimer2.Stop();
                label9.Visible = false;
                this.Cursor = Cursors.AppStarting;
                downloadBar2.Visible = false;
            }
        }

        private void didntclickyesorno_Tick(object sender, EventArgs e)
        {
            didntclickyesorno.Stop();
            button3.Visible = false;
            button2.Visible = false;
            label9.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            downloadTimer2.Start();
            downloadBar2.Visible = true;
            this.Cursor = Cursors.WaitCursor;
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            notepad.Text = "";
            Process.Start("X:\\notes.txt");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("August 18, 1994-(Archived Customer Reviews)AnonymousPerson#12: My life has changed ever since I downloaded Project Viper. Not only does my computer benefit from it, but my wife and my dog too! Believe me, there is no need for hard drugs when you have Project Viper.");
            Cursor.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Show();
            MessageBox.Show("February 2, 1998-(Archived Customer Reviews)AnonymousPerson#63: I couldn't believe my eyes when I first found out that Project Viper released a free IPHONE DOWNLOAD link to all its customers. I swear I must have been imagining it! All of my friends have been skeptical about the link ever since I told them about it. Honestly, now that I think about it, I haven't seen any of my friends in a while. Are they avoiding me?");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Error loading this message-");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Show();
            MessageBox.Show("March 30, 2002-(Archived Customer Reviews)AnonymousPerson#189: I've been using Project Viper for several years now and I feel that every time I run it, I begin forgetting a little bit about myself and my past. It reminds me of another world. Nothing like the reality. A place inside my head, free of stress and torment.");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Show();
            MessageBox.Show("April 5, 1999-(Archived Customer Reviews)AnonymousPerson#241: Hi everybody! This is my first time making a review for Project Viper. Personally, I think the program is great. It runs flawlessly on my computer. Almost no issues. But something weird happened to me a few days ago. I fell asleep at my computer in the middle of the night. When I woke up, my massive monitor somehow went missing. So I walked around the house and found it hanging on the wall in the corridor leading to my bedroom. When I picked it up to put it back in place, Project Viper started up even though there was no power connected to the monitor. I don't know how that's possible. Has this happened to anybody else? I don't remember what happened after that. I woke up in my bed and my computer was back in place. The monitor was plugged in. It all felt like a nightmare, but it also felt REAL. Project Viper isn't what it seems. Now that I think of it, what is Project Viper?");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Show();
            MessageBox.Show("FEBRUARY, 1984-You don't know what you are doing. Go back at least 20 years if you are this hungry for an answer.");
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.PlayLooping();
        }

        private void detailsLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            const string message = "PV_Installer cannot run without a special zip file that appears to not have downloaded during the base Project Viper download(Attempt #1). You can browse through our own search engine to find a possible solution. To access our search engine, execute this code into the Alpha form: 54320";
            const string caption = "Zip File Missing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                
            }
        }

        private void makecursorshow_Tick(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textbox1.Text == "7958")
                {
                    this.BackgroundImage = Properties.Resources.a5background;
                    downloadBar.Visible = true;
                    textbox1.Visible = false;
                    label5.Visible = false;
                    label4.Visible = false;
                    label3.Visible = false;
                    button5.Visible = false;
                    label6.Visible = true;
                    button4.Visible = false;
                    this.Cursor = Cursors.AppStarting;
                    downloadTimer.Start();
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\a5lobbymusic2.wav");
                    begin.PlayLooping();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    textbox1.Clear();
                    incorrectTimer.Start();
                    label4.Visible = true;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button4.Enabled = true;
            notifyIcon1.Text = "...";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Awaiting validation...";
            notifyIcon1.BalloonTipTitle = "Almost Ready to Go";
            notifyIcon1.ShowBalloonTip(1000);
            MessageBox.Show("Activate Zero");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.LightYellow;
        }
    }
}
