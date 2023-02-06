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
    public partial class ApartmentClass : Form
    {
        AdminMain main;
        String currentlyOperating;

        public ApartmentClass(AdminMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.loadForm(new Apartment(main));
        }

        private void ApartmentClass_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new ApartmnetClassController().getAllClasses();
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvClasses.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            if(title == "" || description == "")
            {
                MessageBox.Show("Please check values again");
                return;
            }
            ApartmentClassModel model = new ApartmentClassModel(title, description);

            try
            {
                bool success = new ApartmnetClassController().saveClass(model);
                if (success)
                {
                    txtTitle.Text = "";
                    txtDescription.Text = "";
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
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            if (title == "" || description == "")
            {
                MessageBox.Show("Please check values again");
                return;
            }
            ApartmentClassModel model = new ApartmentClassModel(currentlyOperating, title, description);

            try
            {
                bool success = new ApartmnetClassController().updateClass(model);
                if (success)
                {
                    txtTitle.Text = "";
                    txtDescription.Text = "";
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
            try
            {
                bool success = new ApartmnetClassController().deleteClass(currentlyOperating);
                if (success)
                {
                    txtTitle.Text = "";
                    txtDescription.Text = "";
                    MessageBox.Show("Deleted successfully..!");
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

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvClasses.Rows[e.RowIndex];
                txtTitle.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                currentlyOperating = row.Cells[0].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
        }
    }
}
