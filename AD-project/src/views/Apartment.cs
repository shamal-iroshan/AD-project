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
            main.loadForm(new ParkingSpace(main));
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
                _connection.Close();
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                //dataTable1.Rows.Add("Select Class");
                cbClass.DataSource = dataTable1;
                cbClass.DisplayMember = "title";
                cbClass.ValueMember = "id";
                //cbClass.SelectedValue = "Select Class";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
