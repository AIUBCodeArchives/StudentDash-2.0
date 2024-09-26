using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDash_2._0.Forms
{
    public partial class home_contact_us : Form
    {
        public home_contact_us()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Report_btn_MouseHover(object sender, EventArgs e)
        {
            Report_btn.ForeColor = Color.Black;
        }

        private void Report_btn_MouseLeave(object sender, EventArgs e)
        {
            Report_btn.ForeColor = Color.White;
        }
    }
}
