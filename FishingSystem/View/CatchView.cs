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
    public partial class CatchView : Form
    {
        FishingSystemController fishingController = new FishingSystemController();

        public CatchView()
        {
            InitializeComponent();
        }

        private void btnCreateCatch_Click(object sender, EventArgs e)
        {
            Catch catchtoadd = new Catch();
            catchtoadd.AmountOfCatch = int.Parse(txtAmountOfCatch.Text);
            catchtoadd.TripLenght = double.Parse(txtTripLenght.Text);
            catchtoadd.TripStartDate = int.Parse(txtTripStartDate.Text);
            fishingController.CreateCatch(catchtoadd);
            RefreshTable();
        }

        private void CatchView_Load(object sender, EventArgs e)
        {
            dgvCatch.DataSource = fishingController.GetAll();
            dgvCatch.Columns.Remove("ShipID");
            dgvCatch.Columns.Remove("CatchID");
            dgvCatch.Columns.Remove("Ship");
        }
        private void RefreshTable()
        {
            dgvCatch.DataSource = fishingController.GetAll();
        }
        private void btnDeleteCatch_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCatch.CurrentRow;
            int a = int.Parse(row.Cells[0].Value.ToString());
            fishingController.DeleteCatch(a);
            RefreshTable();
        }

        private void btnUpdateCatch_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCatch.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Catch catchtoupdate = new Catch();
            catchtoupdate.AmountOfCatch = int.Parse(txtAmountOfCatch.Text);
            catchtoupdate.TripLenght = double.Parse(txtTripLenght.Text);
            catchtoupdate.TripStartDate = int.Parse(txtTripStartDate.Text);
            fishingController.UpdateCatch(id, catchtoupdate);
            RefreshTable();
        }
    }
}
