using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// UNCOMMENT AFTER CONNECTING TO DB

// using Oracle.DataAccess.Client;
// using Oracle.DataAccess.Types;

namespace Magazino
{
    public partial class Managers : Form
    {
        // UNCOMMENT AFTER CONNECTING TO DB
        /*
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        */
        DataSet ds;

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
            // UNCOMMENT AFTER CONNECTING TO DB
            /*
            string connString = "Data Source=ORCL; User Id=scott;Password=tiger;";

            string cmd = "SELECT Manager_Id, First_name, Last_name, Email FROM MANAGERS"
            adapter = new OracleDataAdapter(connString, cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            gridManagers.DataSource = ds.Tables[0];

            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // UNCOMMENT AFTER CONNECTING TO DB
            /*
            OracleCommandBuilderbuilder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            */
        }
    }
}
