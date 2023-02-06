using AD_project.src.models;
using AD_project.src.views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_project.src.controllers
{
    public class BuildingController
    {
        SqlConnection _connection;

        public BuildingController()
        {
        }

        public string getLastId()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("SELECT id FROM building ORDER BY id DESC", _connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                String tempID = reader.GetString(0);
                String[] split = tempID.Split('B');
                Int32 id = Int32.Parse(split[1]);
                id++;
                if (id < 10) return "B00" + id;
                else if (id < 100) return "B0" + id;
                else return "B" + id;
            } else
            {
                return "B001";
            }
        }

        public bool saveBuilding(BuildingModel building)
        {

            String newId = getLastId();
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO building VALUES(@0, @1)", _connection);
            command.Parameters.Add(new SqlParameter("0", newId));
            command.Parameters.Add(new SqlParameter("1", building.Location));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public SqlDataAdapter getAllBuildings()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM building", _connection);
            _connection.Close();
            return command;
        }

        public bool updateBuilding(BuildingModel model)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("UPDATE building set location=@0 WHERE id=@1", _connection);
            command.Parameters.Add(new SqlParameter("0", model.Location));
            command.Parameters.Add(new SqlParameter("1", model.Id));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public bool deleteBuilding(String id) 
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM building WHERE id=@0", _connection);
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
