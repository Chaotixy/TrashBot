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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("LoginSystem"))
            {
                process.Kill();
            }
        }
    }
}
