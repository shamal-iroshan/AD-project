using AD_project.src.controllers;
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
        Main main;
        String currentlyOperating;

        public Apartment(Main main)
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

        public string getLastId()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("SELECT id FROM apartment ORDER BY id DESC", _connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                String tempID = reader.GetString(0);
                String[] split = tempID.Split('A');
                Int32 id = Int32.Parse(split[1]);
                id++;
                if (id < 10) return "A00" + id;
                else if (id < 100) return "A0" + id;
                else return "A" + id;
            }
            else
            {
                return "A001";
            }
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

                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM apartment_class", _connection);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                //dataTable1.Rows.Add("Select Class");
                cbClass.DataSource = dataTable1;
                cbClass.DisplayMember = "title";
                cbClass.ValueMember = "id";
                //cbClass.SelectedValue = "Select Class";

                SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM apartment", _connection);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
                dgvApartment.DataSource = dataTable2;
                _connection.Close();
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

                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO apartment(id, building_id,class_id,state,floor_area,monthly_rent,reservation_fee,refundable_deposit,max_oc_no) VALUES(@0, @1, @2, @3, @4, @5, @6, @7, @8)", _connection);
                command.Parameters.Add(new SqlParameter("0", getLastId()));
                command.Parameters.Add(new SqlParameter("1", buildingId));
                command.Parameters.Add(new SqlParameter("2", classId));
                command.Parameters.Add(new SqlParameter("3", state));
                command.Parameters.Add(new SqlParameter("4", floorArea));
                command.Parameters.Add(new SqlParameter("5", monthlyRent));
                command.Parameters.Add(new SqlParameter("6", reservationFee));
                command.Parameters.Add(new SqlParameter("7", refundableDeposit));
                command.Parameters.Add(new SqlParameter("8", maxOcNo));
                int rows = command.ExecuteNonQuery();
                _connection.Close();
                if (rows > 0)
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgvApartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
