using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace P12_714240046
{
    class CekLogin
    {
        Koneksi koneksi = new Koneksi();

        public bool cek_login(string username, string password)
        {
            MySqlDataReader dr = null;

            try
            {
                koneksi.OpenConnection();
                string query = "SELECT 1 FROM t_user WHERE username=@username AND password=@password LIMIT 1";

                MySqlParameter[] param = new MySqlParameter[]
                {
                    new MySqlParameter("@username", username),
                    new MySqlParameter("@password", password)
                };

                dr = koneksi.reader(query, param);
                return dr.Read(); // true kalau data ada
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (dr != null && !dr.IsClosed) dr.Close();
                koneksi.CloseConnection();
            }
        }
    }
}
