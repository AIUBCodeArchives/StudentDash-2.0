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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Loading.Value < 100)
            {
                Loading.Value += 5;
                Progress.Text = Loading.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Checking checking = new Checking();
                checking.Show();
                this.Visible = false;


            }
        }
    }
}
