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
        string username, studentID, password, vehicle_number;
        static string myconnstring = "Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=StudentDash;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(myconnstring);

        
        public profile_panel(string studentID, string password, string vehicle_number)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.password = password;
            this.vehicle_number = vehicle_number;

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

            if(vehicle_number == "")
            {
                ride_shared_lbl.Visible = false ;
                shared_count_lbl.Visible = false ;
            }
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

        private void change_password_btn_Click(object sender, EventArgs e)
        {
            string old_password = old_password_txtbox.Text;
            string new_password = new_password_txtbox.Text;
            bool success = false;
            try
            {
                string query = "UPDATE Users SET Password = @new_password WHERE Password = @old_password";
                //SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@new_password", new_password);
                command.Parameters.AddWithValue("@old_password", old_password);
                conn.Open();
                //MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int rows = command.ExecuteNonQuery();
                //MessageBox.Show(rows.ToString());
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

                if (success)
                {
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password changing failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void number_update_btn_Click(object sender, EventArgs e)
        {
            string old_number = old_number_txtbox.Text;
            string new_number = new_number_txtbox.Text;
            bool success = false;
            try
            {
                string query = "UPDATE Users SET Vehicle_Number = @new_number WHERE Vehicle_Number = @old_number";
                //SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@new_number", new_number);
                command.Parameters.AddWithValue("@old_number", old_number);
                conn.Open();
                //MessageBox.Show("Vehicle number changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int rows = command.ExecuteNonQuery();
                //MessageBox.Show(rows.ToString());
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

                if (success)
                {
                    MessageBox.Show("Vehicle number changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vehicle number changing failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
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
