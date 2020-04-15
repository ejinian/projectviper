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
    public partial class a3main : Form
    {
        public a3main()
        {
            InitializeComponent();
        }

        private void SetupHoverEvents(Control container)
        {
            foreach (Control control in container.Controls)
            {
                control.MouseHover += HandleHover;
            }
        }
        
        private void a3main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Cursor.Show();
            SetupHoverEvents(this);
        }

        private void HandleHover(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            //MessageBox.Show(string.Format("{0} was clicked!", control.Name));
            control.ForeColor = Color.White;
        }

        private void iseeit_Click(object sender, EventArgs e)
        {
            iseeit.Enabled = false;
            Hide();
            Alpha form = new Alpha();
            form.ShowDialog();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //a3 picturebox replacement
        }

        private void iseeit_MouseDown(object sender, MouseEventArgs e)
        {
            iseeit.ForeColor = Color.DarkRed;
            iseeit.BackColor = Color.Red;
        }

        private void iseeit_MouseUp(object sender, MouseEventArgs e)
        {
            iseeit.ForeColor = Color.Red;
            iseeit.BackColor = Color.Black;
        }

        private void a3main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && e.Shift)
            {
                Hide();
                attempt3 form = new attempt3();
                form.ShowDialog();
                Close();
            } else
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
