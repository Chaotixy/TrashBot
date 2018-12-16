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


namespace LoginSystem
{
    public partial class Register2 : Form
    {
        public Register2()
        {
            InitializeComponent();
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

        // Styling for when you click the add-fullname box.
        private void boxUser_Click(object sender, EventArgs e)
        {
            if (boxUser.Text == "" || boxUser.Text == "Enter full name")
            {
                boxUser.Clear();
            }
            picuser.Image = Properties.Resources.person2;
            panel1.BackColor = Color.FromArgb(216, 191, 170);
            boxUser.ForeColor = Color.FromArgb(216, 191, 170);

            picadd.Image = Properties.Resources.address1;
            panel2.BackColor = Color.White;
            boxAddress.ForeColor = Color.White;

            piccity.Image = Properties.Resources.city1;
            panel3.BackColor = Color.White;
            boxCity.ForeColor = Color.White;

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

            picuser.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            boxUser.ForeColor = Color.White;

            piccity.Image = Properties.Resources.city1;
            panel3.BackColor = Color.White;
            boxCity.ForeColor = Color.White;

            if (boxCity.Text == "")
            {
                boxCity.Text = "Enter city";
            }
            if (boxUser.Text == "")
            {
                boxUser.Text = "Enter full name";
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

            picuser.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            boxUser.ForeColor = Color.White;

            picadd.Image = Properties.Resources.address1;
            panel2.BackColor = Color.White;
            boxAddress.ForeColor = Color.White;


            if (boxUser.Text == "")
            {
                boxUser.Text = "Enter full name";
            }
            if (boxAddress.Text == "")
            {
                boxAddress.Text = "Enter address";
            }
        }

        // Checking after the register button is clicked if the field has been filled in.
        private void button1_Click(object sender, EventArgs e)
        {

            if (boxUser.Text == "" || boxUser.Text == "Enter full name")
            {
                userErr.Text = "* Please enter full name";

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

                if (boxUser.Text == "" || boxUser.Text == "Enter full name")
                {
                    userErr.Text = "* Please enter full name";
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

                if (boxUser.Text == "" || boxUser.Text == "Enter full name")
                {
                    userErr.Text = "* Please enter full name";
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

            if ((boxUser.Text == "" || boxUser.Text == "Enter full name") && (boxAddress.Text == "" || boxAddress.Text == "Enter address") && (boxCity.Text == "" || boxCity.Text == "Enter city"))
            {
                userErr.Text = "* Please enter full name";
                addErr.Text = "* Please enter address";
                cityErr.Text = "* Please enter city";
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
    }
}
