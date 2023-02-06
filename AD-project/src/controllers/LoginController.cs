using AD_project.src.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_project.src.controllers
{
    public class LoginController
    {

        public LoginController() 
        {
        }


        public LoginModel checkLogin(LoginModel loginModel) 
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE user_name=@0 AND password=@1", _connection);
            command.Parameters.Add(new SqlParameter("0", loginModel.Username));
            command.Parameters.Add(new SqlParameter("1", loginModel.Password));
            LoginModel loginSuccessModel = new LoginModel();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    loginSuccessModel.Username = reader["user_name"].ToString();
                    loginSuccessModel.Role = reader["role"].ToString();
                    _connection.Close();
                }
            }
            return loginSuccessModel;
        }
    }
}
