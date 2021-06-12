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
    public partial class Managers : Form
    {
       //Disconnected mode
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        //Connectedmode
        string DB = "Data Source=orcl; User Id=hr;Password=hr;";
        OracleConnection conn;

       

        public Managers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Managers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Manager Has Been Updated Successfully");

        }

        private void gridManagers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=orcl ; User Id=hr; Password=hr;";
            string cmd = "SELECT Manager_Id, First_name, Last_name, Email ,Pass FROM MANAGERS";
            adapter = new OracleDataAdapter(cmd, connString);
            ds = new DataSet();
            adapter.Fill(ds);
            gridManagers.DataSource = ds.Tables[0];
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(DB);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Managers values (:id,:Fname,:Lname,:Email,:Pass)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", textBox1.Text);
            cmd.Parameters.Add("Fname", textBox2.Text);
            cmd.Parameters.Add("Lname", textBox3.Text);
            cmd.Parameters.Add("Email", textBox5.Text);
            cmd.Parameters.Add("Pass", textBox4.Text);


            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Manager Has Been Added Successfully");
                conn.Close();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home hm = new Home();
            hm.Show();
  
        }

    }

}
