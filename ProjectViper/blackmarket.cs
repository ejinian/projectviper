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

namespace ProjectViper
{
    public partial class blackmarket : Form
    {
        public blackmarket()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label8.Visible = true;
                takeAwayRed.Start();
            }
            else if (textBox1.Text == "wraith")
            {
                postwraith.Start();
                flash.Start();
                label10.Visible = true;
                reappearClue.Stop();
            }
            else
            {
                pictureBox2.Visible = true;
                loadWebsite.Start();
            }
        }

        private void beginMusic_Tick(object sender, EventArgs e)
        {
            beginMusic.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\blackmarket.wav");
            begin.PlayLooping();
        }

        private void takeAwayRed_Tick(object sender, EventArgs e)
        {
            takeAwayRed.Stop();
            label8.Visible = false;
        }
        //links
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox2.Visible = true;
            loadWebsite.Start();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox2.Visible = true;
            linkLabel3.Enabled = false;
            beginMusic.Stop();
            toStatic.Start();
            loadWebsite3.Start();
            afterStatic.Start();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox2.Visible = true;
            loadWebsite2.Start();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox2.Visible = true;
            beginMusic.Stop();
            loadWebsite4.Start();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox2.Visible = true;
            beginMusic.Stop();
            loadWebsite5.Start();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox2.Visible = true;
            beginMusic.Stop();
            loadWebsite6.Start();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox2.Visible = true;
            loadWebsite7.Start();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.Play();
            Hide();
            attempt5 form = new attempt5();
            form.ShowDialog();
            Close();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel8.Visible = false;
            beginMusic.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.Play();
            label7.Text = "WRAITHWRAITHWRAITHWRAITHWRAITHWRAITHWRAITHWRAITH";
            notepad.Text = "WRAITHWRAITHWRAITHWRAITHWRAITHWRAITHWRAITHWRAITH";
            textBox1.Text = "WRAITH";
            label9.Visible = true;
            pictureBox4.Visible = true;
            hint.Start();
            reappearClue.Start();
        }
        //timers
        private void loadWebsite_Tick(object sender, EventArgs e)
        {
            loadWebsite.Stop();
            pictureBox2.Visible = false;
            error404 form = new error404();
            form.ShowDialog();
        }

        private void loadWebsite2_Tick(object sender, EventArgs e)
        {
            loadWebsite2.Stop();
            pictureBox2.Visible = false;
            error403 form = new error403();
            form.ShowDialog();
        }

        private void loadWebsite3_Tick(object sender, EventArgs e)
        {
            loadWebsite3.Stop();
            pictureBox2.Visible = false;
            merciful form = new merciful();
            form.ShowDialog();
        }

        private void loadWebsite4_Tick(object sender, EventArgs e)
        {
            loadWebsite4.Stop();
            pictureBox2.Visible = false;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\lifeinserenity.wav");
            begin.Play();
            lifeinserenity form = new lifeinserenity();
            form.ShowDialog();
        }

        private void loadWebsite5_Tick(object sender, EventArgs e)
        {
            loadWebsite5.Stop();
            pictureBox2.Visible = false;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\117arms.wav");
            begin.Play();
            seized form = new seized();
            form.ShowDialog();
        }

        private void loadWebsite6_Tick(object sender, EventArgs e)
        {
            loadWebsite6.Stop();
            pictureBox2.Visible = false;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\ER-Rage\omen.wav");
            begin.Play();
            omen form = new omen();
            form.ShowDialog();
        }

        private void loadWebsite7_Tick(object sender, EventArgs e)
        {
            loadWebsite7.Stop();
            pictureBox2.Visible = false;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\origins.wav");
            begin.Play();
            origins form = new origins();
            form.ShowDialog();
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            notepad.Text = "";
            Process.Start("X:\\notes.txt");
        }

        private void toStatic_Tick(object sender, EventArgs e)
        {
            toStatic.Stop();
            pictureBox3.Visible = true;
        }

        private void afterStatic_Tick(object sender, EventArgs e)
        {
            afterStatic.Stop();
            //System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\blackmarket.wav");
            //begin.PlayLooping();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    label8.Visible = true;
                    takeAwayRed.Start();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (textBox1.Text == "wraith")
                {
                    postwraith.Start();
                    flash.Start();
                    label10.Visible = true;
                    reappearClue.Stop();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    pictureBox2.Visible = true;
                    loadWebsite.Start();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void hint_Tick(object sender, EventArgs e)
        {
            hint.Stop();
            label7.Text = "Search for website names";
            notepad.Text = "Click for notes";
            textBox1.Text = "";
            label9.Visible = false;
            pictureBox4.Visible = false;
        }

        private void postwraith_Tick(object sender, EventArgs e)
        {
            postwraith.Stop();
            pictureBox1.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            label11.Visible = false;
            label7.Visible = false;
            textBox1.Visible = false;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\spookynoise69.wav");
            begin.Play();
            this.BackColor = Color.MidnightBlue;
            button1.ForeColor = Color.White;
            button1.BackgroundImage = Properties.Resources.blckbackground;
            label5.Text = "ɹǝdᴉΛ ʇɔǝɾoɹԀ ʎq pǝɹǝʍoԀ";
            label5.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button2.BackgroundImage = Properties.Resources.blckbackground;
            button2.Visible = true;
            bsod form = new bsod();
            form.ShowDialog();
        }

        private void flash_Tick(object sender, EventArgs e)
        {
            flash.Stop();
            label10.Visible = false;
        }

        private void reappearClue_Tick(object sender, EventArgs e)
        {
            reappearClue.Stop();
            linkLabel8.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            label12.Visible = true;
            label13.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
