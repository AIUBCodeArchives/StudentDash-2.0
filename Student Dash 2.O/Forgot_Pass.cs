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
    public partial class Forgot_Pass : Form
    {
        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";

        public Forgot_Pass()
        {
            InitializeComponent();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            if (stid.Text != "" && ridenum.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    try
                    {

                        SqlCommand cmd = new SqlCommand("Select *from User_Data where Student_ID = '" + stid.Text + "' and Ride_Booked = '" + ridenum.Text + "'", con);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // Check if there's a result
                                {
                                    string Pass = reader["Password"].ToString();
                                    string newpass = "";
                                    for(int i= 0;i<Pass.Length-2; i++)
                                    {
                                        newpass += Pass[i];
                                    }
                                    MessageBox.Show("Your Password without lasst 2 charecter : ( "+newpass+" )");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Matching Data");
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
            else
            {
                MessageBox.Show("Fill All The Fields"); // Handle the error

            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Visible = true;
            this.Close();
        }
    }
}
