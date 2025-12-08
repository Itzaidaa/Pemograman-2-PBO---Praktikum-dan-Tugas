using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P9_714240046 
{
    internal class koneksi
    {
        private MySqlConnection connection;

        string connectionString = "Server=localhost;Database=pemrog2ulbi;Uid=root;Pwd=;";

        public void OpenConn()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConn()
        {
            connection.Close();
        }

        public MySqlConnection GetConn()
        {
            return connection;
        }
    }
}