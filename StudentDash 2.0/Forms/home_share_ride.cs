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
            current_location_txtbox.Clear();
            destination_txtbox.Clear();
            time_txtbox.Clear();
            yes_radio_btn.Checked = true;
            no_radio_btn.Checked = false;
            fare_ammount_txtbox.Clear();
            current_location_txtbox.Focus();

        }
    }
}
