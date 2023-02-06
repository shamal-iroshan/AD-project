using AD_project.src.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AD_project.src.views
{
    public partial class WaitingList : Form
    {
        public WaitingList()
        {
            InitializeComponent();
        }

        private void WaitingList_Load(object sender, EventArgs e)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM waiting_list", _connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvWaitingList.DataSource = dataTable;

            SqlDataAdapter adapter2 = new SqlDataAdapter("SELECT * FROM apartment", _connection);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            cbApartment.DataSource = dataTable2;
            cbApartment.DisplayMember = "id";
            cbApartment.ValueMember = "id";

            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM chief_occupant", _connection);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            cbChiefOccupent.DataSource = dataTable1;
            cbChiefOccupent.DisplayMember = "name";
            cbChiefOccupent.ValueMember = "id";

            _connection.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String apartment = cbApartment.Text;
            String occupent = cbChiefOccupent.GetItemText(cbChiefOccupent.SelectedValue);
            String start = dtpStart.Text;
            String end = dtpEnd.Text;
            int order = Int32.Parse(txtOrder.Text);

            if(apartment == "" || occupent == "" || start == "" || end == "" || order == 0) 
            {
                MessageBox.Show("Please check values again");
                return;
            }
            try
            {
                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO waiting_list(chief_occupent_id, apartmrnt_id, start_date, end_date, order) VALUES(@0, @1, @2, @3, @4)", _connection);
                command.Parameters.Add(new SqlParameter("1", occupent));
                command.Parameters.Add(new SqlParameter("0", apartment));
                command.Parameters.Add(new SqlParameter("2", start));
                command.Parameters.Add(new SqlParameter("3", end));
                command.Parameters.Add(new SqlParameter("4", order));
                int rows = command.ExecuteNonQuery();
                _connection.Close();
                if (rows > 0)
                {
                    txtOrder.Text = "";
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
