using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
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
        static string myconnstring = "Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=StudentDash;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(myconnstring);
        private void login_btn_Click(object sender, EventArgs e)
        {
            String studentID = student_id_txtbox.Text;
            String password = password_txtbox.Text;

            try
            {
                string query = "SELECT * from Users WHERE StudentID = '"+ student_id_txtbox.Text + "' AND Password = '"+ password_txtbox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    studentID = student_id_txtbox.Text;
                    password = password_txtbox.Text;

                    //form to load 
                    user_home_page uhp = new user_home_page(studentID, password);
                    uhp.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid StudentID or Password. \nplease try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    student_id_txtbox.Clear();
                    password_txtbox.Clear();

                    //focus
                    student_id_txtbox.Focus();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            
        }

        private void show_password_btn_Click(object sender, EventArgs e)
        {
            password_txtbox.PasswordChar = '\0';
        }
    }
}
