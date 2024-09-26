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
    public partial class choose_login_page : Form
    {
        public choose_login_page()
        {
            InitializeComponent();
        }

        private void user_btn_MouseHover(object sender, EventArgs e)
        {
            user_btn.ForeColor = Color.Black;
        }

        private void user_btn_MouseLeave(object sender, EventArgs e)
        {
            user_btn.ForeColor = Color.White;
        }

        private void admin_btn_MouseHover(object sender, EventArgs e)
        {
            admin_btn.ForeColor = Color.Black;
        }

        private void admin_btn_MouseLeave(object sender, EventArgs e)
        {
            admin_btn.ForeColor = Color.White;
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            user_login_page ulp = new user_login_page();
            ulp.Visible = true;
            this.Visible = false;
        }
    }
}
