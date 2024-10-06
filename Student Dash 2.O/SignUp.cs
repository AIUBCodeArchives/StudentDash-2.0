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
    public partial class SignUp : Form
    {
        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";

        public SignUp()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Visible = true;
            this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Visible = true;
            this.Close();
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {

                   if (St_Name.Text != "" && Student_ID.Text != "" && Password.Text != "")
            {
                String Vehinumber = VehiNum.Text;
                if(Vehinumber == "")
                {
                    Vehinumber = "No Vehicle";
                }
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    try
                    {
                        //Check for duplicate studentid
                        using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM User_Data WHERE Student_Id = @Student_Id", con))
                        {
                            checkCmd.Parameters.AddWithValue("@Student_Id", Student_ID.Text);
                            int userExists = (int)checkCmd.ExecuteScalar();

                            if (userExists > 0)
                            {
                                // Step 2: Handle the duplicate case
                                MessageBox.Show("This Student ID already exists. Please use a different one.");
                                return; // Stop further execution if duplicate found
                            }
                        }

                        //for adding values code start from here
                        using (SqlCommand cmd = new SqlCommand("Insert into User_Data (Student_Name,Student_Id,Password,Vehicle_Number,Ride_Booked,Ride_Shared,Reports)" +
                            "VALUES(@Student_Name, @Student_Id, @Password, @Vehicle_Number, @Ride_Booked, @Ride_Shared, @Reports)", con))
                        {
                            cmd.Parameters.AddWithValue("@Student_Name", St_Name.Text);
                            cmd.Parameters.AddWithValue("@Student_Id", Student_ID.Text);
                            cmd.Parameters.AddWithValue("@Password", Password.Text);
                            cmd.Parameters.AddWithValue("@Vehicle_Number", Vehinumber);
                            cmd.Parameters.AddWithValue("@Ride_Booked", 0);
                            cmd.Parameters.AddWithValue("@Ride_Shared", 0);
                            cmd.Parameters.AddWithValue("@Reports", 0);

                            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the insert command

                            // Optionally check if the insert was successful
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User registered successfully!");
                            }
                            else
                            {
                                MessageBox.Show("No rows affected, please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message); // Handle the error
                    }
                } // SqlConnection will be closed automatically due to the using statement
            }
            else
            {
                MessageBox.Show("Fill the mandatory fields");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
