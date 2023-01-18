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
    public partial class ChiefOccupent : Form
    {
        public ChiefOccupent()
        {
            InitializeComponent();
        }

        private void ChiefOccupent_Load(object sender, EventArgs e)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM chief_occupant", _connection);
            _connection.Close();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvChiefOccupent.DataSource = dataTable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string idType = cbIdType.Text;
            string EmergencyContact = txtContact.Text;
            string idNo = txtIdNo.Text;
            if (name == "" || address == "" || idNo == "" || idType == "" || EmergencyContact == "")
            {
                MessageBox.Show("Please check values again");
                return;
            }
            try
            {
                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO chief_occupant(name, address, id_type, id_no, emergency_contact) VALUES(@0, @1, @2, @3, @4)", _connection);
                command.Parameters.Add(new SqlParameter("0", name));
                command.Parameters.Add(new SqlParameter("1", address));
                command.Parameters.Add(new SqlParameter("2", idType));
                command.Parameters.Add(new SqlParameter("3", idNo));
                command.Parameters.Add(new SqlParameter("4", EmergencyContact));
                int rows = command.ExecuteNonQuery();
                _connection.Close();
                if (rows > 0)
                {
                    txtAddress.Text = "";
                    txtName.Text = "";
                    txtContact.Text = "";
                    txtIdNo.Text = "";
                    cbIdType.Text = "";
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
    }
}
