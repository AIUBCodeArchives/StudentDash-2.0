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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Dash_2.O
{
    public partial class User_Login : Form
    {
        private const string connectionstring = "Data Source=SIMSIM;Initial Catalog=\"Student Dash 2.O\";Integrated Security=True;Encrypt=False";
        private static string stid = "";
        public string get_stid()
        {

        return stid; }
        public User_Login()
        {
            InitializeComponent();
        }

        private void User_Login_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Checking checking = new Checking();
            checking.Visible = true;
            this.Close();
        }

        private void SignUp_Button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Visible = true;
            this.Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (Student_Id.Text != "" && Password.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    stid = Student_Id.Text;
                    con.Open();
                    try
                    {

                        SqlCommand cmd = new SqlCommand("Select *from User_Data where Student_Id = '" + stid + "' and Password = '" + Password.Text + "'", con);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.Visible = false;
                            Dashboard dash = new Dashboard();
                            dash.Visible = true;
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

        private void Forgot_Button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Pass forgot_Pass = new Forgot_Pass();
            forgot_Pass.Visible = true;
            this.Visible = false;
        }
    }
}
