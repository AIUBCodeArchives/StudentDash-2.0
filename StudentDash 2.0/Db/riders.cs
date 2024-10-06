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
        //Update the data in database
        public bool Update(riders t)
        {
            // create a default bool
            bool success = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //step2 - writing SQL query to insert
                string sql = "UPDATE Riders SET Rider_Student_ID = @Rider_Student_ID, Current_Location = @Current_Location, Destination = @Destination, Time = @Time, Paid_Ride = @Paid_Ride, Fare_Ammount = @Fare_Ammount, No_of_Seats = @No_of_Seats, Vehicle_Number = @Vehicle_Number WHERE RideID = @RiderID";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data
                cmd.Parameters.AddWithValue("@Rider_Student_ID", t.Rider_Student_ID);
                cmd.Parameters.AddWithValue("@Current_Location", t.Current_Location);
                cmd.Parameters.AddWithValue("@Destination", t.Destination);
                cmd.Parameters.AddWithValue("@Time", t.Time);
                cmd.Parameters.AddWithValue("@Paid_Ride", t.Ride_Mode);
                cmd.Parameters.AddWithValue("@Fare_Ammount", t.Fare_Ammount);
                cmd.Parameters.AddWithValue("@No_of_Seats", t.No_of_Seats);
                cmd.Parameters.AddWithValue("@Vehicle_Number", t.Vehicle_Number);

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
        //Method to Delete data in database in our Application
        public bool Delete(riders t)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //step 1 - Connect Database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL to delete data in our Database
                string sql = "DELETE FROM Riders WHERE RideID = @RideID";
                //Creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RideID", t.RiderID);

                //Connection Open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                //close Connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
