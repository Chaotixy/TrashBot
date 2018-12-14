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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
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

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Hide();
            Register registration = new Register();
            registration.Show();
        }
    }
}
