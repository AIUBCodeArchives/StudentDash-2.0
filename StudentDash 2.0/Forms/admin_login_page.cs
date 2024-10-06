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
            string admin_id = admin_id_txtbox.Text;
            string password = password_txtbox.Text;

            if ((admin_id == "23-50071-1" && password == "rakin") || (admin_id == "23-50066-1" && password == "avoy") || (admin_id == "23-50233-1" && password == "dipo") || (admin_id == "23-50213-1" && password == "muntasir"))
            {
                admin_home_page ahp = new admin_home_page(admin_id, password);
                ahp.Show();
                this.Visible = false;
            }
            else if (admin_id == "" || password == "")
            {
                MessageBox.Show("Admin ID or Password field can not be empty. \nplease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                admin_id_txtbox.Clear();
                password_txtbox.Clear();

                //focus
                admin_id_txtbox.Focus();
            }
            else
            {
                MessageBox.Show("Invalid Admin ID or Password. \nplease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                admin_id_txtbox.Clear();
                password_txtbox.Clear();

                //focus
                admin_id_txtbox.Focus();
            }
            
        }

        private void clear_all_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            admin_id_txtbox.Clear();
            password_txtbox.Clear();
            admin_id_txtbox.Focus();
        }
    }
}
