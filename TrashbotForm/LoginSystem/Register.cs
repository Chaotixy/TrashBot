using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            boxUser.Clear();
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
                boxEmail.Text = "you@example.com";
            }
        }


        private void boxPass_Click_1(object sender, EventArgs e)
        {
            boxPass.Clear();
            piclock.Image = Properties.Resources.lock2;
            panel3.BackColor = Color.FromArgb(216, 191, 170);
            boxPass.ForeColor = Color.FromArgb(216, 191, 170);

            picuser.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            boxUser.ForeColor = Color.White;

            picemail.Image = Properties.Resources.email1;
            panel2.BackColor = Color.White;
            boxEmail.ForeColor = Color.White;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            login.Show();
            Environment.Exit(0);
        }

        private void boxEmail_Click_1(object sender, EventArgs e)
        {
            boxEmail.Clear();
            picemail.Image = Properties.Resources.email2;
            panel2.BackColor = Color.FromArgb(216, 191, 170);
            boxEmail.ForeColor = Color.FromArgb(216, 191, 170);

            picuser.Image = Properties.Resources.person1;
            panel1.BackColor = Color.White;
            boxUser.ForeColor = Color.White;

            piclock.Image = Properties.Resources.lock1;
            panel3.BackColor = Color.White;
            boxPass.ForeColor = Color.White;


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
