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
   
    public partial class AdminHome : Form
    {
        AdminLogin admin = new AdminLogin();

        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";

        public AdminHome()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            Adminid_Label.Text = admin.get_admin_id();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM User_Data", con))
                    {
                        // ExecuteScalar is used to get the result of the count
                        int totalUsers = Convert.ToInt32(cmd.ExecuteScalar());
                        total_user.Text = totalUsers.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message); // Handle the error

                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {

        }

        private void signout_button_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Visible = true;
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string Stid = stid.Text;
            if (string.IsNullOrEmpty(Stid))
            {
                MessageBox.Show("Enter Valid StudentId");
                return;
            }
            else {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT Student_Name,Ride_Booked,Ride_Shared,Reports,Vehicle_Number FROM User_Data WHERE Student_Id = @StId", con))
                        {
                            cmd.Parameters.AddWithValue("@StId", Stid); // Assuming get_userid is a method
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // Check if there's a result
                                {
                                    string nam = reader["Student_Name"].ToString(); // Display the retrieved name
                                    username.Text = nam.ToUpper();
                                    ride_booked.Text = reader["Ride_Booked"].ToString(); // Display the retrieved Booked rides
                                    ride_shared.Text = reader["Ride_Shared"].ToString(); // Display the retrieved Shared rides
                                    report_label.Text = reader["Reports"].ToString(); // Display the retrieved Shared rides
                                    vehi_num.Text = reader["Vehicle_Number"].ToString(); // Display the retrieved Shared rides
                                }
                                else
                                {
                                    MessageBox.Show("No user found with the given Student ID.");
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
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // Assuming that Student_Id is obtained from a textbox (or another UI element)
            string studentId = stid.Text;

            // Check if the user has entered a valid Student_Id
            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            // Optional: Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    try
                    {
                        // SQL query to delete a user based on Student_Id
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM User_Data WHERE Student_Id = @Student_Id", con))
                        {
                            cmd.Parameters.AddWithValue("@Student_Id", studentId);

                            // Execute the delete command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No user found with the given Student ID.");
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

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}
