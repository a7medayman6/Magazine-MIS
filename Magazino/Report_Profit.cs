using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Magazino
{
     public partial class Report_Profit : Form
     {
          CrystalReport1 CR_Profit;
          public Report_Profit()
          {
               InitializeComponent();
          }

        private void btnManagersInfo_Click(object sender, EventArgs e)
        {
               
               CR_Profit.SetParameterValue(0, Convert.ToDateTime(cmb_startDate.SelectedItem));
               CR_Profit.SetParameterValue(1, Convert.ToDateTime(cmb_endDate.SelectedItem));
               crystalReportViewer1.ReportSource = CR_Profit;
        }

          private void Report_Profit_Load(object sender, EventArgs e)
          {
               CR_Profit = new CrystalReport1();
               foreach (ParameterDiscreteValue date in CR_Profit.ParameterFields[0].DefaultValues)
               {
                    
                    cmb_startDate.Items.Add(date.Value.ToString());
                    cmb_endDate.Items.Add(date.Value.ToString());
               }
          }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home hm = new Home();
            hm.Show();
        }
    }
}
