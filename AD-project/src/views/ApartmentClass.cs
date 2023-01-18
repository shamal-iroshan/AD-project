using AD_project.src.controllers;
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
        Main main;
        String currentlyOperating;

        public ApartmentClass(Main main)
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
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM apartment_class", _connection);
            _connection.Close();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvClasses.DataSource = dataTable;
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
            try
            {
                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO apartment_class(title, description) VALUES(@0, @1)", _connection);
                command.Parameters.Add(new SqlParameter("0", title));
                command.Parameters.Add(new SqlParameter("1", description));
                int rows = command.ExecuteNonQuery();
                _connection.Close();
                if (rows > 0)
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

            try
            {
                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlCommand command = new SqlCommand("UPDATE apartment_class set title=@0, description=@1 WHERE id=@2", _connection);
                command.Parameters.Add(new SqlParameter("0", title));
                command.Parameters.Add(new SqlParameter("1", description));
                command.Parameters.Add(new SqlParameter("2", currentlyOperating));
                command.ExecuteReader();
                _connection.Close();
                txtTitle.Text = "";
                txtDescription.Text = "";
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
                SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
                _connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM apartment_class WHERE id=@0", _connection);
                command.Parameters.Add(new SqlParameter("0", currentlyOperating));
                command.ExecuteReader();
                _connection.Close();
                txtTitle.Text = "";
                txtDescription.Text = "";
                MessageBox.Show("Deleted successfully..!");
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
