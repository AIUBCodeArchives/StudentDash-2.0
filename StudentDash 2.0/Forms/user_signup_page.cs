using StudentDash_2._0.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDash_2._0
{
    public partial class user_signup_page : Form
    {
        public user_signup_page()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            user_login_page ulp = new user_login_page();
            ulp.Show();
            this.Visible = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user_login_page ulp = new user_login_page();
            ulp.Show();
            this.Visible = false;
        }

        private void signup_btn_MouseHover(object sender, EventArgs e)
        {
            signup_btn.ForeColor = Color.Black;
        }

        private void signup_btn_MouseLeave(object sender, EventArgs e)
        {
            signup_btn.ForeColor = Color.White;
        }
    }
}
