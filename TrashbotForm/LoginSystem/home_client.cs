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
        private string con, sql;
        public static string CurrentUser, CurrentAddress, CurrentCity;

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
                    }
                }
                cnn.Close();

            }
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("LoginSystem"))
            {
                process.Kill();
            }
        }

        private void home_client_Load(object sender, EventArgs e)
        {
            label2.Text = "Welcome, " + CurrentUser + "!";
            label3.Text = "Address: " + CurrentAddress;
            label4.Text = "City: " +CurrentCity;
        }

        private void minmax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                minmax.Text = "+";
            }else if (this.WindowState == FormWindowState.Normal){
                this.WindowState = FormWindowState.Maximized;
                minmax.Text = "-";
            }

        }
    }
}
