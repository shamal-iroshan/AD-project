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
    public partial class Dependants : Form
    {
        public Dependants()
        {
            InitializeComponent();
        }

        private void Dependants_Load(object sender, EventArgs e)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM chief_occupant", _connection);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            cbChief.DataSource = dataTable1;
            cbChief.DisplayMember = "name";
            cbChief.ValueMember = "id";
        }

        private void cbChief_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbChief_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string chiefId = cbChief.GetItemText(cbChief.SelectedValue);
                if (chiefId != "")
                {
                    int id = Int32.Parse(chiefId);
                    SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                    _connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM dependant WHERE cheif_occupent_id='" + id + "'", _connection);
                    _connection.Close();
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvDependant.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int chiefId = Int32.Parse(cbChief.GetItemText(cbChief.SelectedValue));
            string contact = txtContact.Text;
            string relation = cbRelationShip.Text;
            if (name == "" || contact == "" || relation == "" || chiefId == 0)
            {
                MessageBox.Show("Please check values again");
                return;
            }
            try
            {
                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO dependant(name, relationship,contact, cheif_occupent_id) VALUES(@0, @1, @2, @3)", _connection);
                command.Parameters.Add(new SqlParameter("0", name));
                command.Parameters.Add(new SqlParameter("1", relation));
                command.Parameters.Add(new SqlParameter("2", contact));
                command.Parameters.Add(new SqlParameter("3", chiefId));
                int rows = command.ExecuteNonQuery();
                _connection.Close();
                if (rows > 0)
                {
                    txtName.Text = "";
                    txtContact.Text = "";
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
