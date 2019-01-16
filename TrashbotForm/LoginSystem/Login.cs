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
using System.Security.Cryptography;


namespace LoginSystem
{
   

    public partial class Login : Form
    {
        string con = "Data Source = 81.169.200.100,1433; Network Library = DBMSSOCN;" +
                     "Initial Catalog = Trashbot; User ID = UserLogin; Password = Test123;";

        private static int attempt = 3;
        private string sql;
        public static int SessionUserID, SID;


        public Login()
        {
            InitializeComponent();
        }

        // So you can move the form around
        private bool mouseDown;
        private Point lastLocation;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }



        // Makes application icon bigger in taskbar.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(this.Icon, new Size(this.Icon.Width * 5, this.Icon.Height * 5));
        }

        //Create the hashing process
        static string HashProcess(string rawData)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
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

        // To make sure the password is still hidden after pressing the tab key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab && textBox1.Focused)
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

            }if (keyData == Keys.Tab && CompanyCheck.Focused)
            {
                picperson.Image = Properties.Resources.person2;
                panel1.BackColor = Color.FromArgb(216, 191, 170);
                textBox1.ForeColor = Color.FromArgb(216, 191, 170);

                piclock.Image = Properties.Resources.lock1;
                panel2.BackColor = Color.White;
                textBox2.ForeColor = Color.White;
            }
            if (keyData == Keys.Tab && textBox2.Focused)
            {
                piclock.Image = Properties.Resources.lock1;
                panel2.BackColor = Color.White;
                textBox2.ForeColor = Color.White;

                if (textBox2.Text == "" || textBox2.Text == "Password")
                {
                    this.textBox2.PasswordChar = char.MinValue;
                    textBox2.Text = "Password";
                }

            }
            

                return base.ProcessCmdKey(ref msg, keyData);
        }

        //Runs the code as if login button is clicked when pressing enter
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && textBox2.Focused)
            {
                button1_Click(sender, e);
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

                    // Hash password
                    string raw = textBox2.Text;
                    string HashPass = HashProcess(raw);
                    string PassWord = HashPass;

                    if (PersonCheck.Checked)
                    {
                        sql =
                            "SELECT Username, Password, Home_User_ID FROM Home_User WHERE [Username] = @Username AND [Password] = @Password";
                    }

                    if (CompanyCheck.Checked)
                    {
                        sql =
                            "SELECT Username, Password, Trash_Company_ID FROM Trash_Company WHERE [Username] = @Username AND [Password] = @Password";
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


                            attempt = 3;
                            //Create a Session via grabbing ID of Tables
                            if (CompanyCheck.Checked)
                            {
                                //Create a Reader to get the ID
                                SqlDataReader IDRdr = null;

                                IDRdr = cmd.ExecuteReader();
                                while (IDRdr.Read())
                                {
                                    SessionUserID =  (int)IDRdr["Trash_Company_ID"];
                                }

                            }

                            if (PersonCheck.Checked)
                            {
                                SqlDataReader IDRdr = null;

                                IDRdr = cmd.ExecuteReader();
                                while (IDRdr.Read())
                                {
                                    SessionUserID = (int)IDRdr["Home_User_ID"];
                                }
                                
                            }

                            if (CompanyCheck.Checked)
                            {
                                SID = SessionUserID;
                                this.Hide();
                                home index = new home();
                                index.Show();
                            }else if (PersonCheck.Checked)
                            {
                                SID = SessionUserID;
                                this.Hide();
                                home_client index_client = new home_client();
                                index_client.Show();
                            }

                        }

                        else
                            {
                                MessageBox.Show("Fail: " + Convert.ToString(attempt) + " Attempts left!");
                                --attempt;
                            }
                        
                            

                        }
                    cnn.Close();
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
