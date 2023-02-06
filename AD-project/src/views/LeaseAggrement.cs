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
    public partial class LeaseAggrement : Form
    {
        public LeaseAggrement()
        {
            InitializeComponent();
        }

        private void LeaseAggrement_Load(object sender, EventArgs e)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM apartment", _connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbApartment.DataSource = dataTable;
            cbApartment.DisplayMember = "id";
            cbApartment.ValueMember = "id";

            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM chief_occupant", _connection);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            cbChiefOccupent.DataSource = dataTable1;
            cbChiefOccupent.DisplayMember = "name";
            cbChiefOccupent.ValueMember = "id";

            SqlDataAdapter adapter3 = new SqlDataAdapter("SELECT * FROM parking_space", _connection);
            DataTable dataTable3 = new DataTable();
            adapter3.Fill(dataTable3);
            dataTable3.Rows.Add("Select Parking");
            cbParkingSapce2.DataSource = dataTable3;
            cbParkingSapce2.DisplayMember = "id";
            cbParkingSapce2.ValueMember = "id";
            cbParkingSapce2.SelectedValue = "Select Parking";

            _connection.Close();
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvLease);
            row.Cells[0].Value = cbPaymentType.Text;
            row.Cells[1].Value = txtAmount.Text;
            row.Cells[2].Value = txtDescription.Text;
            dgvLease.Rows.Add(row);
            cbPaymentType.SelectedIndex = 0;
            txtAmount.Text = "";
            txtDescription.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String apartment = cbApartment.Text;
                String occupent = cbChiefOccupent.GetItemText(cbChiefOccupent.SelectedValue);
                String parking2 = cbParkingSapce2.Text;
                String start = dtpStart.Text;
                String end = dtpEnd.Text;

                int lastId;


                if (apartment == "" || occupent == "" || start == "" || end == "")
                {
                    MessageBox.Show("Please check values again");
                    return;
                }

                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();

                SqlCommand command1 = new SqlCommand("SELECT id FROM lease_aggrement ORDER BY id DESC", _connection);
                SqlDataReader reader = command1.ExecuteReader();
                if (reader.Read())
                {
                    lastId = reader.GetInt32(0);
                }
                else
                {
                    lastId = 1;
                }

                SqlConnection _connection1 = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection1.Open();
                SqlCommand command = new SqlCommand("INSERT INTO lease_aggrement( start_date, end_date, apartment_id, cheif_occupent_id) VALUES(@0, @1, @2, @3)", _connection1);
                command.Parameters.Add(new SqlParameter("0", SqlDbType.Date)).Value = start;
                command.Parameters.Add(new SqlParameter("1", SqlDbType.Date)).Value = end;
                command.Parameters.Add(new SqlParameter("2", apartment));
                command.Parameters.Add(new SqlParameter("3", occupent));
                command.ExecuteNonQuery();

                String oc = "Occupied";

                if (parking2 != "Select Parking")
                {

                    SqlCommand command3 = new SqlCommand("UPDATE parking_space set lease_aggrement_id='" + lastId++ + "', availability='Occupied' WHERE id='" + parking2 + "'", _connection1);
                    command3.ExecuteNonQuery();
                }
                lastId++;
                for (int i = 0; i < dgvLease.Rows.Count-1; i++)
                {
                    MessageBox.Show(dgvLease.Rows[i].Cells["type"].Value.ToString());
                    SqlCommand command4 = new SqlCommand("INSERT INTO payment( type, amount, description, date, lease_aggrement_id) VALUES(@0, @1, @2, @3, @4)", _connection1);
                    double amount = Double.Parse(dgvLease.Rows[i].Cells["Amount"].Value.ToString());
                    command4.Parameters.Add(new SqlParameter("0", dgvLease.Rows[i].Cells["type"].Value.ToString()));
                    command4.Parameters.Add(new SqlParameter("1", amount));
                    command4.Parameters.Add(new SqlParameter("2", dgvLease.Rows[i].Cells["Description"].Value.ToString()));
                    command4.Parameters.Add(new SqlParameter("3", SqlDbType.Date)).Value = DateTime.Now;
                    command4.Parameters.Add(new SqlParameter("4", lastId));
                    command4.ExecuteNonQuery();
                }

                _connection.Close();
                _connection1.Close();
                MessageBox.Show("Saved successfully..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
