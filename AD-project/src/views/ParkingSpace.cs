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
        Main main;

        public ParkingSpace(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        public string getLastId()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("SELECT id FROM parking_space ORDER BY id DESC", _connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                String tempID = reader.GetString(0);
                String[] split = tempID.Split('P');
                Int32 id = Int32.Parse(split[1]);
                id++;
                if (id < 10) return "P00" + id;
                else if (id < 100) return "P0" + id;
                else return "P" + id;
            }
            else
            {
                return "P001";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.loadForm(new Apartment(main));
        }

        private void ParkingSpace_Load(object sender, EventArgs e)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM parking_space", _connection);
            _connection.Close();
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

                if (fee == 0 || availability == "")
                {
                    MessageBox.Show("Please check values again");
                    return;
                }

                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO parking_space(id, fee, availability) VALUES(@0, @1, @2)", _connection);
                command.Parameters.Add(new SqlParameter("0", getLastId()));
                command.Parameters.Add(new SqlParameter("1", fee));
                command.Parameters.Add(new SqlParameter("1", availability));
                int rows = command.ExecuteNonQuery();
                _connection.Close();
                if (rows > 0)
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
    }
}
