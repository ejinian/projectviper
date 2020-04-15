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
    public partial class spam4 : Form
    {
        public spam4()
        {
            InitializeComponent();
        }

        private void spam4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void spam4_Load(object sender, EventArgs e)
        {
            Cursor.Show();
            spam4timer.Start();
        }

        private void spam4timer_Tick(object sender, EventArgs e)
        {
            spam4timer.Stop();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            spam4timer2.Start();
        }

        private void spam4timer2_Tick(object sender, EventArgs e)
        {
            spam4timer2.Stop();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            spam4timer.Start();
        }
    }
}
