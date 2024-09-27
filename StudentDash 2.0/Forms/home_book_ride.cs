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
    }
}
