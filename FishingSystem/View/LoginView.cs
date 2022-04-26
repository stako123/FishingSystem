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

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogInbtn_Click(object sender, EventArgs e)
        {
            if (Namespacetxt.Text=="your_user_name" && Passwordspacetxt.Text=="your_password")
            {
                //това води до homescreena
                new HomeScreen().Show();
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
    }
}
