using System;
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
        private string con, sql, sql2;
        private string CurrentUser, CurrentAddress, CurrentCity, Robot, weight;

        private string full;


        public home_client()
        {
            // retrieves data from client that is signed in by comparing ID.
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
                        Robot = Reader["Robot_ID"].ToString();
                    }
                    Reader.Close();
                }
                cnn.Close();

                sql2 = "SELECT * FROM Robot WHERE [Robot_ID] = @Robot";
                using (SqlConnection cnn2 = new SqlConnection(con))
                {
                    cnn2.Open();
                    using (SqlCommand cmd = new SqlCommand(sql2, cnn2))
                    {
                        cmd.Parameters.AddWithValue("@Robot", Robot);
                        SqlDataReader Reader = cmd.ExecuteReader();
                        while (Reader.Read())
                        {
                            full = Reader["State"].ToString();
                            weight = Reader["Weight"].ToString();

                        }
                        Reader.Close();
                    }
                    cnn2.Close();
                }
                InitializeComponent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void home_client_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome, " + CurrentUser;
            label3.Text = "Address: " + CurrentAddress;
            label4.Text = "City: " +CurrentCity;

            // Checking if a robot is assigned to the client.
            if(Robot == null || Robot == "")
            {
                label6.Text = "Your robot has not been activated yet, it will be activated by our team soon.";
            }else if (Robot != null || Robot != "")
            {
                label6.Text = "Information about your bin:";
                if(full == "False")
                {
                    fullPic.Image = Properties.Resources.binempty;
                    label7.Text = "Your bin is currently empty.";
                    label8.Text = "Weight of contents: " + weight + " Kg";
                }else if (full == "True")
                {
                    fullPic.Image = Properties.Resources.binfull;
                    label7.Text = "Your bin is full.";
                    label7.ForeColor = Color.Red;
                    label8.Text = "Weight of contents: " + weight + " Kg";
                }
            }
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
