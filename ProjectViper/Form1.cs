using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectViper
{
    public partial class Form1 : Form
    {
        string textboxValue;
        public Form1()
        {
            InitializeComponent(); //timer1.start is 3000
            //timer2.start is 4500
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Cursor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project Viper is a remake of a horror puzzle game I made a year ago called 'Virus'. It was a dull advertisement-simulator application designed to fool the player and potentially crash their operating system by simply executing a few lines of code that allowed for rapid pop-up window replication. Unlike Virus, this game tests your level of focus and brain processing, and it wasn't created for comedic purposes. It is simply an evolution of the concept of Virus, with the implication of ordinary horror components. The premise of the game revolves around the exposure of freakish, unconventional, and unintuitive user interface. Meaning you are entering this experiment blind, and the only way to move on is to learn from trial and error. It is up to the player to feel and distinguish between what is important and what is there just to scare you. As you progress, further instructions will be provided.");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.Red;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.ForeColor = Color.DarkSlateGray;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.Red;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.ForeColor = Color.DarkSlateGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer3.Stop();
            label2.Text = "Please make sure to wear headphones and stay seated at all times.";
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
            label6.ForeColor = Color.Red;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            label1.ForeColor = Color.Red;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
            begin.Play();
            label7.Text = "Learn the components";
            label7.ForeColor = Color.Red;
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
            notepad.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            a1textbox.Visible = false;
            pictureBox2.Visible = false;
            button4.Visible = false;
            attempt1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label3.Text = "For the safety of your machine, press the ESC button to force quit in the case of any malfunctions.";
            timer2.Start();
            timer4.Start();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.DarkSlateGray;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                MessageBox.Show("Null");
            } else
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void attempt1_Click(object sender, EventArgs e)
        {
            if (a1textbox.Text == "")
            {
                label16.Text = "You have typed nothing";
                label16.Visible = true;
            }
            else
            {
                textboxValue = a1textbox.Text;
                label16.Visible = true;
                label16.Text = String.Format("You have typed '{0}'", textboxValue);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "morespookymusic2.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.PlayLooping();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directory = Path.GetDirectoryName(path);
            path = Path.Combine(directory, "finalambient.wav");
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(path);
            sound.PlayLooping();
        }

        private void attempt1_MouseDown(object sender, MouseEventArgs e)
        {
            attempt1.ForeColor = Color.Red;
        }

        private void attempt1_MouseUp(object sender, MouseEventArgs e)
        {
            attempt1.ForeColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hovering over these will inform you of any errors.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicking this will provide you with instructions and suggestions.");
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicking this will open a notepad file for you to take notes on. The notepad file also provides you with all the possible places to visit.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SEIZURE WARNING: There are lots of flashing lights in this game.");
        }
    }
}
