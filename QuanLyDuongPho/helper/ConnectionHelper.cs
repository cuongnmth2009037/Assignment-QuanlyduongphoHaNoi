using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace QuanLyDuongPho.helper
{
    public class ConnectionHelper
    {
        private static MySqlConnection connection;

        public static MySqlConnection GetConnection()
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = new MySqlConnection();
                connection.ConnectionString = $"server=127.0.0.1;database=quanlyduongpho;UID=root;password=;port=3306";
                connection.Open();  
            }
            return connection;  
        }
    }
}
