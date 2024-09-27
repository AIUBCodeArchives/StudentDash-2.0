using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDash_2._0.Forms
{
    public partial class profile_panel : Form
    {
        public profile_panel()
        {
            InitializeComponent();
        }
        string username, studentID, password;
        static string myconnstring = "Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=StudentDash;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(myconnstring);

        
        public profile_panel(string studentID, string password)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.password = password;

            try
            {
                string query = $"SELECT Name FROM Users WHERE studentID = @studentID";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@studentID", studentID);
                conn.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    // Process the result, e.g., convert to string
                    username = result.ToString();
                    // Now you have cellData and can use it as needed
                }
            }
            catch (Exception ex) 
            { 
            
            }
            finally
            {
                conn.Close();
            }
            username_lbl.Text = $"Hi, {username.ToUpper()}";
            student_id_lbl.Text = studentID;
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void change_password_btn_MouseHover(object sender, EventArgs e)
        {
            change_password_btn.ForeColor = Color.Black;
        }

        private void change_password_btn_MouseLeave(object sender, EventArgs e)
        {
            change_password_btn.ForeColor = Color.White;
        }

        private void number_update_btn_MouseHover(object sender, EventArgs e)
        {
            number_update_btn.ForeColor = Color.Black;
        }

        private void number_update_btn_MouseLeave(object sender, EventArgs e)
        {
            number_update_btn.ForeColor = Color.White;
        }
    }
}
