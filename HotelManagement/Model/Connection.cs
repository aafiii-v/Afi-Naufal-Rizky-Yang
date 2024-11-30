using MySqlConnector;
using System;
using System.Windows.Forms;

namespace HotelManagement.Model
{
    internal class Connection
    {
        public MySqlDataAdapter da;

        public MySqlConnection GetConn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=hotel_system";
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed " + ex.Message);
                return null;
            }
        }
    }
}
