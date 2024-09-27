using StudentDash_2._0.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDash_2._0.Forms
{
    public partial class home_share_ride : Form
    {
        public home_share_ride()
        {
            InitializeComponent();
        }
        string username, studentID, password, vehicle_number;
        public home_share_ride(string studentID, string password, string vehicle_number)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.password = password;
            this.vehicle_number = vehicle_number;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_ride_btn_MouseHover(object sender, EventArgs e)
        {
            add_ride_btn.ForeColor = Color.Black;
        }

        private void add_ride_btn_MouseLeave(object sender, EventArgs e)
        {
            add_ride_btn.ForeColor = Color.White;
        }

        private void clear_all_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clear();

        }
        public void clear()
        {
            current_location_txtbox.Clear();
            destination_txtbox.Clear();
            time_txtbox.Clear();
            yes_radio_btn.Checked = true;
            no_radio_btn.Checked = false;
            fare_ammount_txtbox.Clear();
            current_location_txtbox.Focus();
        }
        riders r = new riders();
        private void add_ride_btn_Click(object sender, EventArgs e)
        {
            r.Rider_Student_ID = this.studentID;
            r.Current_Location = current_location_txtbox.Text;
            r.Destination = destination_txtbox.Text;
            r.Time = time_txtbox.Text;
            if (yes_radio_btn.Checked == true)
            {
                r.Ride_Mode = yes_radio_btn.Text;
            }
            else
            {
                r.Ride_Mode = no_radio_btn.Text;
            }
            r.Fare_Ammount = fare_ammount_txtbox.Text;
            r.No_of_Seats = Convert.ToInt32(no_of_seats_txtbox.Text);
            r.Vehicle_Number = this.vehicle_number;

            if (r.Rider_Student_ID == "" || r.Current_Location == "" || r.Destination == "" || r.Time == "" || r.Ride_Mode == "" || r.Fare_Ammount == "" || r.No_of_Seats == '\0')
            {
                MessageBox.Show("Please fill all mandatory fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = r.Insert(r);
                if (success)
                {
                    MessageBox.Show($"Ride shared successfully.");
                    clear();
                    current_location_txtbox.Focus();
                }
                else
                {
                    MessageBox.Show("Ride sharing failed. Please try again");
                }
            }
            

        }
    }
}
