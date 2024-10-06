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
    public partial class BookRide : Form
    {
        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";
        User_Login User_Login = new User_Login();
        static int fare = 0;
        public BookRide()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Dash_Button_Click(object sender, EventArgs e)
        {
            Dashboard   dashboard = new Dashboard();
            dashboard.Visible = true;
            this.Close();
        }

        private void signout_button_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Visible = true;
            this.Close();
        }

        private void contact_button_Click(object sender, EventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.Visible = true;
            this.Close();
        }

        private void share_button_Click(object sender, EventArgs e)
        {
            ShareRide shareRide = new ShareRide();  
            shareRide.Visible = true;
            this.Close();
        }

        private void book_button_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void search_destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();

                try
                {
                    using (SqlCommand comma = new SqlCommand("Select DISTINCT Rider_Id, Ride_Time, Available_Seats, Fare From Ride_Detail where Destination = @Destination", con))
                    {
                        // Add the parameter value for the query
                        comma.Parameters.AddWithValue("@Destination", search_destination.Text);

                        // Use SqlDataAdapter to fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comma))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind the DataTable to the DataGridView
                            Rider_Details.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void ridebook_button_Click(object sender, EventArgs e)
        {
            if (User_Login.get_stid() != rider_id.Text)
            {

                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();

                    using (SqlTransaction transaction = con.BeginTransaction()) // Start a transaction
                    {
                        try
                        {
                            string rideId = rider_id.Text;
                            // Decrease available seats for the selected ride

                            // Step 1: Decrement the available seats
                            using (SqlCommand updateCmd = new SqlCommand(
                                "UPDATE Ride_Detail SET Available_Seats = Available_Seats - 1  WHERE Rider_Id = @RideId AND Destination = @Destination and Available_Seats > 0", con, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@RideId", rideId);
                                updateCmd.Parameters.AddWithValue("@Destination", search_destination.Text);
                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                // Check if the available seats were successfully updated
                                if (rowsAffected > 0)
                                {
                                    // Step 2: Check if the available seats are 0 and delete the ride if so
                                    using (SqlCommand deleteCmd = new SqlCommand(
                                        "DELETE FROM Ride_Detail WHERE Rider_Id = @RideId AND Available_Seats = 0", con, transaction))
                                    {
                                        deleteCmd.Parameters.AddWithValue("@RideId", rideId);
                                        deleteCmd.ExecuteNonQuery(); // This will delete the ride if seats become 0
                                    }

                                    // Commit the transaction if everything is successful
                                    transaction.Commit();
                                    MessageBox.Show("Ride booked successfully!");
                                    
                                        using (SqlCommand rideCmd = new SqlCommand("UPDATE User_Data SET Ride_Booked = Ride_Booked + 1 , Income = (Income + @Fare) WHERE Student_Id = @Student_Id", con))
                                        {
                                            rideCmd.Parameters.AddWithValue("@Student_Id", User_Login.get_stid());
                                            rideCmd.Parameters.AddWithValue("Fare", fare);
                                            rideCmd.ExecuteNonQuery();


                                        }
                                    
                                    search_button_Click(sender, e);
                                    search_destination.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong Rider Id.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Roll back the transaction if an error occurs
                            transaction.Rollback();
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You Can't Book Your Own RIde.");

            }
        }


        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rider_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {

        }

        private void BookRide_Load(object sender, EventArgs e)
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
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();

                try
                {
                    using (SqlCommand comma = new SqlCommand("Select DISTINCT Destination From Ride_Detail", con))
                    {

                        // Use SqlDataAdapter to fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(comma))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind the DataTable to the DataGridView
                            locationview.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void locationview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.locationview.Rows[e.RowIndex];

                search_destination.Text = row.Cells["Destination"].Value.ToString();
            }
        }

        private void Rider_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Rider_Details.Rows[e.RowIndex];

                rider_id.Text = row.Cells["Rider_Id"].Value.ToString();
                fare = (int) row.Cells["Fare"].Value;
            }
        }
    }
}
