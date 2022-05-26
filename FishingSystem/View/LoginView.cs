using FishingSystem.Controller;
using FishingSystem.Model;
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
        FishingSystemController fish = new FishingSystemController();
        public LoginView()
        {
            InitializeComponent();
        }
        private void LogInbtn_Click(object sender, EventArgs e)
        {
            var Login = fish.Login(LoginNametxt.Text, LoginPasswordtxt.Text);
            if (Login != null)
            {
                MessageBox.Show(Login);
            }
            else
            {
                HomeScreenView homeScreenView = new HomeScreenView();
                this.Hide();
                homeScreenView.Show();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
