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
    internal class users
    {
        //getter setter properties
        //acts as Data Carrier in Our application

        public int UserID { get; set; }
        public string Name { get; set; }
        public string StudentID { get; set; }
        public string Password { get; set; }
        public string Confirm_password { get; set; }
        public string Vehicle_Number { get; set; }

        static string myconnstring = "Data Source=RAIYEN-ZAYED-RA\\SQLEXPRESS;Initial Catalog=StudentDash;Integrated Security=True;TrustServerCertificate=True";

        public DataTable Select()
        {
            //step 1 Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //step2 - writing SQL query
                string sql = "SELECT * FROM Users";
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
        public bool Insert(users t)
        {
            //creating a default type and setting it to false
            bool success = false;
            //1, connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //step2 - writing SQL query to insert
                string sql = "INSERT INTO Users (Name,StudentID, Password, Vehicle_Number) VALUES(@Name,@StudentID, @Password, @Vehicle_Number)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", t.Name);
                cmd.Parameters.AddWithValue("@StudentID", t.StudentID);
                if(t.Password == t.Confirm_password)
                {
                    cmd.Parameters.AddWithValue("@Password", t.Password);
                }
                cmd.Parameters.AddWithValue("@Vehicle_Number", t.Vehicle_Number);

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
    }
}
