using AD_project.src.controllers;
using AD_project.src.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AD_project.src.views
{
    public partial class Apartment : Form
    {
        AdminMain main;
        String currentlyOperating;

        public Apartment(AdminMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnMangeBuilding_Click(object sender, EventArgs e)
        {
            main.loadForm(new Building(main));
        }

        private void btnMangeClasses_Click(object sender, EventArgs e)
        {
            main.loadForm(new ApartmentClass(main));
        }

        private void btnManageParkingSlot_Click(object sender, EventArgs e)
        {
        }

        private void Apartment_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adapter = new BuildingController().getAllBuildings();
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataTable.Rows.Add("Select Building");
                cbBuilding.DataSource = dataTable;
                cbBuilding.DisplayMember = "id";
                cbBuilding.ValueMember = "id";
                cbBuilding.SelectedValue = "Select Building";

                ApartmentController controller= new ApartmentController();
                SqlDataAdapter classAdapter = controller.getAllApartmentClasses();
                DataTable classTable = new DataTable();
                classAdapter.Fill(classTable);
                //dataTable1.Rows.Add("Select Class");
                cbClass.DataSource = classTable;
                cbClass.DisplayMember = "title";
                cbClass.ValueMember = "id";
                //cbClass.SelectedValue = "Select Class";

                SqlDataAdapter apartmentAdapter = controller.getAllApartments();
                DataTable apartmentTable = new DataTable();
                apartmentAdapter.Fill(apartmentTable);
                dgvApartment.DataSource = apartmentTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string buildingId = cbBuilding.Text;
                string classId = cbClass.GetItemText(cbClass.SelectedValue);
                string state = cbState.Text;
                int floorArea = Int32.Parse(txtFloorArea.Text);
                double monthlyRent = Double.Parse(txtRent.Text);
                double reservationFee = Double.Parse(txtReservationFee.Text);
                double refundableDeposit = Double.Parse(txtRefundableDeposit.Text);
                int maxOcNo = Int32.Parse(txtMaxOcNo.Text);
                if (buildingId == "" || classId == "" || state == "" || floorArea == 0 || monthlyRent == 0 || reservationFee == 0 || refundableDeposit == 0 || maxOcNo == 0)
                {
                    MessageBox.Show("Please check values again");
                    return;
                }

                ApartmentModel model = new ApartmentModel(buildingId, classId, state, floorArea, monthlyRent, reservationFee, refundableDeposit, maxOcNo);
                bool success = new ApartmentController().saveApartment(model);
                
                if (success)
                {
                    txtFloorArea.Text = "";
                    txtMaxOcNo.Text = "";
                    txtRefundableDeposit.Text = "";
                    txtRent.Text = "";
                    txtReservationFee.Text = "";
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
                string buildingId = cbBuilding.Text;
                string classId = cbClass.GetItemText(cbClass.SelectedValue);
                string state = cbState.Text;
                int floorArea = Int32.Parse(txtFloorArea.Text);
                double monthlyRent = Double.Parse(txtRent.Text);
                double reservationFee = Double.Parse(txtReservationFee.Text);
                double refundableDeposit = Double.Parse(txtRefundableDeposit.Text);
                int maxOcNo = Int32.Parse(txtMaxOcNo.Text);
                if (buildingId == "" || classId == "" || state == "" || floorArea == 0 || monthlyRent == 0 || reservationFee == 0 || refundableDeposit == 0 || maxOcNo == 0)
                {
                    MessageBox.Show("Please check values again");
                    return;
                }

                ApartmentModel model = new ApartmentModel(currentlyOperating, buildingId, classId, state, floorArea, monthlyRent, reservationFee, refundableDeposit, maxOcNo);
                bool success = new ApartmentController().updateApartment(model);

                if (success)
                {
                    txtFloorArea.Text = "";
                    txtMaxOcNo.Text = "";
                    txtRefundableDeposit.Text = "";
                    txtRent.Text = "";
                    txtReservationFee.Text = "";
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
                bool success = new ApartmentController().deleteApartment(currentlyOperating);
                if (success)
                {
                    txtFloorArea.Text = "";
                    txtMaxOcNo.Text = "";
                    txtRefundableDeposit.Text = "";
                    txtRent.Text = "";
                    txtReservationFee.Text = "";
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtFloorArea.Text = "";
            txtMaxOcNo.Text = "";
            txtRefundableDeposit.Text = "";
            txtRent.Text = "";
            txtReservationFee.Text = "";
        }

        private void dgvApartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvApartment.Rows[e.RowIndex];
                currentlyOperating = row.Cells[0].Value.ToString();
                txtFloorArea.Text = row.Cells[4].Value.ToString();
                txtMaxOcNo.Text = row.Cells[8].Value.ToString();
                txtRefundableDeposit.Text = row.Cells[7].Value.ToString();
                txtRent.Text = row.Cells[5].Value.ToString();
                txtReservationFee.Text = row.Cells[6].Value.ToString();
            }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
