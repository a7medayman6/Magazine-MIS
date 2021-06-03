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
    public partial class Form1 : Form
    {
        // uncomment this after connecting to oracle database
        // edit the connection string to match the database data
        // connection string
        /*
        string connString = "Data Source=ORCL; User Id=scott;Password=tiger;";
        OracleConnection conn;
        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // uncomment this after connecting to oracle database
            // CONNECTING TO THE DATABASE
            /*
            conn = new OracleConnection(connString);
            conn.Open();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtUserName.Text.ToString().Trim();
            string pass = txtPassword.Text.ToString().Trim();

            if(email == "" || pass == "")
            {
                MessageBox.Show("Email and Password cannot be empty.");
                txtPassword.Clear();
                txtUserName.Focus();
            }
            else
            {
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
                if(dr.Read())
                {
                    new Home().Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password, Try Again.");
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
                dr.Close();

                */

                // COMMENT THE NEXT BLOCK OF CODE AFTER CONNECTING TO THE DATABASE
                {
                    if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
                    {
                        new Home().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password, Try Again.");
                        txtPassword.Clear();
                        txtUserName.Focus();
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // uncomment this after connecting to oracle database
            // CLOSE THE CONNECTION
            /*
            conn.Close();
            */
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
