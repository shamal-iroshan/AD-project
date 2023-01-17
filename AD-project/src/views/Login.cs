using AD_project.src.controllers;
using AD_project.src.db;
using AD_project.src.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SqlConnection _connection = DBConnection.getInstance().GetConnection();
            _connection.Close();
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginModel model= new LoginModel(txtUserName.Text, txtPassword.Text);
            if (model.Username == "" || model.Password == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                Boolean loginSuccess = new LoginController().checkLogin(model);
                if (loginSuccess)
                {
                    MessageBox.Show("Login success");
                } else
                {
                    MessageBox.Show("Login failed");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
