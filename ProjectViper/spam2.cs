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
    public partial class spam2 : Form
    {
        public spam2()
        {
            InitializeComponent();
        }

        private void spam2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void spam2_Load(object sender, EventArgs e)
        {
            Cursor.Show();
            spam2globaltimer1.Start();
        }

        private void spam1globaltimer_Tick(object sender, EventArgs e)
        {
            spam2globaltimer1.Stop();
            this.BackgroundImage = Properties.Resources.wraith;
            spam2globaltimer2.Start();
        }

        private void spam2globaltimer_Tick(object sender, EventArgs e)
        {
            spam2globaltimer2.Stop();
            this.BackgroundImage = Properties.Resources.ma;
            spam2globaltimer1.Start();
        }
    }
}
