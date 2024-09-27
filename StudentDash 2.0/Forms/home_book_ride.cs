using Guna.UI2.WinForms;
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
    public partial class home_book_ride : Form
    {
        public home_book_ride()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_btn_MouseHover(object sender, EventArgs e)
        {
            search_btn.ForeColor = Color.Black;
        }

        private void search_btn_MouseLeave(object sender, EventArgs e)
        {

            search_btn.ForeColor = Color.White;
        }

        private void book_btn_MouseHover(object sender, EventArgs e)
        {
            book_btn.ForeColor = Color.Black;
        }

        private void book_btn_MouseLeave(object sender, EventArgs e)
        {

            book_btn.ForeColor = Color.White;
        }

        private void clear_all_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            search_destination_txtbox.Clear();
            rider_id_txtbox.Clear();
            search_destination_txtbox.Focus();
        }
        riders r = new riders();
        private void home_book_ride_Load(object sender, EventArgs e)
        {
            DataTable dataTable = r.Select();
            dataGridView1.DataSource = dataTable;
            //dataGridView1.Visible = true;
        }
        static string myconnstring = "Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=StudentDash;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(myconnstring);
        
        private void search_btn_Click(object sender, EventArgs e)
        {
            String destination = search_destination_txtbox.Text;

            try
            {
                string query = "SELECT * FROM Riders WHERE Destination LIKE '%" + search_destination_txtbox.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    destination = search_destination_txtbox.Text;

                    //form to load 
                    dataGridView1.DataSource = dtable;
                }
                else
                {
                    MessageBox.Show("Destination not found. \nplease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    search_destination_txtbox.Clear();

                    //focus
                    search_destination_txtbox.Focus();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
