using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.Controller
{
    internal class CustomerController : Model.Connection
    {
        public DataTable ShowCustomers()
        {
            DataTable customers = new DataTable();
            string query = "SELECT * FROM tamu";

            using (var conn = GetConn())
            {
                try
                {
                    da = new MySqlDataAdapter(query, conn);
                    da.Fill(customers);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Fetching Data: " + ex.Message);
                }
            }
            return customers;
        }
    }
}
