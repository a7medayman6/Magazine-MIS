using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazino
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnManagersInfo_Click(object sender, EventArgs e)
        {
            new Managers().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditionsInfo_Click(object sender, EventArgs e)
        {
            new Editions().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               new Report_Profit().Show();
               this.Hide();
          }

          private void btn_subReport_Click(object sender, EventArgs e)
          {
               new Form3().Show();
               this.Hide();
          }

          private void btnCustomersInfo_Click(object sender, EventArgs e)
          {
               new Form2().Show();
               this.Hide();
          }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
