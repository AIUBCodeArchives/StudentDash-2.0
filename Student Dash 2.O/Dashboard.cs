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

namespace Student_Dash_2.O
{
    public partial class Dashboard : Form
    {
        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void book_button_Click(object sender, EventArgs e)
        {
            BookRide bookRide = new BookRide();
            bookRide.Visible = true;
            this.Close();
        }

        private void share_button_Click(object sender, EventArgs e)
        {
            ShareRide shareRide = new ShareRide();  
            shareRide.Visible = true;   
            this.Close();
        }

        private void contact_button_Click(object sender, EventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.Visible = true;
            this.Close();
        }

        private void signout_button_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Visible = true;
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            string vehi = "No Vehicle";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("Select *from User_Data where Student_Id = '" + user_Login.get_stid() + "' and Vehicle_Number = '"+vehi+"' ", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        share_button.Enabled = false;
                    }
                    else
                    {
                        share_button.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message); // Handle the error
                }
                finally
                {
                    con.Close();

                }
            }
                using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT Student_Name,Ride_Booked,Ride_Shared,Reports,Income FROM User_Data WHERE Student_Id = @StId", con))
                    {
                        cmd.Parameters.AddWithValue("@StId", user_Login.get_stid()); // Assuming get_userid is a method
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there's a result
                            {
                                string name = reader["Student_Name"].ToString(); // Display the retrieved name
                                username_label.Text = name.ToUpper();
                                book_label.Text = reader["Ride_Booked"].ToString(); // Display the retrieved Booked rides
                                share_label.Text = reader["Ride_Shared"].ToString(); // Display the retrieved Shared rides
                                report_label.Text = reader["Reports"].ToString(); // Display the retrieved Shared rides
                                income.Text = reader["Income"].ToString()+" Taka"; // Display the retrieved Shared rides
                            }
                            else
                            {
                                guna2HtmlLabel1.Text = "User not found"; // Handle case where no matching user is found
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message); // Handle the error
                }
            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changepass_button_Click(object sender, EventArgs e)
        {

            // Get the current and new passwords from the UI (TextBoxes)
            string oldPassword = old_pass.Text;
            string newPassword = new_pass.Text;

            // Assuming user_Login_Form.get_stid() gets the currently logged-in user ID
            User_Login user_Login_Form = new User_Login();
            string userId = user_Login_Form.get_stid();

            // Check if the new password and confirmation match
            if (newPassword == "")
            {
                MessageBox.Show("New password can't be empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                try
                {
                    // Step 1: Check if the old password is correct
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT Password FROM User_Data WHERE Student_Id = @Student_Id", con))
                    {
                        checkCmd.Parameters.AddWithValue("@Student_Id", userId);

                        string currentPasswordInDB = checkCmd.ExecuteScalar()?.ToString();

                        if (currentPasswordInDB != oldPassword)
                        {
                            // Old password doesn't match
                            MessageBox.Show("The old password is incorrect.");
                            return;
                        }
                    }

                    // Step 2: Update the password with the new one
                    using (SqlCommand updateCmd = new SqlCommand(
                        "UPDATE User_Data SET Password = @NewPassword WHERE Student_Id = @Student_Id", con))
                    {
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@Student_Id", userId);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully! New Password : "+newPassword);
                        }
                        else
                        {
                            MessageBox.Show("Password change failed. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void updatevehi_button_Click(object sender, EventArgs e)
        {

            // Get the current and new passwords from the UI (TextBoxes)
            string newnumber = new_vehinum.Text;
            string connumber = con_vehinum.Text;

            // Assuming user_Login_Form.get_stid() gets the currently logged-in user ID
            User_Login user_Login_Form = new User_Login();
            string userId = user_Login_Form.get_stid();

            // Check if the new password and confirmation match
            if (newnumber == "" || connumber=="")
            {
                MessageBox.Show("Number can't be empty.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                try
                {
                    // Step 1: Check if the old password is correct
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT Vehicle_Number FROM User_Data WHERE Student_Id = @Student_Id", con))
                    {
                        checkCmd.Parameters.AddWithValue("@Student_Id", userId);

                        string currentPasswordInDB = checkCmd.ExecuteScalar()?.ToString();

                        if (newnumber != connumber)
                        {
                            // Old password doesn't match
                            MessageBox.Show("Vehicle Numbers Dosen't Match.");
                            return;
                        }
                    }

                    // Step 2: Update the password with the new one
                    using (SqlCommand updateCmd = new SqlCommand(
                        "UPDATE User_Data SET Vehicle_Number = @newnumber WHERE Student_Id = @Student_Id", con))
                    {
                        updateCmd.Parameters.AddWithValue("@newnumber", newnumber);
                        updateCmd.Parameters.AddWithValue("@Student_Id", userId);

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Number changed successfully! New Number : " + newnumber);
                            Dashboard dashboard = new Dashboard();
                            dashboard.Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Number change failed. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
    }
}
