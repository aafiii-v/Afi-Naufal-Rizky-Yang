using HotelManagement.Model;
using HotelManagement.View;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.Controller
{
    internal class LoginController : Connection
    {
        public DataTable GetList(MySqlCommand command)
        {
            DataTable table = new DataTable();
            using (MySqlConnection conn = GetConn())
            {
                try
                {
                    command.Connection = conn;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return table;
        }

        public void AddAccount(string username, string password)
        {
            string query = "INSERT INTO admin (username, passwordd) VALUES (@username, @passwordd)";
            try
            {
                using (var conn = GetConn())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@passwordd", MySqlDbType.VarChar).Value = password;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Add Account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable TampilAccount(MySqlCommand command)
        {
            DataTable data = new DataTable();
            string query = "SELECT * FROM admin";
            using (var conn = GetConn())
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
            return data;
        }

        public void DeleteAccount(string username)
        {
            string deleteQuery = "DELETE FROM admin WHERE username = @username";

            using (MySqlConnection conn = GetConn())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Account not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int HitungTotalAdmin()
        {
            string query = "SELECT COUNT(*) FROM admin";
            try
            {
                using(var conn = GetConn())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    using (var command = new MySqlCommand(query, conn))
                    {
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Data not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
