using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD_project.src.db
{
    public class DBConnection
    {
        private static DBConnection instance;
        private SqlConnection connection;

        public DBConnection()
        {
            connection = new SqlConnection("Data Source=DESKTOP-QD5TKKH;Initial Catalog=E-Apartments;Integrated Security=True");
            connection.Open();
        }

        public static DBConnection getInstance()
        {
            if (instance == null)
            {
                return instance= new DBConnection();
            } else 
            {
                return instance; 
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
