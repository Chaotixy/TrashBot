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
    public partial class home_client : Form
    {
        public home_client()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("LoginSystem"))
            {
                process.Kill();
            }
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
