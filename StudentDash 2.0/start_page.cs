using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentDash_2._0.Forms;

namespace StudentDash_2._0
{
    public partial class start_page : Form
    {
        public start_page()
        {
            InitializeComponent();
        }

        private void progress_bar_timer_Tick(object sender, EventArgs e)
        {
            if (load_progress_bar.Value < 100)
            {
                load_progress_bar.Value += 3;
                progress_percentage_lbl.Text = load_progress_bar.Value.ToString() + "%";
            }
            else
            {
                progress_bar_timer.Stop();
                choose_login_page clp = new choose_login_page();
                clp.Visible = true;
                this.Visible = false;
            }
        }

        private void start_page_Load(object sender, EventArgs e)
        {
            progress_bar_timer.Start();
        }
    }
}
