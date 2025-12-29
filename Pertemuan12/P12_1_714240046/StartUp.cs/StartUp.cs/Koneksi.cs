using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_714240046
{
    class Koneksi
    {
        private MySqlConnection kon;

        public Koneksi()
        {
            string connString = "server=localhost;database=p12_db;uid=root;pwd=;";
            kon = new MySqlConnection(connString);
        }

        public void OpenConnection()
        {
            if (kon.State == System.Data.ConnectionState.Closed)
                kon.Open();
        }

        public void CloseConnection()
        {
            if (kon.State == System.Data.ConnectionState.Open)
                kon.Close();
        }

        public MySqlDataReader reader(string query, MySqlParameter[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query, kon);
            cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteReader();
        }
    }
}
