using StudentDash_2._0.Db;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentDash_2._0.Forms
{
    public partial class admin_home_page : Form
    {
        public admin_home_page()
        {
            InitializeComponent();
        }
        string admin_id, password;
        public admin_home_page(string admin_id, string password)
        {
            InitializeComponent();
            this.admin_id = admin_id;
            this.password = password;

            admin_id_lbl.Text = admin_id;
            if (admin_id == "23-50071-1") 
            {
                //admin_logo.Image = "458189964_2039492059803419_5798020217839565781_n.jpg";
                admin_name_lbl.Text = $"Welcome, Chief.";
            }
            else if(admin_id == "23-50066-1")
            {
                admin_name_lbl.Text = $"Welcome, Shipak.";
            }
            else if (admin_id == "23-50233-1")
            {
                admin_name_lbl.Text = $"Welcome, Diet.";
            }
            else if (admin_id == "23-50213-1")
            {
                admin_name_lbl.Text = $"Welcome, Doc.";
            }

        }

        private void search_btn_MouseHover(object sender, EventArgs e)
        {
            search_btn.ForeColor = Color.Black;
        }

        private void search_btn_MouseLeave(object sender, EventArgs e)
        {
            search_btn.ForeColor = Color.White;
        }

        private void block_btn_MouseHover(object sender, EventArgs e)
        {
            block_btn.ForeColor = Color.Black;
        }

        private void block_btn_MouseLeave(object sender, EventArgs e)
        {
            block_btn.ForeColor = Color.White;
        }

        private void signout_btn_MouseHover(object sender, EventArgs e)
        {
            signout_btn.ForeColor = Color.Black;
        }

        private void signout_btn_MouseLeave(object sender, EventArgs e)
        {
            signout_btn.ForeColor = Color.White;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            admin_login_page ahp = new admin_login_page();
            ahp.Show();
            this.Visible = false;
        }
        static string myconnstring = "Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=StudentDash;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(myconnstring);
        string report_description;
        string vehicle_number;
        private void search_btn_Click(object sender, EventArgs e)
        {
            string student_id = search_student_txtbox.Text;


            try
            {
                string query = "SELECT * FROM Riders WHERE Rider_Student_ID LIKE '%" + search_student_txtbox.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommand command = new SqlCommand(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Process the result, convert to string
                        vehicle_number = result.ToString();
                    }
                    //form to load 
                    //dataGridView1.DataSource = dtable;
                }
                else
                {
                    MessageBox.Show("Destination not found. \nplease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    search_student_txtbox.Clear();

                    //focus
                    search_student_txtbox.Focus();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            try
            {
                string query = "SELECT Report_Description FROM Riders WHERE Rider_Student_ID LIKE '%" + search_student_txtbox.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommand command = new SqlCommand(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    // Process the result, e.g., convert to string
                    report_description = result.ToString();
                    // Now you have cellData and can use it as needed
                }
                else
                {
                    MessageBox.Show("Rider not found. \nplease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    search_student_txtbox.Clear();

                    //focus
                    search_student_txtbox.Focus();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            username_lbl.Text = $"Hi, {student_id}";
            description_lbl.Text = report_description;
            vehicle_number_value_lbl.Text = vehicle_number;

        }
        Reports r = new Reports();
        riders riders = new riders();
        private void admin_home_page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = r.Select();
            dataGridView1.DataSource = dataTable;
            DataTable dataTable2 = riders.Select();
            dataGridView2.DataSource = dataTable2;
        }

        private void block_btn_Click(object sender, EventArgs e)
        {
            string student_id = search_student_txtbox.Text;
            riders.Rider_Student_ID = student_id;
            riders.Delete(riders);

            DataTable dataTable2 = riders.Select();
            dataGridView2.DataSource = dataTable2;
        }

        private void signout_btn_Click(object sender, EventArgs e)
        {
            admin_login_page ahp = new admin_login_page();
            ahp.Show();
            this.Visible = false;
        }
    }
}
