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
    public partial class RegistersView : Form
    {
        RegisterController controller = new RegisterController();
        public RegistersView()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new WelcomeView().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Login acc = new Login();

            acc.name = txtName.Text;
            acc.password = txtPassword.Text;
            acc.email = txtEmail.Text;

            controller.RegisterCreate(acc);

            HomeScreenView homeScreenView = new HomeScreenView();
            this.Hide();
            homeScreenView.Show();
        }
    }
}
