using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace ProjectViper
{
    public partial class Alpha : Form
    {
        private DateTime dt;

        public Alpha()
        {
            InitializeComponent();
        }
        
        private void Alpha_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            no.Enabled = true;
            Cursor.Show();
            dt = DateTime.Now;
            log.Text += dt.ToShortTimeString() + " - Alpha Form initialized.\n";
            //code: 3 q y8 4bk x7l
            //easter egg date: 1984 February day doesn't matter
            //unlockable attempt #6: 00100
            //black market: 54320
            //end game: 42906
        }

        private void no_Tick(object sender, EventArgs e)
        {
            opening1.Text = "No";
            one.Enabled = true;
            no.Enabled = false;
        }

        private void one_Tick(object sender, EventArgs e)
        {
            opening1.Text = "";
            opening2.Text = "One";
            beats.Enabled = true;
            one.Enabled = false;
        }

        private void beats_Tick(object sender, EventArgs e)
        {
            opening2.Text = "";
            opening3.Text = "Beats";
            my.Enabled = true;
            beats.Enabled = false;
        }

        private void my_Tick(object sender, EventArgs e)
        {
            opening3.Text = "";
            opening4.Text = "My";
            game.Enabled = true;
            my.Enabled = false;
        }

        private void game_Tick(object sender, EventArgs e)
        {
            opening4.Text = "";
            opening5.Text = "Game";
            disappear.Enabled = true;
            game.Enabled = false;
            label1.Text = "Lobby";
            label2.Text = "Winning is an illusion";
            label3.Text = "Winning is an illusion";
            label4.Text = "Winning is an illusion";
            log.Visible = true;
            label21.Visible = true;
            button1.Enabled = true;
            attempt1.Enabled = true;
            attempt2.Enabled = true;
            attempt3.Enabled = true;
            attempt4.Enabled = true;
            attempt5.Enabled = true;
            a1textbox.Enabled = true;
            a2textbox.Enabled = true;
            a3textbox.Enabled = true;
            a4textbox.Enabled = true;
            a5textbox.Enabled = true;
            attempt1.BackColor = Color.Silver;
            attempt2.BackColor = Color.Silver;
            attempt3.BackColor = Color.Silver;
            attempt4.BackColor = Color.Silver;
            attempt5.BackColor = Color.Silver;
            dateTimePicker1.Enabled = true;
            notepad.Enabled = true;
        }

        private void disappear_Tick(object sender, EventArgs e)
        {
            opening5.Text = "";
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.Red;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.DarkSlateGray;
        }

        private void attempt1_MouseDown(object sender, MouseEventArgs e)
        {
            attempt1.ForeColor = Color.Red;
        }

        private void attempt1_MouseUp(object sender, MouseEventArgs e)
        {
            attempt1.ForeColor = Color.Black;
        }

        private void attempt2_MouseDown(object sender, MouseEventArgs e)
        {
            attempt2.ForeColor = Color.Red;
        }

        private void attempt2_MouseUp(object sender, MouseEventArgs e)
        {
            attempt2.ForeColor = Color.Black;
        }

        private void attempt5_MouseDown(object sender, MouseEventArgs e)
        {
            attempt5.ForeColor = Color.Red;
        }

        private void attempt5_MouseUp(object sender, MouseEventArgs e)
        {
            attempt5.ForeColor = Color.Black;
        }

        private void attempt4_MouseDown(object sender, MouseEventArgs e)
        {
            attempt4.ForeColor = Color.Red;
        }

        private void attempt4_MouseUp(object sender, MouseEventArgs e)
        {
            attempt4.ForeColor = Color.Black;
        }

        private void attempt3_MouseDown(object sender, MouseEventArgs e)
        {
            attempt3.ForeColor = Color.Red;
        }

        private void attempt3_MouseUp(object sender, MouseEventArgs e)
        {
            attempt3.ForeColor = Color.Black;
        }
        //attempt are clicked
        private void attempt1_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            log.Text += dt.ToShortTimeString() + " - Attempt #1 requested.\n";
            log.ForeColor = Color.MediumBlue;
            label5.Text = "Activating Puzzle1...";
            label6.Text = "1";
            label7.Text = "2";
            label8.Text = "5";
            label9.Text = "4";
            label10.Text = "3";
            opening5.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            button2.Visible = true;
            button3.Visible = true;
            //------------------------
            label22.Visible = true;
            button1.ForeColor = Color.Red;
            label21.Visible = false;
            attempt1.Enabled = false;
            attempt1.BackColor = Color.Black;
            attempt2.Enabled = false;
            attempt2.BackColor = Color.Black;
            attempt3.Enabled = false;
            attempt3.BackColor = Color.Black;
            attempt4.Enabled = false;
            attempt4.BackColor = Color.Black;
            attempt5.Enabled = false;
            attempt5.BackColor = Color.Black;
            button1.Enabled = false;
            a1textbox.Enabled = false;
            a2textbox.Enabled = false;
            a3textbox.Enabled = false;
            a4textbox.Enabled = false;
            a5textbox.Enabled = false;
            notepad.Enabled = false;
            dateTimePicker1.Enabled = false;
            errorProvider1.Dispose();
            this.ControlBox = false;
        }

        private void attempt2_Click(object sender, EventArgs e)
        {
            if (a1textbox.Text == "3")
            {
                dt = DateTime.Now;
                log.Text += dt.ToShortTimeString() + " - Attempt #2 requested.\n";
                log.ForeColor = Color.MediumBlue;
                a1textbox.Text = "";
                linkLabel1.Text = "CLICK ME";
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "laugh.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.Play();
                wellDone.Text = "ACCESS GRANTED";
                label20.Text = "Thank you for choosing us.";
                a1textbox.Visible = false;
                attempt1.Enabled = false;
                attempt1.BackColor = Color.Black;
                attempt2.Enabled = false;
                attempt2.BackColor = Color.Black;
                attempt3.Enabled = false;
                attempt3.BackColor = Color.Black;
                attempt4.Enabled = false;
                attempt4.BackColor = Color.Black;
                attempt5.Enabled = false;
                attempt5.BackColor = Color.Black;
                button1.Enabled = false;
                a2timer.Enabled = true;
                errorProvider1.Dispose();
            }
            else
            {
                label11.Text = "Textbox #1 is invalid.";
                attempt2.Enabled = false;
                a2denied.Enabled = true;
                errorProvider1.Dispose();
                errorProvider1.SetError(a1textbox, "AUTHENTICATION IS INVALID");
            }
        }

        private void attempt3_Click(object sender, EventArgs e)
        {
            if (a2textbox.Text == "q")
            {
                dt = DateTime.Now;
                log.Text += dt.ToShortTimeString() + " - Attempt #3 requested.\n";
                log.ForeColor = Color.MediumBlue;
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\defenddryer.wav");
                begin.Play();
                a2textbox.Text = "";
                rememberProgress.Text = "Verifying installation..";
                attempt1.Enabled = false;
                attempt1.BackColor = Color.Black;
                attempt2.Enabled = false;
                attempt2.BackColor = Color.Black;
                attempt3.Enabled = false;
                attempt3.BackColor = Color.Black;
                attempt4.Enabled = false;
                attempt4.BackColor = Color.Black;
                attempt5.Enabled = false;
                attempt5.BackColor = Color.Black;
                button1.Enabled = false;
                a3timer.Enabled = true;
                a1textbox.Enabled = false;
                deniedTimer.Enabled = false;
                a2textbox.Enabled = false;
                a3textbox.Enabled = false;
                a4textbox.Enabled = false;
                a5textbox.Enabled = false;
                notepad.Enabled = false;
                dateTimePicker1.Enabled = false;
                errorProvider1.Dispose();
                this.ControlBox = false;
            }
            else
            {
                label14.Text = "Textbox #2 is invalid.";
                attempt3.Enabled = false;
                a3denied.Enabled = true;
                errorProvider1.Dispose();
                errorProvider1.SetError(a2textbox, "AUTHENTICATION IS INVALID");
            }
        }

        private void attempt4_Click(object sender, EventArgs e)
        {
            if (a3textbox.Text == "y8")
            {
                dt = DateTime.Now;
                log.Text += dt.ToShortTimeString() + " - Attempt #4 requested: failure.\n";
                log.ForeColor = Color.Red;
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "halt.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.Play();
                label15.Text = "NOTHING";
                label16.Text = "IS";
                label17.Text = "REAL";
                label2.Text = "DIE DIE DIE DIE DIE";
                label3.Text = "DIE DIE DIE DIE DIE";
                label4.Text = "DIE DIE DIE DIE DIE";
                label1.Text = "";
                label18.Text = "FATAL_ERROR003303";
                label21.Text = "kTLDOo5iCkJSxjNjDK566chVQPuG64fRh+jNzgP54=";
                a1textbox.Enabled = false;
                a2textbox.Enabled = false;
                a3textbox.Enabled = false;
                a4textbox.Enabled = false;
                a5textbox.Enabled = false;
                a3textbox.Text = "";
                deniedTimer.Enabled = false;
                attempt1.Enabled = false;
                attempt1.BackColor = Color.Black;
                attempt2.Enabled = false;
                attempt2.BackColor = Color.Black;
                attempt3.Enabled = false;
                attempt3.BackColor = Color.Black;
                attempt4.Enabled = false;
                attempt4.BackColor = Color.Black;
                attempt5.Enabled = false;
                attempt5.BackColor = Color.Black;
                button1.Enabled = false;
                a4realtoillusion.Enabled = true;
                notepad.Enabled = false;
                dateTimePicker1.Enabled = false;
                errorProvider1.Dispose();
                this.ControlBox = false;
            }
            else
            {
                label13.Text = "Textbox #3 is invalid.";
                attempt4.Enabled = false;
                a4denied.Enabled = true;
                errorProvider1.Dispose();
                errorProvider1.SetError(a3textbox, "AUTHENTICATION IS INVALID");
            }
        }

        private void attempt5_Click(object sender, EventArgs e)
        {
            if (a4textbox.Text == "4bk")
            {
                dt = DateTime.Now;
                log.Text += dt.ToShortTimeString() + " - Attempt #5 requested.\n";
                log.ForeColor = Color.MediumBlue;
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "a5officemusic.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.PlayLooping();
                this.BackColor = Color.Black;
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label21.Visible = false;
                toHelpProvider.Start();
                a4textbox.Text = "";
                button1.Enabled = false;
                deniedTimer.Enabled = false;
                a1textbox.Enabled = false;
                a2textbox.Enabled = false;
                a3textbox.Enabled = false;
                a4textbox.Enabled = false;
                a5textbox.Enabled = false;
                attempt1.Enabled = false;
                attempt2.Enabled = false;
                attempt3.Enabled = false;
                attempt4.Enabled = false;
                attempt5.Enabled = false;
                attempt1.BackColor = Color.Black;
                attempt2.BackColor = Color.Black;
                attempt3.BackColor = Color.Black;
                attempt4.BackColor = Color.Black;
                attempt5.BackColor = Color.Black;
                notepad.Enabled = false;
                dateTimePicker1.Visible = false;
                errorProvider1.Dispose();
                this.ControlBox = false;
            }
            else
            {
                label12.Text = "Textbox #4 is invalid.";
                attempt5.Enabled = false;
                a5denied.Enabled = true;
                errorProvider1.Dispose();
                errorProvider1.SetError(a4textbox, "AUTHENTICATION IS INVALID");
            }
        }

        private void a1timer_Tick(object sender, EventArgs e)
        {
            a1timer.Stop();
            Hide();
            attempt1 form = new attempt1();
            form.ShowDialog();
            Close();
        }

        private void deniedTimer_Tick(object sender, EventArgs e)
        {
            deniedTimer.Stop();
            button1.Enabled = true;
            a1textbox.Enabled = true;
            a2textbox.Enabled = true;
            a3textbox.Enabled = true;
            a4textbox.Enabled = true;
            a5textbox.Enabled = true;
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "halt.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.Play();
            denied.Text = "";
            notepad.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void a2denied_Tick(object sender, EventArgs e)
        {
            label11.Text = "";
            attempt2.Enabled = true;
            a2denied.Stop();
        }

        private void a3denied_Tick(object sender, EventArgs e)
        {
            label14.Text = "";
            attempt3.Enabled = true;
            a3denied.Stop();
        }

        private void a4denied_Tick(object sender, EventArgs e)
        {
            label13.Text = "";
            attempt4.Enabled = true;
            a4denied.Stop();
        }

        private void a5denied_Tick(object sender, EventArgs e)
        {
            label12.Text = "";
            attempt5.Enabled = true;
            a5denied.Stop();
        }

        private void a2timer_Tick(object sender, EventArgs e)
        {
            linkLabel1.Text = "";
            wellDone.Text = "";
            label20.Text = "";
            button1.Enabled = true;
            attempt1.Enabled = true;
            attempt2.Enabled = true;
            attempt3.Enabled = true;
            attempt4.Enabled = true;
            attempt5.Enabled = true;
            attempt1.BackColor = Color.Silver;
            attempt2.BackColor = Color.Silver;
            attempt3.BackColor = Color.Silver;
            attempt4.BackColor = Color.Silver;
            attempt5.BackColor = Color.Silver;
            a2timer.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://127.0.0.1/Chapters/unknown/pv.html");
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\white_face4.wav");
            begin.PlayLooping();
        }

        private void a3timer_Tick(object sender, EventArgs e)
        {
            a3timer.Stop();
            rememberProgress.Text = "Verifying installation....";
            a3number2timer.Enabled = true;
        }

        private void a3number2timer_Tick(object sender, EventArgs e)
        {
            a3number2timer.Stop();
            rememberProgress.Text = "Verifying installation..";
            a3number3timer.Enabled = true;
        }

        private void a4realtoillusion_Tick(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "a4clicked.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.Play();
            a4realtoillusion.Stop();
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label19.Text = "FAILED TO RUN 'ATTEMPT_4'";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            this.Text = "6666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666666";
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Text = "Le av Gm e ";
            label1.Text = "T he rt o fOb sevato0110010100110110111100101001010";
            a4timer.Enabled = true;
        }

        private void a4timer_Tick(object sender, EventArgs e)
        {
            a4timer.Stop();
            Hide();
            attempt4 form = new attempt4();
            form.ShowDialog();
            Close();
        }

        private void a3number3timer_Tick(object sender, EventArgs e)
        {
            rememberProgress.Text = "Verifying installation....";
            a3number3timer.Enabled = false;
            Hide();
            attempt3 form = new attempt3();
            form.ShowDialog();
            Close();
        }
        //---
        private void kill()
        {
            Application.Exit();
        }

        private void label20_MouseClick(object sender, MouseEventArgs e)
        {
            notepad.Text = "";
            Process.Start("X:\\notes.txt");
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            a2musicstart.Start();
        }

        private void a2musicstart_Tick(object sender, EventArgs e)
        {
            a2musicstart.Stop();
        }

        private void Alpha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                MessageBox.Show("You cannot go back to the starting screen.");
            }
            else
            if (e.KeyCode == Keys.Escape)
            {
                kill();
            }
        }

        private void toa6_Tick(object sender, EventArgs e)
        {
            toa6.Stop();
            Hide();
            attempt6 form = new attempt6();
            form.ShowDialog();
            Close();
        }

        private void a5timer_Tick(object sender, EventArgs e)
        {
            a5timer.Stop();
            Hide();
            attempt5 form = new attempt5();
            form.ShowDialog();
            Close();
        }

        private void toHelpProvider_Tick(object sender, EventArgs e)
        {
            toHelpProvider.Stop();
            notifyIcon1.Text = "You are almost there.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Welcome User";
            notifyIcon1.BalloonTipTitle = "A message from Project Viper";
            notifyIcon1.ShowBalloonTip(1000);
            a5timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a1textbox.Text == "3" && a2textbox.Text == "q" && a3textbox.Text == "y8" && a4textbox.Text == "4bk" && a5textbox.Text == "x7l")
            {
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "halt.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.Play();
                notreal.Start();
                toFlash1.Start();
                denied.Text = "Your code is invalid.";
                attempt1.Enabled = false;
                attempt2.Enabled = false;
                attempt3.Enabled = false;
                attempt4.Enabled = false;
                attempt5.Enabled = false;
                button1.Enabled = false;
                errorProvider1.Dispose();
                this.ControlBox = false;
                log.Visible = false;
                //kill();
            }
            else if (a1textbox.Text == "0" && a2textbox.Text == "0" && a3textbox.Text == "0" && a4textbox.Text == "0" && a5textbox.Text == "1")
            {
                denied.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label21.Text = "";
                dt = DateTime.Now;
                log.Text += dt.ToShortTimeString() + " - Attempt #6 requested.\n";
                log.ForeColor = Color.MediumBlue;
                log.BackColor = Color.LightGray;
                attempt1.Enabled = false;
                attempt1.BackColor = Color.Black;
                attempt2.Enabled = false;
                attempt2.BackColor = Color.Black;
                attempt3.Enabled = false;
                attempt3.BackColor = Color.Black;
                attempt4.Enabled = false;
                attempt4.BackColor = Color.Black;
                attempt5.Enabled = false;
                attempt5.BackColor = Color.Black;
                button1.Enabled = false;
                a1textbox.Enabled = false;
                a2textbox.Enabled = false;
                a3textbox.Enabled = false;
                a4textbox.Enabled = false;
                a5textbox.Enabled = false;
                deniedTimer.Enabled = false;
                notepad.Enabled = false;
                errorProvider1.Dispose();
                this.BackColor = Color.LightGray;
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "stairwelltheme.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.Play();
                toa6.Start();
            }
            else if (a1textbox.Text == "0" && a2textbox.Text == "0" && a3textbox.Text == "1" && a4textbox.Text == "0" && a5textbox.Text == "0")
            {
                denied.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label21.Text = "";
                dt = DateTime.Now;
                log.Text += dt.ToShortTimeString() + " - Attempt #6 requested.\n";
                log.ForeColor = Color.MediumBlue;
                log.BackColor = Color.LightGray;
                attempt1.Enabled = false;
                attempt1.BackColor = Color.Black;
                attempt2.Enabled = false;
                attempt2.BackColor = Color.Black;
                attempt3.Enabled = false;
                attempt3.BackColor = Color.Black;
                attempt4.Enabled = false;
                attempt4.BackColor = Color.Black;
                attempt5.Enabled = false;
                attempt5.BackColor = Color.Black;
                button1.Enabled = false;
                a1textbox.Enabled = false;
                a2textbox.Enabled = false;
                a3textbox.Enabled = false;
                a4textbox.Enabled = false;
                a5textbox.Enabled = false;
                deniedTimer.Enabled = false;
                notepad.Enabled = false;
                errorProvider1.Dispose();
                this.BackColor = Color.LightGray;
                System.Media.SoundPlayer begin2 = new System.Media.SoundPlayer(@"X:\ER-Audacitated\stairwelltheme.wav");
                begin2.Play();
                toa6.Start();
            }
            else if (a1textbox.Text == "5" && a2textbox.Text == "4" && a3textbox.Text == "3" && a4textbox.Text == "2" && a5textbox.Text == "0")
            {
                System.Media.SoundPlayer begin2 = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                begin2.Play();
                Hide();
                blackmarket form = new blackmarket();
                form.ShowDialog();
                Close();
            }
            else if (a1textbox.Text == "5" && a2textbox.Text == "4" && a3textbox.Text == "0" && a4textbox.Text == "2" && a5textbox.Text == "3")
            {
                System.Media.SoundPlayer begin2 = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                begin2.Play();
                Hide();
                blackmarket form = new blackmarket();
                form.ShowDialog();
                Close();
            }
            else if (a1textbox.Text == "4" && a2textbox.Text == "2" && a3textbox.Text == "9" && a4textbox.Text == "0" && a5textbox.Text == "6")
            {
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\thanksforplaying.wav");
                begin.Play();
                Hide();
                winscreen form = new winscreen();
                form.ShowDialog();
                Close();
            }
            else if (a1textbox.Text == "4" && a2textbox.Text == "2" && a3textbox.Text == "6" && a4textbox.Text == "0" && a5textbox.Text == "9")
            {
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\thanksforplaying.wav");
                begin.Play();
                Hide();
                winscreen form = new winscreen();
                form.ShowDialog();
                Close();
            }
            else
            {
                denied.Text = "Your code is invalid.";
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "woods.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.Play();
                button1.Enabled = false;
                deniedTimer.Enabled = true;
                notepad.Enabled = false;
                dateTimePicker1.Enabled = false;
                a1textbox.Enabled = false;
                a2textbox.Enabled = false;
                a3textbox.Enabled = false;
                a4textbox.Enabled = false;
                a5textbox.Enabled = false;
                errorProvider1.Dispose();
                errorProvider1.SetError(a1textbox, "AUTHENTICATION IS INVALID");
                errorProvider1.SetError(a2textbox, "AUTHENTICATION IS INVALID");
                errorProvider1.SetError(a3textbox, "AUTHENTICATION IS INVALID");
                errorProvider1.SetError(a4textbox, "AUTHENTICATION IS INVALID");
                errorProvider1.SetError(a5textbox, "AUTHENTICATION IS INVALID");
                log.ForeColor = Color.Red;
                dt = DateTime.Now;
                log.Text += dt.ToShortTimeString() + " - No such code exists.\n";
            }
        }

        private void notreal_Tick(object sender, EventArgs e)
        {
            notreal.Stop();
            denied.Visible = false;
            dateTimePicker1.Visible = false;
            notepad.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label21.Visible = false;
            a1gone.Start();
        }

        private void a1gone_Tick(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "finalambient.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.PlayLooping();
            a1gone.Stop();
            a1textbox.Visible = false;
            attempt1.Visible = false;
            a2gone.Start();
        }

        private void a2gone_Tick(object sender, EventArgs e)
        {
            a2gone.Stop();
            a2textbox.Visible = false;
            attempt2.Visible = false;
            a3gone.Start();
        }

        private void a3gone_Tick(object sender, EventArgs e)
        {
            a3gone.Stop();
            a3textbox.Visible = false;
            attempt3.Visible = false;
            a4gone.Start();
        }

        private void a4gone_Tick(object sender, EventArgs e)
        {
            a4gone.Stop();
            a4textbox.Visible = false;
            attempt4.Visible = false;
            a5gone.Start();
        }

        private void a5gone_Tick(object sender, EventArgs e)
        {
            a5gone.Stop();
            a5textbox.Visible = false;
            attempt5.Visible = false;
            button1.Visible = false;
            todark.Start();
        }

        private void todark_Tick(object sender, EventArgs e)
        {
            todark.Stop();
            this.BackColor = Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tofullscreen.Start();
        }

        private void tofullscreen_Tick(object sender, EventArgs e)
        {
            tofullscreen.Stop();
            this.WindowState = FormWindowState.Maximized;
            firsttext.Start();
        }

        private void firsttext_Tick(object sender, EventArgs e)
        {
            firsttext.Stop();
            changedLabel.Visible = true;
            endOfAlpha.Start();
        }

        private void endOfAlpha_Tick(object sender, EventArgs e)
        {
            endOfAlpha.Stop();
            Hide();
            decoy form = new decoy();
            form.ShowDialog();
            Close();
        }

        private void toFlash1_Tick(object sender, EventArgs e)
        {
            toFlash1.Stop();
            this.BackgroundImage = Properties.Resources.a41;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            this.BackColor = Color.Black;
            denied.Text = "";
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "incorrect.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.Play();
            flash1.Start();
        }

        private void flash1_Tick(object sender, EventArgs e)
        {
            flash1.Stop();
            this.BackgroundImage = null;
            this.BackColor = Color.LightSlateGray;
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "halt.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.Play();
            denied.Text = "Your code is invalid.";
        }

        private void Alpha_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            dt = DateTime.Now;
            log.Text += dt.ToShortTimeString() + " - Help requested.\n";
            log.ForeColor = Color.MediumBlue;
            const string message = "PPV91 SYSTEM/NTAUTHORITY/leaveB117.h/keeAryr5z%OcJLcr begin help protocol?";
            const string caption = "Help";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                this.Cursor = Cursors.Arrow;
            }
            if (result == DialogResult.OK)
            {
                errorProvider1.Dispose();
                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string directory = Path.GetDirectoryName(path);
                path = Path.Combine(directory, "white_face1.wav");
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                sound.Play();
                this.Cursor = Cursors.Arrow;
                help form = new help();
                form.ShowDialog();
            }
        }

        private void Alpha_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Are you sure you want to terminate Project_Viper_Puzzle2017.exe?";
            const string caption = "Warning";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                this.Cursor = Cursors.Arrow;
            }
            if (result == DialogResult.Yes)
            {
                kill();
            }
        }

        private void afterHelp_Tick(object sender, EventArgs e)
        {
            afterHelp.Stop();
        }

        private void a1textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (a1textbox.Text == "3")
                {
                    dt = DateTime.Now;
                    log.Text += dt.ToShortTimeString() + " - Attempt #2 requested.\n";
                    log.ForeColor = Color.MediumBlue;
                    a1textbox.Text = "";
                    linkLabel1.Text = "CLICK ME";
                    string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string directory = Path.GetDirectoryName(path);
                    path = Path.Combine(directory, "laugh.wav");
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                    sound.Play();
                    wellDone.Text = "ACCESS GRANTED";
                    label20.Text = "Thank you for choosing us.";
                    a1textbox.Visible = false;
                    attempt1.Enabled = false;
                    attempt1.BackColor = Color.Black;
                    attempt2.Enabled = false;
                    attempt2.BackColor = Color.Black;
                    attempt3.Enabled = false;
                    attempt3.BackColor = Color.Black;
                    attempt4.Enabled = false;
                    attempt4.BackColor = Color.Black;
                    attempt5.Enabled = false;
                    attempt5.BackColor = Color.Black;
                    button1.Enabled = false;
                    a2timer.Enabled = true;
                    errorProvider1.Dispose();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    label11.Text = "Textbox #1 is invalid.";
                    attempt2.Enabled = false;
                    a2denied.Enabled = true;
                    errorProvider1.Dispose();
                    errorProvider1.SetError(a1textbox, "AUTHENTICATION IS INVALID");
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void a2textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (a2textbox.Text == "q")
                {
                    dt = DateTime.Now;
                    log.Text += dt.ToShortTimeString() + " - Attempt #3 requested.\n";
                    log.ForeColor = Color.MediumBlue;
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\defenddryer.wav");
                    begin.Play();
                    a2textbox.Text = "";
                    rememberProgress.Text = "Verifying installation..";
                    attempt1.Enabled = false;
                    attempt1.BackColor = Color.Black;
                    attempt2.Enabled = false;
                    attempt2.BackColor = Color.Black;
                    attempt3.Enabled = false;
                    attempt3.BackColor = Color.Black;
                    attempt4.Enabled = false;
                    attempt4.BackColor = Color.Black;
                    attempt5.Enabled = false;
                    attempt5.BackColor = Color.Black;
                    button1.Enabled = false;
                    a3timer.Enabled = true;
                    a1textbox.Enabled = false;
                    deniedTimer.Enabled = false;
                    a2textbox.Enabled = false;
                    a3textbox.Enabled = false;
                    a4textbox.Enabled = false;
                    a5textbox.Enabled = false;
                    notepad.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    errorProvider1.Dispose();
                    this.ControlBox = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    label14.Text = "Textbox #2 is invalid.";
                    attempt3.Enabled = false;
                    a3denied.Enabled = true;
                    errorProvider1.Dispose();
                    errorProvider1.SetError(a2textbox, "AUTHENTICATION IS INVALID");
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void a3textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (a3textbox.Text == "y8")
                {
                    dt = DateTime.Now;
                    log.Text += dt.ToShortTimeString() + " - Attempt #4 requested: failure.\n";
                    log.ForeColor = Color.Red;
                    string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    string directory = Path.GetDirectoryName(path);
                    path = Path.Combine(directory, "halt.wav");
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
                    sound.Play();
                    label15.Text = "NOTHING";
                    label16.Text = "IS";
                    label17.Text = "REAL";
                    label2.Text = "DIE DIE DIE DIE DIE";
                    label3.Text = "DIE DIE DIE DIE DIE";
                    label4.Text = "DIE DIE DIE DIE DIE";
                    label1.Text = "";
                    label18.Text = "FATAL_ERROR003303";
                    label21.Text = "kTLDOo5iCkJSxjNjDK566chVQPuG64fRh+jNzgP54=";
                    a1textbox.Enabled = false;
                    a2textbox.Enabled = false;
                    a3textbox.Enabled = false;
                    a4textbox.Enabled = false;
                    a5textbox.Enabled = false;
                    a3textbox.Text = "";
                    deniedTimer.Enabled = false;
                    attempt1.Enabled = false;
                    attempt1.BackColor = Color.Black;
                    attempt2.Enabled = false;
                    attempt2.BackColor = Color.Black;
                    attempt3.Enabled = false;
                    attempt3.BackColor = Color.Black;
                    attempt4.Enabled = false;
                    attempt4.BackColor = Color.Black;
                    attempt5.Enabled = false;
                    attempt5.BackColor = Color.Black;
                    button1.Enabled = false;
                    a4realtoillusion.Enabled = true;
                    notepad.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    errorProvider1.Dispose();
                    this.ControlBox = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    label13.Text = "Textbox #3 is invalid.";
                    attempt4.Enabled = false;
                    a4denied.Enabled = true;
                    errorProvider1.Dispose();
                    errorProvider1.SetError(a3textbox, "AUTHENTICATION IS INVALID");
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void a4textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (a4textbox.Text == "4bk")
                {
                    dt = DateTime.Now;
                    log.Text += dt.ToShortTimeString() + " - Attempt #5 requested.\n";
                    log.ForeColor = Color.MediumBlue;
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\a5officemusic.wav");
                    begin.PlayLooping();
                    this.BackColor = Color.Black;
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label21.Visible = false;
                    toHelpProvider.Start();
                    a4textbox.Text = "";
                    button1.Enabled = false;
                    deniedTimer.Enabled = false;
                    a1textbox.Enabled = false;
                    a2textbox.Enabled = false;
                    a3textbox.Enabled = false;
                    a4textbox.Enabled = false;
                    a5textbox.Enabled = false;
                    attempt1.Enabled = false;
                    attempt2.Enabled = false;
                    attempt3.Enabled = false;
                    attempt4.Enabled = false;
                    attempt5.Enabled = false;
                    attempt1.BackColor = Color.Black;
                    attempt2.BackColor = Color.Black;
                    attempt3.BackColor = Color.Black;
                    attempt4.BackColor = Color.Black;
                    attempt5.BackColor = Color.Black;
                    notepad.Enabled = false;
                    dateTimePicker1.Visible = false;
                    errorProvider1.Dispose();
                    this.ControlBox = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    label12.Text = "Textbox #4 is invalid.";
                    attempt5.Enabled = false;
                    a5denied.Enabled = true;
                    errorProvider1.Dispose();
                    errorProvider1.SetError(a4textbox, "AUTHENTICATION IS INVALID");
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void a5textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (a1textbox.Text == "3" && a2textbox.Text == "q" && a3textbox.Text == "y8" && a4textbox.Text == "4bk" && a5textbox.Text == "x7l")
                {
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                    begin.Play();
                    notreal.Start();
                    toFlash1.Start();
                    denied.Text = "Your code is invalid.";
                    attempt1.Enabled = false;
                    attempt2.Enabled = false;
                    attempt3.Enabled = false;
                    attempt4.Enabled = false;
                    attempt5.Enabled = false;
                    button1.Enabled = false;
                    errorProvider1.Dispose();
                    this.ControlBox = false;
                    //kill();
                    log.Visible = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (a1textbox.Text == "0" && a2textbox.Text == "0" && a3textbox.Text == "0" && a4textbox.Text == "0" && a5textbox.Text == "1")
                {
                    dt = DateTime.Now;
                    log.Text += dt.ToShortTimeString() + " - Attempt #6 requested.\n";
                    log.ForeColor = Color.MediumBlue;
                    log.BackColor = Color.LightGray;
                    denied.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label21.Text = "";
                    attempt1.Enabled = false;
                    attempt1.BackColor = Color.Black;
                    attempt2.Enabled = false;
                    attempt2.BackColor = Color.Black;
                    attempt3.Enabled = false;
                    attempt3.BackColor = Color.Black;
                    attempt4.Enabled = false;
                    attempt4.BackColor = Color.Black;
                    attempt5.Enabled = false;
                    attempt5.BackColor = Color.Black;
                    button1.Enabled = false;
                    a1textbox.Enabled = false;
                    a2textbox.Enabled = false;
                    a3textbox.Enabled = false;
                    a4textbox.Enabled = false;
                    a5textbox.Enabled = false;
                    deniedTimer.Enabled = false;
                    notepad.Enabled = false;
                    errorProvider1.Dispose();
                    this.BackColor = Color.LightGray;
                    System.Media.SoundPlayer begin2 = new System.Media.SoundPlayer(@"X:\ER-Audacitated\stairwelltheme.wav");
                    begin2.Play();
                    toa6.Start();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (a1textbox.Text == "0" && a2textbox.Text == "0" && a3textbox.Text == "1" && a4textbox.Text == "0" && a5textbox.Text == "0")
                {
                    dt = DateTime.Now;
                    log.Text += dt.ToShortTimeString() + " - Attempt #6 requested.\n";
                    log.ForeColor = Color.MediumBlue;
                    log.BackColor = Color.LightGray;
                    denied.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label21.Text = "";
                    attempt1.Enabled = false;
                    attempt1.BackColor = Color.Black;
                    attempt2.Enabled = false;
                    attempt2.BackColor = Color.Black;
                    attempt3.Enabled = false;
                    attempt3.BackColor = Color.Black;
                    attempt4.Enabled = false;
                    attempt4.BackColor = Color.Black;
                    attempt5.Enabled = false;
                    attempt5.BackColor = Color.Black;
                    button1.Enabled = false;
                    a1textbox.Enabled = false;
                    a2textbox.Enabled = false;
                    a3textbox.Enabled = false;
                    a4textbox.Enabled = false;
                    a5textbox.Enabled = false;
                    deniedTimer.Enabled = false;
                    notepad.Enabled = false;
                    errorProvider1.Dispose();
                    this.BackColor = Color.LightGray;
                    System.Media.SoundPlayer begin2 = new System.Media.SoundPlayer(@"X:\ER-Audacitated\stairwelltheme.wav");
                    begin2.Play();
                    toa6.Start();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (a1textbox.Text == "5" && a2textbox.Text == "4" && a3textbox.Text == "3" && a4textbox.Text == "2" && a5textbox.Text == "0")
                {
                    System.Media.SoundPlayer begin2 = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                    begin2.Play();
                    Hide();
                    blackmarket form = new blackmarket();
                    form.ShowDialog();
                    Close();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (a1textbox.Text == "5" && a2textbox.Text == "4" && a3textbox.Text == "0" && a4textbox.Text == "2" && a5textbox.Text == "3")
                {
                    System.Media.SoundPlayer begin2 = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                    begin2.Play();
                    Hide();
                    blackmarket form = new blackmarket();
                    form.ShowDialog();
                    Close();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (a1textbox.Text == "4" && a2textbox.Text == "2" && a3textbox.Text == "9" && a4textbox.Text == "0" && a5textbox.Text == "6")
                {
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\thanksforplaying.wav");
                    begin.Play();
                    Hide();
                    winscreen form = new winscreen();
                    form.ShowDialog();
                    Close();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (a1textbox.Text == "4" && a2textbox.Text == "2" && a3textbox.Text == "6" && a4textbox.Text == "0" && a5textbox.Text == "9")
                {
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\thanksforplaying.wav");
                    begin.Play();
                    Hide();
                    winscreen form = new winscreen();
                    form.ShowDialog();
                    Close();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    denied.Text = "Your code is invalid.";
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\woods.wav");
                    begin.Play();
                    button1.Enabled = false;
                    deniedTimer.Enabled = true;
                    notepad.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    a1textbox.Enabled = false;
                    a2textbox.Enabled = false;
                    a3textbox.Enabled = false;
                    a4textbox.Enabled = false;
                    a5textbox.Enabled = false;
                    errorProvider1.Dispose();
                    errorProvider1.SetError(a1textbox, "AUTHENTICATION IS INVALID");
                    errorProvider1.SetError(a2textbox, "AUTHENTICATION IS INVALID");
                    errorProvider1.SetError(a3textbox, "AUTHENTICATION IS INVALID");
                    errorProvider1.SetError(a4textbox, "AUTHENTICATION IS INVALID");
                    errorProvider1.SetError(a5textbox, "AUTHENTICATION IS INVALID");
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    log.ForeColor = Color.Red;
                    dt = DateTime.Now;
                    log.Text += dt.ToShortTimeString() + " - No such code exists.\n";
                }
            }
        }

        private void cursorShowTest_Tick(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Focus();
            zeroButton.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            DateTime dateToCheck2 = DateTime.ParseExact("02/28/1984", "MM/dd/yyyy", ci);
            if (dateTimePicker1.Value <= dateToCheck2)
            {
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                begin.Play();
                Hide();
                zero form = new zero();
                form.ShowDialog();
                Close();
            }
            else
            {
                zeroButton.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "halt.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.Play();
            button2.Visible = false;
            button3.Visible = false;
            a1timer.Enabled = true;
            label23.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //go back to normal
            button2.Visible = false;
            button3.Visible = false;
            label22.Visible = false;
            button1.ForeColor = Color.DarkSlateGray;
            label21.Visible = true;
            attempt1.Enabled = true;
            attempt1.BackColor = Color.Silver;
            attempt2.Enabled = true;
            attempt2.BackColor = Color.Silver;
            attempt3.Enabled = true;
            attempt3.BackColor = Color.Silver;
            attempt4.Enabled = true;
            attempt4.BackColor = Color.Silver;
            attempt5.Enabled = true;
            attempt5.BackColor = Color.Silver;
            button1.Enabled = true;
            a1textbox.Enabled = true;
            a2textbox.Enabled = true;
            a3textbox.Enabled = true;
            a4textbox.Enabled = true;
            a5textbox.Enabled = true;
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            notepad.Enabled = true;
            dateTimePicker1.Enabled = true;
            errorProvider1.Dispose();
            this.ControlBox = true;
        }
    }
}
