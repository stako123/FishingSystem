using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingSystem.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }
        private void LogInbtn_Click(object sender, EventArgs e)
        {
            if (LoginNametxt.Text=="name" && LoginPasswordtxt.Text=="password")
            {
                new HomeScreenView().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The Username or password is incorrect, please try again");
                LoginNametxt.Clear();
                LoginPasswordtxt.Clear();
                LoginNametxt.Focus();
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                LoginPasswordtxt.PasswordChar = '\0';
            }
            else
            {
                LoginPasswordtxt.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new WelcomeView().Show();
            this.Hide();
        }
    }
}
