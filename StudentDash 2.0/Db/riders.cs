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
    internal class riders
    {
        //getter setter properties
        //acts as Data Carrier in Our application

        public int RiderID { get; set; }
        public string Rider_Student_ID { get; set; }
        public string Current_Location { get; set; }
        public string Destination { get; set; }
        public string Time { get; set; }
        public string Ride_Mode { get; set; }
        public string Fare_Ammount { get; set; }
        public int No_of_Seats { get; set; }
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
                string sql = "SELECT * FROM Riders";
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
        public bool Insert(riders t)
        {
            //creating a default type and setting it to false
            bool success = false;
            //1, connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //step2 - writing SQL query to insert
                string sql = "INSERT INTO Riders (Rider_Student_ID, Current_Location, Destination, Time, Paid_Ride, Fare_Ammount, No_of_Seats, Vehicle_Number) VALUES(@Rider_Student_ID, @Current_Location, @Destination, @Time, @Ride_Mode, @Fare_Ammount, @No_of_Seats, @Vehicle_number)";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Rider_Student_ID", t.Rider_Student_ID);
                cmd.Parameters.AddWithValue("@Current_Location", t.Current_Location);
                cmd.Parameters.AddWithValue("@Destination", t.Destination);
                cmd.Parameters.AddWithValue("@Time", t.Time);
                cmd.Parameters.AddWithValue("@Ride_Mode", t.Ride_Mode);
                cmd.Parameters.AddWithValue("@Fare_Ammount", t.Fare_Ammount);
                cmd.Parameters.AddWithValue("@No_of_Seats", t.No_of_Seats);
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
