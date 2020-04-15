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
    public partial class attempt4 : Form
    {
        public attempt4()
        {
            InitializeComponent();
        }

        private void attempt4_Load(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label14.Text = "";
            label15.Text = "";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\a4timer.wav");
            begin.Play();
            timer1.Enabled = true;
            kill.Enabled = true;
            toolate.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.changedLabel.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            changedLabel.Text = "O10sc I 1eems th0 t  erro o110rede ba ne01101 t!";
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            changedLabel.Text = "";
            timer3.Start();
            flashscare9.Start();
        }

        private void kill_Tick(object sender, EventArgs e)
        {
            Cursor.Show();
            kill.Stop();
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            label2.Text = "";
            flashscare1.Start();
        }

        private void flashscare1_Tick(object sender, EventArgs e)
        {
            flashscare1.Stop();
            this.BackColor = Color.White;
            flashscare3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            label2.Text = "A dark entity perpetually plants itself";
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            label2.Text = "";
            label3.Text = "It overwrites the domain of perception";
            godflash.Start();
            add.Start();
        }

        private void add_Tick(object sender, EventArgs e)
        {
            add.Stop();
            label3.Text = "It belongs to who?";
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            timer6.Stop();
            label4.Text = "It";
            label5.Text = "Them";
            label6.Text = "Him";
            label7.Text = "Her";
            label8.Text = "Me";
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timer7.Stop();
            label4.Text = "Them";
            label5.Text = "Her";
            label6.Text = "Me";
            label7.Text = "It";
            label8.Text = "Him";
            timer8.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            timer8.Stop();
            label4.Text = "Him";
            label5.Text = "It";
            label6.Text = "Her";
            label7.Text = "Me";
            label8.Text = "Them";
            timer9.Start();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            timer9.Stop();
            label4.Text = "Me";
            label5.Text = "Me";
            label6.Text = "Me";
            label7.Text = "Me";
            label8.Text = "Me";
            timer10.Start();
        }
        private void timer10_Tick(object sender, EventArgs e)
        {
            timer10.Stop();
            label4.Text = "Her";
            label5.Text = "Me";
            label6.Text = "It";
            label7.Text = "Them";
            label8.Text = "Him";
        }
        private void wasChangedTo_Click(object sender, EventArgs e)
        {

        }
        

        private void label5_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label3.Text = "";
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
            timer9.Stop();
            timer10.Stop();
            this.Cursor = Cursors.WaitCursor;
            timer11.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            kill.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\incorrect.wav");
            begin.Play();
            this.BackColor = Color.White;
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            kill.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\incorrect.wav"); ;
            begin.Play();
            this.BackColor = Color.White;
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            kill.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\incorrect.wav"); ;
            begin.Play();
            this.BackColor = Color.White;
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            kill.Stop();
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\incorrect.wav"); ;
            begin.Play();
            this.BackColor = Color.White;
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            timer11.Stop();
            label12.Text = "To escape the mind causes a nightmare";
            timer12.Start();
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            timer12.Stop();
            label9.Text = "To become the mind brings an endless, fatal sleep";
            timer13.Start();
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            timer13.Stop();
            label10.Text = "To fight death's jaws means to relive hell over and over";
            flashscare2.Start();
        }

        private void flashscare2_Tick(object sender, EventArgs e)
        {
            flashscare2.Stop();
            this.BackColor = Color.White;
            flashscare4.Start();
        }

        private void add2_Tick(object sender, EventArgs e)
        {
            add2.Stop();
            label10.ForeColor = Color.Red;
            label12.Text = "Open your eyes to the black emptiness";
            label9.Text = "Feel the frosted void with your mortal hands";
            label10.Text = "Become everything and nothing forevermore";
            timer14.Start();
        }

        private void toolate_Tick(object sender, EventArgs e)
        {
            leaveTextbox.Visible = false;
            button1.Visible = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            timer9.Enabled = false;
            timer10.Enabled = false;
            timer11.Enabled = false;
            timer12.Enabled = false;
            timer13.Enabled = false;
            timer14.Enabled = false;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label12.Text = "";
            secondFlash.Start();
            retardflash1.Start();
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            timer14.Stop();
            label9.Text = "";
            label10.Text = "";
            label12.Text = "";
            leaveTextbox.Visible = true;
            button1.Visible = true;
            toFirstFlash.Start();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void labelFlash_Tick(object sender, EventArgs e)
        {
            labelFlash.Stop();
            this.BackColor = Color.Black;
        }

        private void toFirstFlash_Tick(object sender, EventArgs e)
        {
            toFirstFlash.Stop();
            firstFlash.Start();
            this.BackColor = Color.Gray;
        }

        private void firstFlash_Tick(object sender, EventArgs e)
        {
            firstFlash.Stop();
            this.BackColor = Color.Black;
        }

        private void secondFlash_Tick(object sender, EventArgs e)
        {
            secondFlash.Stop();
            this.BackColor = Color.White;
            return2flash.Start();
        }

        private void return2flash_Tick(object sender, EventArgs e)
        {
            return2flash.Stop();
            this.BackColor = Color.Black;
            toNormalWindowstate.Start();
            retardflash3.Start();
            flashscare5.Start();
        }

        private void tominimize_Tick(object sender, EventArgs e)
        {
            tominimize.Stop();
            this.BackgroundImageLayout = ImageLayout.Center;
            this.BackColor = Color.Black;
            this.BackgroundImage = Properties.Resources.a41;
            this.WindowState = FormWindowState.Minimized;
            minandmax.Start();
        }

        private void minandmax_Tick(object sender, EventArgs e)
        {
            minandmax.Stop();
            this.WindowState = FormWindowState.Maximized;
        }

        private void toNormalWindowstate_Tick(object sender, EventArgs e)
        {
            toNormalWindowstate.Stop();
            this.WindowState = FormWindowState.Normal;
            label1.ForeColor = Color.Red;
            label1.Text = "AWAIT AWAIT";
            normalwsFlash.Start();
        }

        private void normalwsFlash_Tick(object sender, EventArgs e)
        {
            normalwsFlash.Stop();
            Cursor.Hide();
            this.BackColor = Color.Maroon;
            this.WindowState = FormWindowState.Maximized;
            button1.Visible = false;
            label1.Text = "";
            retardflash7.Start();
            tominimize.Start();
        }

        private void leaveTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void correctLeave_Tick(object sender, EventArgs e)
        {
            correctLeave.Stop();
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void secureNoText_Tick(object sender, EventArgs e)
        {
            
        }

        private void attempt4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                timer1.Stop(); timer2.Stop(); timer3.Stop(); timer4.Stop(); timer5.Stop(); timer6.Stop(); timer7.Stop(); timer8.Stop(); timer9.Stop(); timer10.Stop(); timer11.Stop(); timer12.Stop(); timer13.Stop(); timer14.Stop();
                labelFlash.Stop();
                toFirstFlash.Stop();
                firstFlash.Stop();
                secondFlash.Stop();
                return2flash.Stop();
                toNormalWindowstate.Stop();
                normalwsFlash.Stop();
                minandmax.Stop();
                tominimize.Stop();
                toolate.Stop();
                correctLeave.Stop();
                kill.Stop();
                flashscare1.Stop(); flashscare2.Stop(); flashscare3.Stop(); flashscare4.Stop(); flashscare5.Stop(); flashscare6.Stop(); flashscare7.Stop(); flashscare8.Stop(); flashscare9.Stop(); flashscare10.Stop(); flashscare11.Stop(); flashscare12.Stop();
                retardflash1.Stop(); retardflash2.Stop(); retardflash3.Stop(); retardflash4.Stop(); retardflash5.Stop(); retardflash6.Stop(); retardflash7.Stop(); retardflash8.Stop();
                godflash.Stop();
                godflash2.Stop();

                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                begin.Play();
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

        private void label15_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label14.Text = "";
            label15.Text = "";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\a4timer.wav");
            begin.Play();
            timer1.Enabled = true;
            kill.Enabled = true;
            toolate.Enabled = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label15.Text = "";
            label14.Text = "";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\a4timer.wav");
            begin.Play();
            timer1.Enabled = true;
            kill.Enabled = true;
            toolate.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (leaveTextbox.Text == "vp6j2")
            {
                kill.Stop();
                label11.Visible = true;
                correctLeave.Start();
                System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                begin.Play();
            }
            else
            {
                labelFlash.Start();
                this.BackColor = Color.DarkRed;
                leaveTextbox.Clear();
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.DarkRed;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.DimGray;
        }

        private void leaveTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (leaveTextbox.Text == "vp6j2")
                {
                    kill.Stop();
                    label11.Visible = true;
                    correctLeave.Start();
                    System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\halt.wav");
                    begin.Play();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    labelFlash.Start();
                    this.BackColor = Color.DarkRed;
                    leaveTextbox.Clear();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void flashscare3_Tick(object sender, EventArgs e)
        {
            flashscare3.Stop();
            this.BackColor = Color.Black;
            timer4.Start();
        }

        private void flashscare4_Tick(object sender, EventArgs e)
        {
            flashscare4.Stop();
            this.BackColor = Color.Black;
            add2.Start();
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void retardflash1_Tick(object sender, EventArgs e)
        {
            retardflash1.Stop();
            pictureBox1.Visible = true;
            retardflash2.Start();
        }

        private void retardflash2_Tick(object sender, EventArgs e)
        {
            retardflash2.Stop();
            pictureBox1.Visible = false;
        }

        private void godflash_Tick(object sender, EventArgs e)
        {
            godflash.Stop();
            this.BackColor = Color.White;
            godflash2.Start();
        }

        private void godflash2_Tick(object sender, EventArgs e)
        {
            godflash2.Stop();
            this.BackColor = Color.Black;
        }

        private void retardflash3_Tick(object sender, EventArgs e)
        {
            retardflash3.Stop();
            pictureBox2.Visible = true;
            retardflash4.Start();
        }

        private void retardflash4_Tick(object sender, EventArgs e)
        {
            retardflash4.Stop();
            pictureBox2.Visible = false;
        }

        private void flashscare5_Tick(object sender, EventArgs e)
        {
            flashscare5.Stop();
            this.BackgroundImage = Properties.Resources.loadinggif3;
            flashscare6.Start();
        }

        private void flashscare6_Tick(object sender, EventArgs e)
        {
            flashscare6.Stop();
            this.BackgroundImage = null;
            retardflash5.Start();
        }

        private void retardflash5_Tick(object sender, EventArgs e)
        {
            retardflash5.Stop();
            pictureBox3.Visible = true;
            retardflash6.Start();
        }

        private void retardflash6_Tick(object sender, EventArgs e)
        {
            retardflash6.Stop();
            pictureBox3.Visible = false;
            flashscare7.Start();
        }

        private void flashscare7_Tick(object sender, EventArgs e)
        {
            flashscare7.Stop();
            this.BackgroundImage = Properties.Resources.a4afterminimized;
            flashscare8.Start();
        }

        private void flashscare8_Tick(object sender, EventArgs e)
        {
            flashscare8.Stop();
            this.BackgroundImage = null;
        }

        private void retardflash7_Tick(object sender, EventArgs e)
        {
            retardflash7.Stop();
            this.BackgroundImage = Properties.Resources.retard4;
            retardflash8.Start();
        }

        private void retardflash8_Tick(object sender, EventArgs e)
        {
            retardflash8.Stop();
            this.BackgroundImage = null;
        }

        private void flashscare9_Tick(object sender, EventArgs e)
        {
            
        }

        private void flashscare10_Tick(object sender, EventArgs e)
        {
            flashscare10.Stop();
            this.BackgroundImage = null;
            flashscare11.Start();
        }

        private void flashscare11_Tick(object sender, EventArgs e)
        {
            
        }

        private void flashscare12_Tick(object sender, EventArgs e)
        {
            flashscare12.Stop();
            label2.Text = "";
        }

        private void flashscare9_Tick_1(object sender, EventArgs e)
        {
            flashscare9.Stop();
            this.BackgroundImage = Properties.Resources.zero;
            flashscare10.Start();
        }

        private void flashscare11_Tick_1(object sender, EventArgs e)
        {
            flashscare11.Stop();
            label2.Text = "Meaningful things become meaningless";
            flashscare12.Start();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }
    }
}
