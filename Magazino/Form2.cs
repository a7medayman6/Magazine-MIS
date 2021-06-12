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
    public partial class Form2 : Form
    {
        OracleConnection con;
        string connString = "Data Source=orcl; User Id=hr;Password=hr;";
        public Form2()
        {
            InitializeComponent();
        }
         

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(connString);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GETCUSTOMERSIDS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Id", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
               
            }
            dr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select FIRST_NAME,AGE,STREET_ADDRESS,CITY,IS_SUBSCRIBED from CUSTOMERS where Customer_Id =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();

            }
            dr.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Home hm = new Home();
            hm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
    }
}
