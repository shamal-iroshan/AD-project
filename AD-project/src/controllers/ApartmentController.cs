using AD_project.src.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.controllers
{
    public class ApartmentController
    {
        public string getLastId()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("SELECT id FROM apartment ORDER BY id DESC", _connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                String tempID = reader.GetString(0);
                String[] split = tempID.Split('A');
                Int32 id = Int32.Parse(split[1]);
                id++;
                if (id < 10) return "A00" + id;
                else if (id < 100) return "A0" + id;
                else return "A" + id;
            }
            else
            {
                return "A001";
            }
        }

        public bool saveApartment(ApartmentModel model)
        {

            String newId = getLastId();
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO apartment(id, building_id, class_id, state, floor_area, monthly_rent, reservation_fee, refundable_deposit, max_oc_no) VALUES(@0, @1, @2, @3, @4, @5, @6, @7, @8)", _connection);
            command.Parameters.Add(new SqlParameter("0", newId));
            command.Parameters.Add(new SqlParameter("1", model.Building_id));
            command.Parameters.Add(new SqlParameter("2", model.Class_id));
            command.Parameters.Add(new SqlParameter("3", model.State));
            command.Parameters.Add(new SqlParameter("4", model.Floor_area));
            command.Parameters.Add(new SqlParameter("5", model.Monthly_rent));
            command.Parameters.Add(new SqlParameter("6", model.Reservation_fee));
            command.Parameters.Add(new SqlParameter("7", model.Refundable_deposit));
            command.Parameters.Add(new SqlParameter("8", model.Max_oc_no));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public SqlDataAdapter getAllApartments()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM apartment", _connection);
            _connection.Close();
            return command;
        }

        public bool updateApartment(ApartmentModel model)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("UPDATE apartment set building_id=@0, class_id=@1, state=@2, floor_area=@3, monthly_rent=@4, reservation_fee=@5, refundable_deposit=@6, max_oc_no=@7 WHERE id=@8", _connection);
            command.Parameters.Add(new SqlParameter("0", model.Building_id));
            command.Parameters.Add(new SqlParameter("1", model.Class_id));
            command.Parameters.Add(new SqlParameter("2", model.State));
            command.Parameters.Add(new SqlParameter("3", model.Floor_area));
            command.Parameters.Add(new SqlParameter("4", model.Monthly_rent));
            command.Parameters.Add(new SqlParameter("5", model.Reservation_fee));
            command.Parameters.Add(new SqlParameter("6", model.Refundable_deposit));
            command.Parameters.Add(new SqlParameter("7", model.Max_oc_no));
            command.Parameters.Add(new SqlParameter("8", model.Id));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public bool deleteApartment(String id)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM apartment WHERE id=@0", _connection);
            command.Parameters.Add(new SqlParameter("0", id));
            int rows = command.ExecuteNonQuery();
            _connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public SqlDataAdapter getAllApartmentClasses()
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM apartment_class", _connection);
            _connection.Close();
            return command;
        }
    }
}
