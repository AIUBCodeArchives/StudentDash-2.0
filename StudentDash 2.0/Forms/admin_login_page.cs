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
    public partial class admin_login_page : Form
    {
        public admin_login_page()
        {
            InitializeComponent();
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

        private void login_btn_MouseHover(object sender, EventArgs e)
        {
            login_btn.ForeColor = Color.Black;
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.ForeColor = Color.White;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            admin_home_page ahp = new admin_home_page();
            ahp.Show();
            this.Visible = false;
        }

        private void clear_all_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_id_txtbox.Clear();
            password_txtbox.Clear();
            admin_id_txtbox.Focus();
        }
    }
}
