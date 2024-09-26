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
    public partial class user_login_page : Form
    {
        public user_login_page()
        {
            InitializeComponent();
        }

        private void login_btn_MouseHover(object sender, EventArgs e)
        {
            login_btn.ForeColor = Color.Black;
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.ForeColor = Color.White;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            choose_login_page clp = new choose_login_page();
            clp.Show();
            this.Visible = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_signup_page usp = new user_signup_page();
            usp.Show();
            this.Visible = false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            user_home_page uhp = new user_home_page();
            uhp.Show();
            this.Visible = false;
        }
    }
}
