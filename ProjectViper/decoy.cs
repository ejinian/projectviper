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
    public partial class decoy : Form
    {
        public decoy()
        {
            InitializeComponent();
        }

        private void decoy_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\finalambientstretched.wav");
            begin.PlayLooping();
        }

        private void a2textbox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.BackgroundImage = Properties.Resources.experiment6;
            System.Media.SoundPlayer begin = new System.Media.SoundPlayer(@"X:\ER-Audacitated\true_mystery_box.wav");
            begin.Play();
            scare.Hide();
            label1.Hide();
            moveToSecondDecoy.Start();
        }

        private void moveToSecondDecoy_Tick(object sender, EventArgs e)
        {
            moveToSecondDecoy.Stop();
            Hide();
            decoy2 form = new decoy2();
            form.ShowDialog();
            Close();
        }

        private void decoy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
