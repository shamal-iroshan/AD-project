using AD_project.src.controllers;
using AD_project.src.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_project.src.views
{
    public partial class Building : Form
    {
        Main main;
        String currentlyOperating;

        public Building(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.loadForm(new Apartment(main));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BuildingModel model = new BuildingModel(txtLocation.Text);
            if(model.Location == "")
            {
                MessageBox.Show("Please check values again");
                return;
            }
            try
            {
                bool success = new BuildingController().saveBuilding(model);
                if(success)
                {
                    txtLocation.Text = "";
                    MessageBox.Show("Saved successfully..!");
                } else
                {
                    MessageBox.Show("Something went wrong..!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Building_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new BuildingController().getAllBuildings();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvBuilding.DataSource = dataTable;
        }

        private void dgvBuilding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBuilding.Rows[e.RowIndex];
                txtLocation.Text = row.Cells[1].Value.ToString();
                currentlyOperating = row.Cells[0].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BuildingModel model = new BuildingModel(currentlyOperating, txtLocation.Text);
            if (model.Location == "")
            {
                MessageBox.Show("Please check values again");
                return;
            }
            try
            {
                new BuildingController().updateBuilding(model);
                txtLocation.Text = "";
                MessageBox.Show("Updated successfully..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                new BuildingController().deleteBuilding(currentlyOperating);
                txtLocation.Text = "";
                MessageBox.Show("Deleted successfully..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
