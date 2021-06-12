using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Magazino
{
    public partial class Editions : Form
    {
      
        string connString = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;
        
        public Editions()
        {
            InitializeComponent();
        }

          private void Editions_Load(object sender, EventArgs e)
          {
               conn = new OracleConnection(connString);
               conn.Open();
               OracleCommand cmd = new OracleCommand();
               cmd.Connection = conn;
               cmd.CommandText = "select profit_per_edition_id from profit";

               OracleDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
               {
                    cmb_edition.Items.Add(dr[0].ToString());

               }
               dr.Close();
               conn.Close();
          }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn = new OracleConnection(connString);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetEditionInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Editionno", cmb_edition.SelectedItem.ToString());
            //cmd.Parameters.Add("title", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("noofsubs", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("Total", OracleDbType.Int32, ParameterDirection.Output);
               
            cmd.ExecuteNonQuery();
            
            //textBox2.Text = Convert.ToString(cmd.Parameters["title"].Value.ToString());
            textBox3.Text = Convert.ToString(cmd.Parameters["noofsubs"].Value.ToString());
            textBox4.Text = Convert.ToString(cmd.Parameters["Total"].Value.ToString());
            
            conn.Close();
        }

        private void cmb_edition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home hm = new Home();
            hm.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
