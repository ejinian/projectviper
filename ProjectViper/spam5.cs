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
    public partial class spam5 : Form
    {
        public spam5()
        {
            InitializeComponent();
        }

        private void spam5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void spam5_Load(object sender, EventArgs e)
        {
            Cursor.Show();
        }
    }
}
