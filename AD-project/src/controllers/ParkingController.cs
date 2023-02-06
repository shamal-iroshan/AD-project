using AD_project.src.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.controllers
{
    public class ParkingController
    {
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

        public bool saveParkingSpace(ParkingSpaceModel model)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO parking_space(id, fee, availability, apartment_id) VALUES(@0, @1, @2, @3)", _connection);
            command.Parameters.Add(new SqlParameter("0", getLastId()));
            command.Parameters.Add(new SqlParameter("1", model.Fee));
            command.Parameters.Add(new SqlParameter("2", model.Availability));
            command.Parameters.Add(new SqlParameter("2", model.ApartmentId));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public bool updateParkingSpace(ParkingSpaceModel model)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("UPDATE parking_space set fee=@0, availability=@1, apartment_id=@2 WHERE id=@3", _connection);
            command.Parameters.Add(new SqlParameter("0", model.Fee));
            command.Parameters.Add(new SqlParameter("1", model.Availability));
            command.Parameters.Add(new SqlParameter("2", model.ApartmentId));
            command.Parameters.Add(new SqlParameter("3", model.Id));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public bool deleteParkingSpace(string id)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM parking_space WHERE id=@0", _connection);
            command.Parameters.Add(new SqlParameter("0", id));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public SqlDataAdapter getAllParking()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM parking_space", _connection);
            _connection.Close();
            return command;
        }
    }
}
