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
    public partial class winscreen : Form
    {
        public winscreen()
        {
            InitializeComponent();
        }

        private void winscreen_Load(object sender, EventArgs e)
        {
            tomusic.Start();
        }

        private void tomusic_Tick(object sender, EventArgs e)
        {
            tomusic.Stop();
            timer1.Start();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\finalambient.wav");
            begin.Play();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\woods.wav");
            begin.Play();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\spookynoise1.wav");
            begin.Play();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\laugh.wav");
            begin.Play();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\crimson.wav");
            begin.Play();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\defenddryer.wav");
            begin.Play();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\incorrect.wav");
            begin.Play();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\prestige.wav");
            begin.Play();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\a4timer.wav");
            begin.Play();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\stairwelltheme.wav");
            begin.Play();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\a5officemusic.wav");
            begin.Play();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\a5lobbymusic2.wav");
            begin.Play();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\true_mystery_box.wav");
            begin.Play();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\thanksforplaying.wav");
            begin.Play();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Because AKviper is my username for generally everything and I am not very creative.");
        }

        private void label25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's a fake application that imitates the structure of a realistic computer worm. Project Viper is obviously not at all related to a real virus. The fact that you need to install an application and then download a launcher for it is completely unnecassary. But the story behind this fake computer virus is simple. It became popular in the 90s for an unidentified reason. Over the years, Project Viper is exposed for spying on people and somehow psychologically manipulating its users into doing horrible things. After a decade, the program was completely terminated for breaking federal regulations. So here is where you come in. A curious person in the present day, who somehow has access to the one and only copy of Project Viper in the world.");
        }

        private void label26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I started making this game before the summer vacation of 2017.");
        }

        private void label27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The rest of the game is a pile of puzzle pieces. Story behind it: Everything you've experienced before the window spam is not exactly a part of Project Viper. This odd version of Project Viper that you are playing in the present day requires a code that can only be cracked by dedicated focused players. In other words, if you are fooling around and are not taking the game seriously then you will probably never reach the ending and see what Project Viper really was. This code-retrieving section of the game is called The Puzzle.");
        }

        private void label29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is just a text that appears after a timer has finished ticking. Story behind it: Its appearance means that Project Viper has managed grow in size and hijack parts of The Puzzle, such as in Attempt #1 and Attempt #4 where abnormal events took place. An emergency application (which is that unknown text that you see) was programmed into The Puzzle in case this new version of Project Viper independently enhanced itself.");
        }

        private void label28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It was a joke at first. Then I thought this would be a good time to take a break and write a few extra scary things in addition to the spooky atmosphere. Story behind it: The messages in those links are either fake or written by mentally damaged individuals. Either way they were archived by the mysterious creators of Project Viper.");
        }

        private void label30_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = true;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\true_mystery_box.wav");
            begin.Play();
            this.BackgroundImage = Properties.Resources.decoyspook;
            thelastspook.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label30.Visible = true;
        }

        private void thelastspook_Tick(object sender, EventArgs e)
        {
            thelastspook.Stop();
            this.BackgroundImage = null;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label29.Visible = true;
            label31.Visible = false;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"C:/\Users\Ernest\Music\Audacitated\halt.wav");
            begin.Play();
        }

        private void winscreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
