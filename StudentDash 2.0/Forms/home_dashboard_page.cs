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
    public partial class profile_panel : Form
    {
        public profile_panel()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void change_password_btn_MouseHover(object sender, EventArgs e)
        {
            change_password_btn.ForeColor = Color.Black;
        }

        private void change_password_btn_MouseLeave(object sender, EventArgs e)
        {
            change_password_btn.ForeColor = Color.White;
        }

        private void number_update_btn_MouseHover(object sender, EventArgs e)
        {
            number_update_btn.ForeColor = Color.Black;
        }

        private void number_update_btn_MouseLeave(object sender, EventArgs e)
        {
            number_update_btn.ForeColor = Color.White;
        }
    }
}
