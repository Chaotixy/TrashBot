﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Sql;
using System.Data.SqlClient;
namespace LoginSystem
{
    public partial class home_client : Form
    {


        private int SessionID;
        private string con, sql;
        private string CurrentUser, CurrentAddress, CurrentCity, Robot;


        public home_client()
        {
            SessionID = Login.SessionUserID;
            con = "Data Source = 81.169.200.100,1433; Network Library = DBMSSOCN;" +
                  "Initial Catalog = Trashbot; User ID = HomeUser; Password = Test123;";
            sql = "SELECT * FROM Home_User WHERE [Home_User_ID] = @ID";
            using (SqlConnection cnn = new SqlConnection(con))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@ID", SessionID);
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {

                        CurrentUser = Reader["Name"].ToString();
                        CurrentAddress = Reader["Address"].ToString();
                        CurrentCity = Reader["City"].ToString();
                        Robot = Reader["RobotID"].ToString();
                    }
                    Reader.Close();
                }
                cnn.Close();

            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void home_client_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome, " + CurrentUser + "!";
            label3.Text = "Address: " + CurrentAddress;
            label4.Text = "City: " +CurrentCity;
        }
        

        private void minmax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }

        }
    }
}
