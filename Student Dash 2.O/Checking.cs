using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Dash_2.O
{
    public partial class Checking : Form
    {
        public Checking()
        {
            InitializeComponent();
        }

        private void User_Button_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Visible = true;
            this.Close();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Button_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Close();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Checking_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            User_Login user_Login1 = new User_Login();  
            user_Login1.Visible = true;
            this.Close();
        }
    }
}
