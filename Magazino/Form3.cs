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
     public partial class Form3 : Form
     {
          CrystalReport2 CR_Subs;
          public Form3()
          {
               InitializeComponent();
          }

          private void btnGenerateReport_Click(object sender, EventArgs e)
          {
               crystalReportViewer1.ReportSource = CR_Subs;
          }

          private void Form3_Load(object sender, EventArgs e)
          {
               CR_Subs = new CrystalReport2();
          }

          private void pictureBox1_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }
     }
}
