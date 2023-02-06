using AD_project.src.models;
using AD_project.src.views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_project.src.controllers
{
    public class ApartmnetClassController
    {

        public SqlDataAdapter getAllClasses()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM apartment_class", _connection);
            _connection.Close();
            return command;
        }

        public bool saveClass(ApartmentClassModel model)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO apartment_class VALUES(@0, @1)", _connection);
            command.Parameters.Add(new SqlParameter("0", model.Title));
            command.Parameters.Add(new SqlParameter("1", model.Description));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

       public bool updateClass(ApartmentClassModel model)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("UPDATE apartment_class set title=@0, description=@! WHERE id=@2", _connection);
            command.Parameters.Add(new SqlParameter("0", model.Title));
            command.Parameters.Add(new SqlParameter("1", model.Description));
            command.Parameters.Add(new SqlParameter("2", model.Id));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public bool deleteClass(string id)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM apartment_class WHERE id=@0", _connection);
            command.Parameters.Add(new SqlParameter("0", id));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }
    }
}
