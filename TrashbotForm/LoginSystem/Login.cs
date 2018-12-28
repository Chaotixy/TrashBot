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
using System.Threading;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace LoginSystem
{
   

    public partial class Login : Form
    {
        string con = "Data Source = 81.169.200.100,1433; Network Library = DBMSSOCN;" +
                     "Initial Catalog = Trashbot; User ID = UserLogin; Password = Test123;";

        private static int attempt = 3;
        private string sql;
        public Login()
        {
            InitializeComponent();
        }

        // Makes application icon bigger in taskbar.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(this.Icon, new Size(this.Icon.Width * 5, this.Icon.Height * 5));
        }

        // Styling for when you click the username box.
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Username")
            {
                textBox1.Clear();
            }
            picperson.Image = Properties.Resources.person2;
            panel1.BackColor = Color.FromArgb(216, 191, 170);
            textBox1.ForeColor = Color.FromArgb(216, 191, 170);

            piclock.Image = Properties.Resources.lock1;
            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            if (textBox2.Text == "")
            {
                this.textBox2.PasswordChar = char.MinValue;
                textBox2.Text = "Password";
            }


        }

        // Styling for when you click the password box.
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "Password")
            {
                textBox2.Clear();
            }
            textBox2.PasswordChar = '•';
            piclock.Image = Properties.Resources.lock2;
            panel2.BackColor = Color.FromArgb(216, 191, 170);
            textBox2.ForeColor = Color.FromArgb(216, 191, 170);

            picperson.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
            }
        }

        // When you hit the login button it will check if everything is filled out.
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "" || textBox1.Text == "Username") && (textBox2.Text == "" || textBox2.Text == "Password"))
            {
                userErr.Text = "* Please fill in your username";
                passErr.Text = "* Please fill in your password";
            }
            else if (textBox1.Text == "" || textBox1.Text == "Username")
            {
                userErr.Text = "* Please fill in your username";
                passErr.Text = "";
            }
            else if(textBox2.Text == "" || textBox2.Text == "Password") {
                passErr.Text = "* Please fill in your password";
                userErr.Text = "";
            }
            else
            {
                userErr.Text = "";
                passErr.Text = "";
            }

            if ((textBox1.Text != "" || textBox1.Text != "Username") &&
                (textBox2.Text != "" || textBox2.Text != "Password"))
            {
                if (attempt == 0)
                {
                    MessageBox.Show("All 3 attempts have failed, please contact the support!");
                    return;
                }

                using (SqlConnection cnn = new SqlConnection(con))
                {

                    string UserName = textBox1.Text;
                    string PassWord = textBox2.Text;
                    if (PersonCheck.Checked)
                    {
                        sql =
                            "SELECT Username, Password FROM Home_User WHERE [Username] = @Username AND [Password] = @Password";
                    }

                    if (CompanyCheck.Checked)
                    {
                        sql =
                            "SELECT Username, Password FROM Trash_Company WHERE [Username] = @Username AND [Password] = @Password";
                    }
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Username", UserName);
                        cmd.Parameters.AddWithValue("@Password", PassWord);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Success!");
                            attempt = 3;
                        }
                        else
                        {
                            MessageBox.Show("Fail: " + Convert.ToString(attempt) + " Attempts left!");
                            --attempt;
                        }
                        cnn.Close();

                    }
                }
            }

        }

        // When you click register it will take you to register page.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registration = new Register();
            registration.Show();
        }

        // When you hit the X, it will kill the process to avoid problems. 
        private void Exit_Click(object sender, EventArgs e)
        {

            foreach (var process in Process.GetProcessesByName("LoginSystem"))
            {
                process.Kill();
            }

        }
    }
}
