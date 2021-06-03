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
    public partial class Editions : Form
    {
        // uncomment this after connecting to oracle database
        // edit the connection string to match the database data
        // connection string
        /*
        string connString = "Data Source=ORCL; User Id=scott;Password=tiger;";
        OracleConnection conn;
        */
        public Editions()
        {
            InitializeComponent();
        }

        private void Editions_Load(object sender, EventArgs e)
        {
            // uncomment this after connecting to oracle database
            // CONNECTING TO THE DATABASE
            /*
            conn = new OracleConnection(connString);
            conn.Open();
            */
            // uncomment this after connecting to oracle database
            // login validation from database

            /*
            OracleCommand cmd = new OracleCommand(); 
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Manager_Id, First_name, Last_name FROM MANAGERS WHERE Email=:email AND Pass=:pass;"; 
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("pass", pass);

            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                
            }
            */
}
}
}
