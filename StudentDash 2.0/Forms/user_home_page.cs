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
    public partial class user_home_page : Form
    {
        public user_home_page()
        {
            InitializeComponent();
        }

        public void load_form(object Form)
        {
            if(this.main_panel.Controls.Count > 0)
            {
                this.main_panel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();
        }
        
        
        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            load_form(new profile_panel());
            dashboard_btn.FillColor = Color.FromArgb(155, 190, 200);
            book_ride_btn.FillColor = Color.FromArgb(94, 124, 137);
            share_ride_btn.FillColor = Color.FromArgb(94, 124, 137);
            contact_us_btn.FillColor = Color.FromArgb(94, 124, 137);
        }

        private void book_ride_btn_Click(object sender, EventArgs e)
        {
            load_form(new home_book_ride());
            dashboard_btn.FillColor = Color.FromArgb(94, 124, 137);
            book_ride_btn.FillColor = Color.FromArgb(155, 190, 200);
            share_ride_btn.FillColor = Color.FromArgb(94, 124, 137);
            contact_us_btn.FillColor = Color.FromArgb(94, 124, 137);
        }

        private void share_ride_btn_Click(object sender, EventArgs e)
        {
            load_form(new home_share_ride());
            dashboard_btn.FillColor = Color.FromArgb(94, 124, 137);
            book_ride_btn.FillColor = Color.FromArgb(94, 124, 137);
            share_ride_btn.FillColor = Color.FromArgb(155, 190, 200);
            contact_us_btn.FillColor = Color.FromArgb(94, 124, 137);
        }

        private void contact_us_btn_Click(object sender, EventArgs e)
        {
            load_form(new home_contact_us());
            dashboard_btn.FillColor = Color.FromArgb(94, 124, 137);
            book_ride_btn.FillColor = Color.FromArgb(94, 124, 137);
            share_ride_btn.FillColor = Color.FromArgb(94, 124, 137);
            contact_us_btn.FillColor = Color.FromArgb(155, 190, 200);
        }

        private void user_home_page_Load(object sender, EventArgs e)
        {
            load_form(new profile_panel());
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            user_login_page ulp = new user_login_page();
            ulp.Show();
            this.Visible = false;
        }

        private void sign_out_btn_Click(object sender, EventArgs e)
        {
            user_login_page ulp = new user_login_page();
            ulp.Show();
            this.Visible = false;
        }







        // DO NOT FREAKIN TOUCH/DELETE THIS

    }
}
