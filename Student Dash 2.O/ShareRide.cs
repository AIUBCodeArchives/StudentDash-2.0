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
    public partial class ShareRide : Form
    {
        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";
        User_Login User = new User_Login();
        public ShareRide()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void free_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void fare_TextChanged(object sender, EventArgs e)
        {

        }

        private void ridebook_button_Click(object sender, EventArgs e)
        {
            if ((paid.Checked || free.Checked) && add_destination.Text !="" && seat_num.Text != "" )
            {
                
                    string driverid = User.get_stid();
                    int fares = 0;
                    if (paid.Checked && fare.Text != "")
                    {
                        fares = int.Parse(fare.Text);
                    }
                    else if (free.Checked)
                    {
                        fares = 0;

                    }
                else
                {
                    MessageBox.Show("Enter Fare Amount");
                    return;

                }
                using (SqlConnection con = new SqlConnection(connectionstring))
                    {
                        con.Open();
                        try
                        {
                            // Example of an SQL command to insert the ride booking into the Shared_Rides table
                            using (SqlCommand cmd = new SqlCommand(
                                "INSERT INTO Ride_Detail (Rider_Id, Destination, Ride_Time, Fare, Seats, Available_Seats) " +
                                "VALUES (@Driver_Id, @Destination, @Ride_Time, @Fare_Amount, @Total_Seats, @Available_Seats)", con))
                            {
                                cmd.Parameters.AddWithValue("@Driver_Id", driverid);  // Assuming Driver_Id is input by the user
                                cmd.Parameters.AddWithValue("@Destination", add_destination.Text);  // Assuming destination is input by the user
                                cmd.Parameters.AddWithValue("@Ride_Time", time.Text);
                                cmd.Parameters.AddWithValue("@Fare_Amount", fares);  // Use the fare amount depending on ride type
                                cmd.Parameters.AddWithValue("@Total_Seats", int.Parse(seat_num.Text));  // Assuming total seats are input by the user
                                cmd.Parameters.AddWithValue("@Available_Seats", int.Parse(seat_num.Text));  // Assuming available seats are input by the user

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Ride shared successfully!");
                                    using (SqlCommand rideCmd = new SqlCommand("UPDATE User_Data SET Ride_Shared = Ride_Shared + 1 WHERE Student_Id = @Student_Id", con))
                                    {
                                        rideCmd.Parameters.AddWithValue("@Student_Id", User.get_stid());
                                        rideCmd.ExecuteNonQuery();


                                    }
                                    add_destination.Clear();
                                    seat_num.Clear();
                                    fare.Clear();
                                    paid.Checked = false;
                                    free.Checked = false;
                                }
                                else
                                {
                                    MessageBox.Show("Failed to share the ride. Please try again.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                
            }
            else
            {
                MessageBox.Show("Please fill all needed data");

            }
        }

        private void paidfree_Click(object sender, EventArgs e)
        {

        }

        private void signout_button_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Visible = true;
            this.Close();
        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void add_destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {

        }

        private void contact_button_Click(object sender, EventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.Visible = true;
            this.Close();
        }

        private void share_button_Click(object sender, EventArgs e)
        {

        }

        private void book_button_Click(object sender, EventArgs e)
        {
            BookRide bookRide = new BookRide();
            bookRide.Show();
            this.Close();
        }

        private void Dash_Button_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            free.Checked = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            paid.Checked = true;
        }

        private void ShareRide_Load(object sender, EventArgs e)
        {

        }
    }
}
