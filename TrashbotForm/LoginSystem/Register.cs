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
            boxUser.ForeColor = Color.FromArgb(216, 191, 170);

        }

        private void boxEmail_Click(object sender, EventArgs e)
        {
            boxEmail.Clear();
            boxEmail.ForeColor = Color.FromArgb(216, 191, 170);

        }

        private void boxPass_Click(object sender, EventArgs e)
        {
            boxPass.Clear();
            boxPass.ForeColor = Color.FromArgb(216, 191, 170);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
