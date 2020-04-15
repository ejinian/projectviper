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
    public partial class wincodescreen : Form
    {
        TimeSpan selfdestruct = new TimeSpan(0, 0, 5);
        public wincodescreen()
        {
            InitializeComponent();
        }

        private void wincodescreen_Load(object sender, EventArgs e)
        {
            selfdestructtimer.Start();
        }

        private void selfdestructtimer_Tick(object sender, EventArgs e)
        {
            selfdestruct -= TimeSpan.FromSeconds(1);
            timerlabel.Text = selfdestruct.ToString();
            if (selfdestruct.Seconds <= -1)
            {
                selfdestructtimer.Stop();
                Application.Exit();
            }
        }

        private void wincodescreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
