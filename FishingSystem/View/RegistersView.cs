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
        public RegistersView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistersView_Load(object sender, EventArgs e)
        {

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
    }
}
