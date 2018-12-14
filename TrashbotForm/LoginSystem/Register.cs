using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void boxUser_Click(object sender, EventArgs e)
        {
            if (boxUser.Text == "" || boxUser.Text == "Pick a username")
            {
                boxUser.Clear();
            }
            picuser.Image = Properties.Resources.person2;
            panel1.BackColor = Color.FromArgb(216, 191, 170);
            boxUser.ForeColor = Color.FromArgb(216, 191, 170);

            picemail.Image = Properties.Resources.email1;
            panel2.BackColor = Color.White;
            boxEmail.ForeColor = Color.White;

            piclock.Image = Properties.Resources.lock1;
            panel3.BackColor = Color.White;
            boxPass.ForeColor = Color.White;

            if (boxPass.Text == "")
            {
                this.boxPass.PasswordChar = char.MinValue;
                boxPass.Text = "Create a password";
            }
            if (boxEmail.Text == "")
            { 
                boxEmail.Text = "You@example.com";
            }
        }


        private void boxPass_Click_1(object sender, EventArgs e)
        {
            if (boxPass.Text == "" || boxPass.Text == "Create a password")
            {
                boxPass.Clear();
            }
            boxPass.PasswordChar = '•';
            piclock.Image = Properties.Resources.lock2;
            panel3.BackColor = Color.FromArgb(216, 191, 170);
            boxPass.ForeColor = Color.FromArgb(216, 191, 170);

            picuser.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            boxUser.ForeColor = Color.White;

            picemail.Image = Properties.Resources.email1;
            panel2.BackColor = Color.White;
            boxEmail.ForeColor = Color.White;


            if (boxUser.Text == "")
            {
                boxUser.Text = "Pick a username";
            }
            if (boxEmail.Text == "")
            {
                boxEmail.Text = "You@example.com";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void boxEmail_Click_1(object sender, EventArgs e)
        {
            if (boxEmail.Text == "" || boxEmail.Text == "You@example.com")
            {
                boxEmail.Clear();
            }
            picemail.Image = Properties.Resources.email2;
            panel2.BackColor = Color.FromArgb(216, 191, 170);
            boxEmail.ForeColor = Color.FromArgb(216, 191, 170);

            picuser.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            boxUser.ForeColor = Color.White;

            piclock.Image = Properties.Resources.lock1;
            panel3.BackColor = Color.White;
            boxPass.ForeColor = Color.White;

            if (boxPass.Text == "")
            {
                this.boxPass.PasswordChar = char.MinValue;
                boxPass.Text = "Create a password";
            }
            if (boxUser.Text == "")
            {
                boxUser.Text = "Pick a username";
            }


        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(this.Icon, new Size(this.Icon.Width * 5, this.Icon.Height * 5));
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("LoginSystem"))
            {
                process.Kill();
            }
        }



        // Checking after the next step button is clicked if the field has been filled in.
        private void button1_Click(object sender, EventArgs e)
        {


            if (boxUser.Text == "" || boxUser.Text == "Pick a username")
            {
                userErr.Text = "* Please pick a username";

                if(boxEmail.Text == "" || boxEmail.Text == "You@example.com")
                {
                    emailErr.Text = "* Please fill in your email";
                }
                else {
                    emailErr.Text = "";
                     }

                if (boxPass.Text == "" || boxPass.Text == "Create a password")
                {
                    passErr.Text = "* Please create a password";

                }
                else
                {
                    passErr.Text = "";
                }


            }
            else
            {
                userErr.Text = "";
            }

            if (boxEmail.Text == "" || boxEmail.Text == "You@example.com")
            {
                emailErr.Text = "* Please fill in your email";

                if (boxUser.Text == "" || boxUser.Text == "Pick a username")
                {
                    userErr.Text = "* Please pick a username";
                }
                else
                {
                    userErr.Text = "";
                }

                if (boxPass.Text == "" || boxPass.Text == "Create a password")
                {
                    passErr.Text = "* Please create a password";

                }
                else
                {
                    passErr.Text = "";
                }


            }
            else {
                emailErr.Text = "";
            }

            if (boxPass.Text == "" || boxPass.Text == "Create a password")
            {
                passErr.Text = "* Please create a password";

                if (boxUser.Text == "" || boxUser.Text == "Pick a username")
                {
                    userErr.Text = "* Please pick a username";
                }
                else
                {
                    userErr.Text = "";
                }

                if (boxEmail.Text == "" || boxEmail.Text == "You@example.com")
                {
                    emailErr.Text = "* Please fill in your email";
                }
                else
                {
                    emailErr.Text = "";
                }
            }
            else
            {
                passErr.Text = "";
            }

            if ((boxUser.Text == "" || boxUser.Text == "Pick a username") && (boxEmail.Text == "" || boxEmail.Text == "You@example.com") && (boxPass.Text == "" || boxPass.Text == "Create a password"))
            {
                userErr.Text = "* Please pick a username";
                emailErr.Text = "* Please fill in your email";
                passErr.Text = "* Please create a password";
            }

            if (!(boxUser.Text == "" || boxUser.Text == "Pick a username") && !(boxEmail.Text == "" || boxEmail.Text == "You@example.com") && !(boxPass.Text == "" || boxPass.Text == "Create a password"))
            {
                this.Hide();
                Register2 next = new Register2();
                next.Show();
            }

        }
    }
}
