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
    public partial class attempt3 : Form
    {
        public attempt3()
        {
            InitializeComponent();
        }

        private void attempt3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Cursor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "WICKED")
            {
                label1.Text = "";
                label2.Text = "";
                label11.Text = "";
                button1.Enabled = false;
                button1.ForeColor = Color.Black;
                textBox1.Enabled = false;
                textBox1.BackColor = Color.Black;
                label3.Text = "Greetings user. PVsupport has noticed an error with your application.";
                label3timer.Start();
                label10.Visible = true;
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\prestige.wav");
                begin.Play();
            }
            else if (textBox1.Text == "")
            {

            }
            else
            {
                wrong.Start();
                button1.Enabled = false;
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label11.BackColor = Color.Black;
                this.BackColor = Color.Black;
                button1.ForeColor = Color.Black;
                textBox1.BackColor = Color.Black;
                comebackwhen.Text = "COME BACK WHEN";
                youareready.Text = "YOU ARE READY";
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\incorrect.wav");
                begin.Play();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wrong_Tick(object sender, EventArgs e)
        {
            wrong.Stop();
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void label3timer_Tick(object sender, EventArgs e)
        {
            label3timer.Stop();
            label4.Text = "Attempt #1 reacted negatively with your operating system. There is currently no way for PVsupport to resolve this issue."; 
            label4timer.Start();
        }

        private void label4timer_Tick(object sender, EventArgs e)
        {
            label4timer.Stop();
            label5.Text = "Although the cause for this is unknown, PVsupport was created by the developers for troubleshooting.";
            label5timer.Start();
        }

        private void label5timer_Tick(object sender, EventArgs e)
        {
            label5timer.Stop();
            label6.Text = "However, before we can identify the problem for you, it is important that you know how to progress through this game.";
            label6timer.Start();
        }

        private void label6timer_Tick(object sender, EventArgs e)
        {
            label6timer.Stop();
            label7.Text = "The execute button (located at the bottom of the Alpha Form) is used to unlock new puzzles. The first five visible puzzles are Attempts 1 through 5.";
            label7timer.Start();
        }

        private void label7timer_Tick(object sender, EventArgs e)
        {
            label7timer.Stop();
            label8.Text = "It is also used to access PVsupport in the future. This is the code you will need to reach us: ";
            zerozero.Visible = true;
            label8timer.Start();
        }

        private void label8timer_Tick(object sender, EventArgs e)
        {
            label8timer.Stop();
            label9.Text = "If anything unusual happens again, you will have to use that code. Note that it will only work when there is one integer per textbox.";
            label9timer.Start();
        }

        private void label9timer_Tick(object sender, EventArgs e)
        {
            label9timer.Stop();
            label12.Text = "As for Attempt #1, nobody has been able to conclude the matter. For many years, people believed that an evil force devoured the game."; 
            label10timer.Start();
        }

        private void transition_Tick(object sender, EventArgs e)
        {
            transition.Stop();
            Hide();
            a3main form = new a3main();
            form.ShowDialog();
            Close();
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            label10.Visible = false;
            label3.Text = "Greetings user. PVsupport has noticed an error with your application.";
            label4.Text = "Attempt #1 reacted negatively with your operating system. There is currently no way for PVsupport to resolve this issue.";
            label5.Text = "Although the cause for this is unknown, PVsupport was created by the developers for troubleshooting.";
            label6.Text = "However, before we can identify the problem for you, it is important that you know how to progress through this game.";
            label7.Text = "The execute button (located at the bottom of the Alpha Form) is used to unlock new puzzles. The first five visible puzzles are Attempts 1 through 5.";
            label8.Text = "It is also used to access PVsupport in the future. This is the code you will need to reach us: ";
            label9.Text = "If anything unusual happens again, you will have to use that code. Note that it will only work when there is one integer per textbox.";
            label12.Text = "As for Attempt #1, nobody has been able to conclude the matter. For many years, people believed that an evil force devoured the game.";
            label13.Text = "Sources claimed that people would hallucinate and eventually lose their minds. Of course, no such evidence exists to prove these claims.";
            label14.Text = "It is suggested of you to resume the game and report back to PVsupport if problems continue. Attempt #3 will begin shortly.";
            label15.Text = "Ceasing PVsupport...";
            label16.Text = "There is one more thing you should know. A small button is located at the very bottom left of Attempt #2.";
            zerozero.Visible = true;
            label3timer.Stop();
            label4timer.Stop();
            label5timer.Stop();
            label6timer.Stop();
            label7timer.Stop();
            label8timer.Stop();
            label9timer.Stop();
            transition.Start();
        }
        
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.DarkRed;
            button1.BackColor = Color.Red;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.ForeColor = Color.Red;
            button1.BackColor = Color.Black;
        }

        private void notepad_MouseClick(object sender, MouseEventArgs e)
        {
            notepad.Text = "";
            Process.Start("X:\\notes.txt");
        }

        private void attempt3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                wrong.Stop();
                label3timer.Stop();
                label4timer.Stop();
                label5timer.Stop();
                label6timer.Stop();
                label7timer.Stop();
                label8timer.Stop();
                label9timer.Stop();
                transition.Stop();
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                begin.Play();
                Hide();
                Alpha form = new Alpha();
                form.ShowDialog();
                Close();
            }
            else
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "WICKED")
                {
                    label1.Text = "";
                    label2.Text = "";
                    label11.Text = "";
                    button1.Enabled = false;
                    button1.ForeColor = Color.Black;
                    textBox1.Enabled = false;
                    textBox1.BackColor = Color.Black;
                    label3.Text = "Greetings user. PVsupport has noticed an error with your application.";
                    label3timer.Start();
                    label10.Visible = true;
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\prestige.wav");
                    begin.Play();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else if (textBox1.Text == "")
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    wrong.Start();
                    button1.Enabled = false;
                    label1.BackColor = Color.Black;
                    label2.BackColor = Color.Black;
                    label11.BackColor = Color.Black;
                    this.BackColor = Color.Black;
                    button1.ForeColor = Color.Black;
                    textBox1.BackColor = Color.Black;
                    comebackwhen.Text = "COME BACK WHEN";
                    youareready.Text = "YOU ARE READY";
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\incorrect.wav");
                    begin.Play();
                    notepad.Enabled = false;
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void label10timer_Tick(object sender, EventArgs e)
        {
            label10timer.Stop();
            label13.Text = "Sources claimed that people would hallucinate and eventually lose their minds. Of course, no such evidence exists to prove these claims.";
            label11timer.Start();
        }

        private void label11timer_Tick(object sender, EventArgs e)
        {
            label11timer.Stop();
            label14.Text = "It is suggested of you to resume the game and report back to PVsupport if problems continue. Attempt #3 will begin shortly."; 
            label16timer.Start();
        }

        private void label12timer_Tick(object sender, EventArgs e)
        {
            label10.Visible = false;
            label12timer.Stop();
            label15.Text = "Ceasing PVsupport...";
            transition.Start();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16timer_Tick(object sender, EventArgs e)
        {
            label16timer.Stop();
            label16.Text = "There is one more thing you should know. A small button is located at the very bottom left of Attempt #2.";
            label12timer.Start();
        }
    }
}
