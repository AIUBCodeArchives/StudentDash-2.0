using StudentDash_2._0.Db;
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

        private void clear_all_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();
        }
        public void clear()
        {
            name_txtbox.Clear();
            student_id_txtbox.Clear();
            password_txtbox.Clear();
            confirm_password_txtbox.Clear();
            vehicle_number_txtbox.Clear();
            name_txtbox.Focus();
        }
        users u = new users();

        private void signup_btn_Click(object sender, EventArgs e)
        {
            //Get Values form the box
            u.Name = name_txtbox.Text;
            u.StudentID = student_id_txtbox.Text;
            u.Password = password_txtbox.Text;
            u.Confirm_password = confirm_password_txtbox.Text;
            u.Vehicle_Number = vehicle_number_txtbox.Text;

            if (u.Name == "" || u.StudentID == "" || u.Password == "" || u.Confirm_password == "")
            {
                MessageBox.Show("Please fill all mandatory fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = u.Insert(u);
                if (success == true)
                {
                    MessageBox.Show($"{u.Name} as an user added successfully.");
                    clear();
                    name_txtbox.Focus();
                }
                else
                {
                    MessageBox.Show("User adding failed. Please try again");
                }
            }
            //load data in Data grid view
            DataTable dataTable = u.Select();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Visible = true;
        }
    }
}
