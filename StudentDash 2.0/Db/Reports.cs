using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDash_2._0.Db
{
    internal class Reports
    {
        public int RiderID { get; set; }
        public string Rider_Student_ID { get; set; }
        public string Report_Description { get; set; }
        public int Report_Count { get; set; }
        

        static string myconnstring = "Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=StudentDash;Integrated Security=True;TrustServerCertificate=True";

        public DataTable Select()
        {
            //step 1 Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //step2 - writing SQL query
                string sql = "SELECT * FROM Reports";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating SQL DataAdapter???? using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //insert 
        public bool Insert(Reports t)
        {
            //creating a default type and setting it to false
            bool success = false;
            //1, connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //step2 - writing SQL query to insert
                string sql = "INSERT INTO Reports (Rider_Student_ID, Report_Description) VALUES(@Rider_Student_ID, @Report_Description)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Rider_Student_ID", t.Rider_Student_ID);
                cmd.Parameters.AddWithValue("@Report_Description", t.Report_Description);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        public bool Update(Reports t)
        {
            // create a default bool
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //step2 - writing SQL query to insert
                string sql = "UPDATE Reports SET Rider_Student_ID = @Rider_Student_ID, Report_Description = @Report_Description";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data
                cmd.Parameters.AddWithValue("@Rider_Student_ID", t.Rider_Student_ID);
                cmd.Parameters.AddWithValue("@Report_Description", t.Report_Description);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //MessageBox.Show(rows.ToString());
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
    }
}
