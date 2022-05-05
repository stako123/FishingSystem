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
    public partial class WelcomeView : Form
    {
        public WelcomeView()
        {
            InitializeComponent();
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            new RegistersView().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
