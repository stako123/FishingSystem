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
    public partial class HomeScreenView : Form
    {
        public HomeScreenView()
        {
            InitializeComponent();
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            new CatchView().Show();
            this.Hide();
        }
    }
}
