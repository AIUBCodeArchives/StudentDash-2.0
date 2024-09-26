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
    public partial class admin_home_page : Form
    {
        public admin_home_page()
        {
            InitializeComponent();
        }

        private void search_btn_MouseHover(object sender, EventArgs e)
        {
            search_btn.ForeColor = Color.Black;
        }

        private void search_btn_MouseLeave(object sender, EventArgs e)
        {
            search_btn.ForeColor = Color.White;
        }

        private void block_btn_MouseHover(object sender, EventArgs e)
        {
            block_btn.ForeColor = Color.Black;
        }

        private void block_btn_MouseLeave(object sender, EventArgs e)
        {
            block_btn.ForeColor = Color.White;
        }

        private void signout_btn_MouseHover(object sender, EventArgs e)
        {
            signout_btn.ForeColor = Color.Black;
        }

        private void signout_btn_MouseLeave(object sender, EventArgs e)
        {
            signout_btn.ForeColor = Color.White;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            admin_login_page ahp = new admin_login_page();
            ahp.Show();
            this.Visible = false;
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            admin_login_page ahp = new admin_login_page();
            ahp.Show();
            this.Visible = false;
        }
    }
}
