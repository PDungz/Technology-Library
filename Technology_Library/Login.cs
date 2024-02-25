using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Technology_Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Button Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "admin" && txbPassWord.Text == "12345") { 
                Dashboard ds = new Dashboard();
                // An form login
                this.Hide();
                // Mo form Dashboard
                ds.Show();
            } else
            {
                labelError.Visible = true;
            }
            
        }

        // Button Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
