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
    public partial class decoy2 : Form
    {
        Random random = new Random();
        Random random2 = new Random();
        Random random3 = new Random();
        Random random4 = new Random();
        Random random5 = new Random();
        public decoy2()
        {
            InitializeComponent();
        }

        private void decoy2_Load(object sender, EventArgs e)
        {
            startUpBar.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void startUpBar_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 10)
            {
                label1.Visible = true;
            }
            if (progressBar1.Value == 27)
            {
                label2.Visible = true;
            }
            if (progressBar1.Value == 35)
            {
                this.BackgroundImage = Properties.Resources.josheyebleed;
            }
            if (progressBar1.Value == 50)
            {
                notifyIcon1.Text = "Project Viper Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "PRESS ESC";
                notifyIcon1.BalloonTipTitle = "Your computer is under attack.";
                notifyIcon1.ShowBalloonTip(1000);
            }
            if (progressBar1.Value == 70)
            {
                startUpBar.Stop();
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\prestige2.wav");
                begin.Play();
                theEnd.Start();
                globalTimer1.Start();
                globalTimer2.Start();
                globalTimer3.Start();
                globalTimer4.Start();
                globalTimer5.Start();
            }
        }

        private void globalTimer1_Tick(object sender, EventArgs e)
        {
            spam1 form = new spam1();
            form.Show();
            form.Location = new Point(random.Next(Screen.PrimaryScreen.Bounds.Width - form.Width), random.Next(Screen.PrimaryScreen.Bounds.Height - form.Height));
        }

        private void globalTimer2_Tick(object sender, EventArgs e)
        {
            spam2 form = new spam2();
            form.Show();
            form.Location = new Point(random2.Next(Screen.PrimaryScreen.Bounds.Width - form.Width), random2.Next(Screen.PrimaryScreen.Bounds.Height - form.Height));
        }

        private void globalTimer3_Tick(object sender, EventArgs e)
        {
            spam3 form = new spam3();
            form.Show();
            form.Location = new Point(random3.Next(Screen.PrimaryScreen.Bounds.Width - form.Width), random3.Next(Screen.PrimaryScreen.Bounds.Height - form.Height));
        }

        private void globalTimer4_Tick(object sender, EventArgs e)
        {
            spam4 form = new spam4();
            form.Show();
            form.Location = new Point(random4.Next(Screen.PrimaryScreen.Bounds.Width - form.Width), random4.Next(Screen.PrimaryScreen.Bounds.Height - form.Height));
        }

        private void globalTimer5_Tick(object sender, EventArgs e)
        {
            spam5 form = new spam5();
            form.Show();
            form.Location = new Point(random5.Next(Screen.PrimaryScreen.Bounds.Width - form.Width), random5.Next(Screen.PrimaryScreen.Bounds.Height - form.Height));
        }

        private void decoy2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void theEnd_Tick(object sender, EventArgs e)
        {
            globalTimer1.Stop();
            globalTimer2.Stop();
            globalTimer3.Stop();
            globalTimer4.Stop();
            globalTimer5.Stop();
        //    toWinScreen.Start();
        }

        private void toWinScreen_Tick(object sender, EventArgs e)
        {
            toWinScreen.Stop();
            wincodescreen form = new wincodescreen();
            form.ShowDialog();
        }
    }
}
