using AD_project.src.controllers;
using AD_project.src.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_project.src.views
{
    public partial class ParkingSpace : Form
    {
        string currentlyOperating;
        public ParkingSpace()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void ParkingSpace_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new ParkingController().getAllParking();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvParkingSapce.DataSource = dataTable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                double fee = Double.Parse(txtFee.Text);
                string availability = cmbAvailability.Text;
                string apartmentId = cbApartment.Text;
                ParkingSpaceModel model = new ParkingSpaceModel(fee, availability, apartmentId);
                if (fee == 0 || availability == "" || apartmentId == "")
                {
                    MessageBox.Show("Please check values again");
                    return;
                }
                bool success = new ParkingController().saveParkingSpace(model);
                if (success)
                {
                    txtFee.Text = "";
                    cmbAvailability.Text = "";
                    MessageBox.Show("Saved successfully..!");
                }
                else
                {
                    MessageBox.Show("Something went wrong..!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                double fee = Double.Parse(txtFee.Text);
                string availability = cmbAvailability.Text;
                string apartmentId = cbApartment.Text;
                ParkingSpaceModel model = new ParkingSpaceModel(currentlyOperating, fee, availability, apartmentId);
                if (fee == 0 || availability == "" || apartmentId == "")
                {
                    MessageBox.Show("Please check values again");
                    return;
                }
                bool success = new ParkingController().updateParkingSpace(model);
                if (success)
                {
                    txtFee.Text = "";
                    cmbAvailability.Text = "";
                    MessageBox.Show("Updated successfully..!");
                }
                else
                {
                    MessageBox.Show("Something went wrong..!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = new ParkingController().deleteParkingSpace(currentlyOperating);
            if (success)
            {
                txtFee.Text = "";
                cmbAvailability.Text = "";
                MessageBox.Show("Deleted successfully..!");
            }
            else
            {
                MessageBox.Show("Something went wrong..!");
            }
        }

        private void dgvParkingSapce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvParkingSapce.Rows[e.RowIndex];
                txtFee.Text = row.Cells[1].Value.ToString();
                currentlyOperating = row.Cells[0].Value.ToString();
            }
        }
    }
}
