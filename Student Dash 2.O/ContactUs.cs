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
    public partial class ContactUs : Form
    {
        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";

        public ContactUs()
        {
            InitializeComponent();
        }

        private void ContactUs_Load(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            string vehi = "No Vehicle";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                try
                {

                    SqlCommand cmd = new SqlCommand("Select *from User_Data where Student_Id = '" + user_Login.get_stid() + "' and Vehicle_Number = '" + vehi + "' ", con);
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
        }

        private void add_destination_TextChanged(object sender, EventArgs e)
        {
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signout_button_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Visible = true;
            this.Close();
        }

        private void Dash_Button_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            BookRide bookRide = new BookRide();
            bookRide.Show();
            this.Close();
        }

        private void share_button_Click(object sender, EventArgs e)
        {
            ShareRide shareRide = new ShareRide();  
            shareRide.Show();
            this.Close();
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            User_Login user = new User_Login();
            // Assuming you are working with the current user and their Student_Id
            string studentId = reportid.Text;  // Reported user's ID
            string reporterId = user.get_stid();  // Current user's ID (reporter)

            // Check if the Student_Id is valid
            if (string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }
            else if (studentId == reporterId)
            {
                MessageBox.Show("You cannot report yourself.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                try
                {
                    // Check if this user has already reported the given Student_Id
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM User_Reports WHERE Reporter_Id = @Reporter_Id AND Reported_Id = @Reported_Id", con))
                    {
                        checkCmd.Parameters.AddWithValue("@Reporter_Id", reporterId);
                        checkCmd.Parameters.AddWithValue("@Reported_Id", studentId);

                        int reportExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (reportExists > 0)
                        {
                            MessageBox.Show("You have already reported this user.");
                            return;
                        }
                    }

                    // If no previous report, proceed with reporting
                    using (SqlCommand reportCmd = new SqlCommand(
                        "UPDATE User_Data SET Reports = Reports + 1 WHERE Student_Id = @Student_Id", con))
                    {
                        reportCmd.Parameters.AddWithValue("@Student_Id", studentId);

                        int rowsAffected = reportCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Insert into User_Reports to log this report
                            using (SqlCommand logCmd = new SqlCommand(
                                "INSERT INTO User_Reports (Reporter_Id, Reported_Id) VALUES (@Reporter_Id, @Reported_Id)", con))
                            {
                                logCmd.Parameters.AddWithValue("@Reporter_Id", reporterId);
                                logCmd.Parameters.AddWithValue("@Reported_Id", studentId);

                                logCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Report submitted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No user found with the given Student ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the process
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
