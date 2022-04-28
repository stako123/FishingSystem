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
            if (Namespacetxt.Text=="name" && Passwordspacetxt.Text=="password")
            {
                new HomeScreenView().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The Username or password is incorrect, please try again");
                Namespacetxt.Clear();
                Passwordspacetxt.Clear();
                Namespacetxt.Focus();
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                Passwordspacetxt.PasswordChar = '\0';
            }
            else
            {
                Passwordspacetxt.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
