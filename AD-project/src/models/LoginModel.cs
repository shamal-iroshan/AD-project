﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.models
{
    public class LoginModel
    {
        private string username;
        private string password;

        public LoginModel()
        {
        }

        public LoginModel(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

    }
}
