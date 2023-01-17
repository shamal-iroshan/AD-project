﻿using AD_project.src.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.controllers
{
    public class LoginController
    {

        public LoginController() 
        {
        }


        public Boolean checkLogin(LoginModel loginModel) 
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            _connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE user_name=@0 AND password=@1", _connection);
            command.Parameters.Add(new SqlParameter("0", loginModel.Username));
            command.Parameters.Add(new SqlParameter("1", loginModel.Password));
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            _connection.Close();
            int count = dataSet.Tables[0].Rows.Count;
            if (count == 1 )
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
