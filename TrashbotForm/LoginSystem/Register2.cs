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
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LoginSystem
{
    public partial class Register2 : Form
    {
        private string sql;
        public Register2()
        {
            InitializeComponent();

           
        }

        // So you can move the form around
        private bool mouseDown;
        private Point lastLocation;
        private void Register2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Register2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Register2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Makes application icon bigger in taskbar.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(this.Icon, new Size(this.Icon.Width * 5, this.Icon.Height * 5));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        // To make sure the styling is still there after using the tab key
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab && CompanyCheck.Focused)
            {
                picuser.Image = Properties.Resources.person2;
                panel1.BackColor = Color.FromArgb(216, 191, 170);
                boxUser.ForeColor = Color.FromArgb(216, 191, 170);
                label1.ForeColor = Color.FromArgb(216, 191, 170);

                picadd.Image = Properties.Resources.address1;
                panel2.BackColor = Color.White;
                boxAddress.ForeColor = Color.White;
                label2.ForeColor = Color.White;

                piccity.Image = Properties.Resources.city1;
                panel3.BackColor = Color.White;
                boxCity.ForeColor = Color.White;
                label3.ForeColor = Color.White;

            }else if(keyData == Keys.Tab && boxUser.Focused)
            {
                picadd.Image = Properties.Resources.address2;
                panel2.BackColor = Color.FromArgb(216, 191, 170);
                boxAddress.ForeColor = Color.FromArgb(216, 191, 170);
                label2.ForeColor = Color.FromArgb(216, 191, 170);

                picuser.Image = Properties.Resources.person1;
                panel1.BackColor = Color.White;
                boxUser.ForeColor = Color.White;
                label1.ForeColor = Color.White;

                piccity.Image = Properties.Resources.city1;
                panel3.BackColor = Color.White;
                boxCity.ForeColor = Color.White;
                label3.ForeColor = Color.White;
            }else if (keyData == Keys.Tab && boxAddress.Focused)
            {
                piccity.Image = Properties.Resources.city2;
                panel3.BackColor = Color.FromArgb(216, 191, 170);
                boxCity.ForeColor = Color.FromArgb(216, 191, 170);
                label3.ForeColor = Color.FromArgb(216, 191, 170);

                picuser.Image = Properties.Resources.person1;
                panel1.BackColor = Color.White;
                boxUser.ForeColor = Color.White;
                label1.ForeColor = Color.White;

                picadd.Image = Properties.Resources.address1;
                panel2.BackColor = Color.White;
                boxAddress.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }
            else if (keyData == Keys.Tab && boxCity.Focused)
            {
                piccity.Image = Properties.Resources.city1;
                panel3.BackColor = Color.White;
                boxCity.ForeColor = Color.White;
                label3.ForeColor = Color.White;
            }

                return base.ProcessCmdKey(ref msg, keyData);
        }

                // Styling for when you click the add-fullname box.
                private void boxUser_Click(object sender, EventArgs e)
        {
            if (boxUser.Text == "" || boxUser.Text == "Enter full name" || boxUser.Text == "Enter company name")
            {
                boxUser.Clear();
            }
            picuser.Image = Properties.Resources.person2;
            panel1.BackColor = Color.FromArgb(216, 191, 170);
            boxUser.ForeColor = Color.FromArgb(216, 191, 170);
            label1.ForeColor = Color.FromArgb(216, 191, 170);

            picadd.Image = Properties.Resources.address1;
            panel2.BackColor = Color.White;
            boxAddress.ForeColor = Color.White;
            label2.ForeColor = Color.White;

            piccity.Image = Properties.Resources.city1;
            panel3.BackColor = Color.White;
            boxCity.ForeColor = Color.White;
            label3.ForeColor = Color.White;

            if (boxAddress.Text == "")
            {
                boxAddress.Text = "Enter address";
            }
            if (boxCity.Text == "")
            {
                boxCity.Text = "Enter city";
            }

        }

        // Styling for when you click the add-address box.
        private void boxAddress_Click(object sender, EventArgs e)
        {
            if (boxAddress.Text == "" || boxAddress.Text == "Enter address")
            {
                boxAddress.Clear();
            }
            picadd.Image = Properties.Resources.address2;
            panel2.BackColor = Color.FromArgb(216, 191, 170);
            boxAddress.ForeColor = Color.FromArgb(216, 191, 170);
            label2.ForeColor = Color.FromArgb(216, 191, 170);

            picuser.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            boxUser.ForeColor = Color.White;
            label1.ForeColor = Color.White;

            piccity.Image = Properties.Resources.city1;
            panel3.BackColor = Color.White;
            boxCity.ForeColor = Color.White;
            label3.ForeColor = Color.White;

            if (boxCity.Text == "")
            {
                boxCity.Text = "Enter city";
            }
            if (boxUser.Text == "")
            {
                if (PersonCheck.Checked)
                {
                    boxUser.Text = "Enter full name";
                }else if (CompanyCheck.Checked)
                {
                    boxUser.Text = "Enter company name";
                }
                
            }
        }

        // Styling for when you click the add-city box.
        private void boxCity_Click(object sender, EventArgs e)
        {
            if (boxCity.Text == "" || boxCity.Text == "Enter city")
            {
                boxCity.Clear();
            }
            
            piccity.Image = Properties.Resources.city2;
            panel3.BackColor = Color.FromArgb(216, 191, 170);
            boxCity.ForeColor = Color.FromArgb(216, 191, 170);
            label3.ForeColor = Color.FromArgb(216, 191, 170);

            picuser.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            boxUser.ForeColor = Color.White;
            label1.ForeColor = Color.White;

            picadd.Image = Properties.Resources.address1;
            panel2.BackColor = Color.White;
            boxAddress.ForeColor = Color.White;
            label2.ForeColor = Color.White;


            if (boxUser.Text == "")
            {
                if (PersonCheck.Checked)
                {
                    boxUser.Text = "Enter full name";
                }
                else if (CompanyCheck.Checked)
                {
                    boxUser.Text = "Enter company name";
                }
            }
            if (boxAddress.Text == "")
            {
                boxAddress.Text = "Enter address";
            }
        }

        // Checking after the register button is clicked if the field has been filled in.
        private void button1_Click(object sender, EventArgs e)
        {

            if (boxUser.Text == "" || boxUser.Text == "Enter full name" || boxUser.Text == "Enter company name")
            {
                if (PersonCheck.Checked)
                { 
                    userErr.Text = "* Please enter full name";
                }
                else if (CompanyCheck.Checked)
                {
                    userErr.Text = "* Please enter company name";
                }

                if (boxAddress.Text == "" || boxAddress.Text == "Enter address")
                {
                    addErr.Text = "* Please enter address";
                }
                else
                {
                    addErr.Text = "";
                }

                if (boxCity.Text == "" || boxCity.Text == "Enter city")
                {
                    cityErr.Text = "* Please enter city";

                }
                else
                {
                    cityErr.Text = "";
                }



            }
            else
            {
                userErr.Text = "";
            }

            if (boxAddress.Text == "" || boxAddress.Text == "Enter address")
            {
                addErr.Text = "* Please enter address";

                if (boxUser.Text == "" || boxUser.Text == "Enter full name" || boxUser.Text == "Enter company name")
                {
                    if (PersonCheck.Checked)
                    {
                        userErr.Text = "* Please enter full name";
                    }
                    else if (CompanyCheck.Checked)
                    {
                        userErr.Text = "* Please enter company name";
                    }
                }
                else
                {
                    userErr.Text = "";
                }

                if (boxCity.Text == "" || boxCity.Text == "Enter city")
                {
                    cityErr.Text = "* Please enter city";

                }
                else
                {
                    cityErr.Text = "";
                }

               
            }
            else
            {
                addErr.Text = "";
            }

            if (boxCity.Text == "" || boxCity.Text == "Enter city")
            {
                cityErr.Text = "* Please enter city";

                if (boxUser.Text == "" || boxUser.Text == "Enter full name" || boxUser.Text == "Enter company name")
                {
                    if (PersonCheck.Checked)
                    {
                        userErr.Text = "* Please enter full name";
                    }
                    else if (CompanyCheck.Checked)
                    {
                        userErr.Text = "* Please enter company name";
                    }
                }
                else
                {
                    userErr.Text = "";
                }

                if (boxAddress.Text == "" || boxAddress.Text == "Enter address")
                {
                    addErr.Text = "* Please enter address";
                }
                else
                {
                    addErr.Text = "";
                }

                
            }
            else
            {
                cityErr.Text = "";
            }


      

            if ((boxUser.Text == "" || boxUser.Text == "Enter full name" || boxUser.Text == "Enter company name") && (boxAddress.Text == "" || boxAddress.Text == "Enter address") && (boxCity.Text == "" || boxCity.Text == "Enter city"))
            {
                if (PersonCheck.Checked)
                {
                    userErr.Text = "* Please enter full name";
                }
                else if (CompanyCheck.Checked)
                {
                    userErr.Text = "* Please enter company name";
                }

                addErr.Text = "* Please enter address";
                cityErr.Text = "* Please enter city";
            }
            else
            {
                string UserName = Register.UserName;
                string UserMail = Register.UserMail;
                string UserPass = Register.UserPass;

                // Hash password
                string HashPass = HashProcess(UserPass);



                string FullName = boxUser.Text;
                string Address = boxAddress.Text;
                string City = boxCity.Text;

                string con = "Data Source = 81.169.200.100,1433; Network Library = DBMSSOCN;" +
                             "Initial Catalog = Trashbot; User ID = UserRegister; Password = Test123;";
                string conLogin = "Data Source = 81.169.200.100,1433; Network Library = DBMSSOCN;" +
                             "Initial Catalog = Trashbot; User ID = UserLogin; Password = Test123;";
                using (SqlConnection cnn = new SqlConnection(conLogin))
                {


                    if (PersonCheck.Checked)
                    {
                        sql =
                            "SELECT Username FROM Home_User WHERE [Username] = @Username;";
                    }

                    if (CompanyCheck.Checked)
                    {
                        sql =
                            "SELECT Username FROM Trash_Company WHERE [Username] = @Username";
                    }

                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@Username", UserName);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("User already exist!");
                            cnn.Close();
                        }
                        else
                        {
                            cnn.Close();
                            using (SqlConnection cnn2 = new SqlConnection(con))
                            {
                                if (PersonCheck.Checked)
                                {
                                    sql =
                                        "INSERT INTO Home_User ([Name],[Address],[City],[Email],[Password],[Username]) VALUES (@Fullname,@Address,@City,@Email,@Password,@Username)";
                                }
                                if (CompanyCheck.Checked)
                                {
                                    sql =
                                        "INSERT INTO Trash_Company ([Name],[Address],[City],[Username],[Password],[Company_Email]) VALUES (@Fullname,@Address,@City,@Username,@Password,@Email)";
                                }

                                cnn2.Open();
                                using (SqlCommand cmd2 = new SqlCommand(sql, cnn2))
                                {
                                    cmd2.Parameters.AddWithValue("@Username", UserName);
                                    cmd2.Parameters.AddWithValue("@Email", UserMail);
                                    cmd2.Parameters.AddWithValue("@Password", HashPass);
                                    cmd2.Parameters.AddWithValue("@Fullname", FullName);
                                    cmd2.Parameters.AddWithValue("@Address", Address);
                                    cmd2.Parameters.AddWithValue("@City", City);

                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("Registered !! ");
                                    cnn2.Close();
                                }
                            }

                        }


                    }
                }
            }
        }

        // When you click step back it will take you to login page.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register stepb = new Register();
            stepb.Show();
        }

        // When you hit the X, it will kill the process to avoid problems. 
        private void Exit_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("LoginSystem"))
            {
                process.Kill();
            }
        }

        private void CompanyCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (CompanyCheck.Checked)
            {
                label1.Text = "Company name";
            }
            else if (PersonCheck.Checked)
            {
                label1.Text = "Full name";
            }

        }

        // Changes label text when the according radio button is pushed.
        private void PersonCheck_CheckedChanged(object sender, EventArgs e)
        {


            if (CompanyCheck.Checked)
            {
                label1.Text = "Company name";
                boxUser.Text = "Enter company name";
            }
            else if (PersonCheck.Checked)
            {
                label1.Text = "Full name";
                boxUser.Text = "Enter full name";
            }

        }

        
    }
}
