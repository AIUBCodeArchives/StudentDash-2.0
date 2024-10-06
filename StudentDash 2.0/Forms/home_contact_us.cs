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

namespace StudentDash_2._0.Forms
{
    public partial class home_contact_us : Form
    {
        public home_contact_us()
        {
            InitializeComponent();
        }
        
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Report_btn_MouseHover(object sender, EventArgs e)
        {
            Report_btn.ForeColor = Color.Black;
        }

        private void Report_btn_MouseLeave(object sender, EventArgs e)
        {
            Report_btn.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Reports r = new Reports();
        static string myconnstring = "Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=StudentDash;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(myconnstring);
        private void Report_btn_Click(object sender, EventArgs e)
        {
            r.Rider_Student_ID = rider_id_txtbox.Text;
            r.Report_Description = description_txtbox.Text;
            //try
            //{
            //    string query = $"SELECT Report_Count FROM Reports WHERE Rider_Student_ID = @Rider_Student_ID";
            //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            //    SqlCommand command = new SqlCommand(query, conn);
            //    command.Parameters.AddWithValue("@Rider_Student_ID", rider_id_txtbox.Text);
            //    conn.Open();
            //    //DataTable dataTable = new DataTable();
            //    //sda.Fill(dataTable);
            //    object result = command.ExecuteScalar();
            //    if (result != null)
            //    {
            //        // Process the result, e.g., convert to string
            //        r.Report_Count = Convert.ToInt32(result);
            //        r.Report_Count++;
            //        // Now you have cellData and can use it as needed
            //    }
            //    r.Update(r);
            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
            //    conn.Close();
            //}
            //try
            //{
            //    string query = $"SELECT Vehicle_Number FROM Users WHERE Student_ID = @Student_ID";
            //    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            //    SqlCommand command = new SqlCommand(query, conn);
            //    command.Parameters.AddWithValue("@Rider_Student_ID", rider_id_txtbox.Text);
            //    conn.Open();
            //    object result = command.ExecuteScalar();
            //    if (result != null)
            //    {
            //        // Process the result, e.g., convert to string
            //        Vehicle_Number = result.ToString();
            //        // Now you have cellData and can use it as needed
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
            //    conn.Close();
            //}
            if (r.Rider_Student_ID == "")
            {
                MessageBox.Show("Rider ID can not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = r.Insert(r);
                if (success == true)
                {
                    MessageBox.Show($"Report against ID {r.Rider_Student_ID} sent successfully.");
                    rider_id_txtbox.Clear();
                    description_txtbox.Clear();
                    rider_id_txtbox.Focus();
                }
                else
                {
                    MessageBox.Show("Report sending failed. Please try again");
                }
            }
            //load data in Data grid view
            //DataTable dataTable = u.Select();
            //dataGridView1.DataSource = dataTable;


        }
    }
}
