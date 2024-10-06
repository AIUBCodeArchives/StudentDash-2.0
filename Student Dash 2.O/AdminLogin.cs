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
    public partial class AdminLogin : Form
    {
        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";

        private static string admin_id="";
            public string get_admin_id()
        {
            return admin_id;
        }
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Checking checking = new Checking();
            checking.Visible = true;
            this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            /*
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Insert into Admin_Data (Admin_ID,Admin_Pass)" +
                                "VALUES(@Admin_Id, @Admin_Pass)", con))
                {
                    cmd.Parameters.AddWithValue("@Admin_Id", Admin_Id.Text);
                    cmd.Parameters.AddWithValue("@Admin_Pass", Admin_Pass.Text);


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
            */

            if (Admin_Id.Text != "" && Admin_Pass.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    admin_id = Admin_Id.Text;
                    con.Open();
                    try
                    {

                        SqlCommand cmd = new SqlCommand("Select *from Admin_Data where Admin_ID = '" + admin_id + "' and Admin_Pass = '" + Admin_Pass.Text + "'", con);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            AdminHome home = new AdminHome();
                            home.Visible = true;
                            this.Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
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

        private void SignUp_Button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Who Made You Admin??");
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
