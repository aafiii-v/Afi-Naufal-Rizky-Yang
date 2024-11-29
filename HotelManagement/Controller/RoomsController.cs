using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagement.Controller
{
    internal class RoomsController : Model.Connection
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
        public  DataTable ShowRooms(MySqlCommand command)
        {
            DataTable rooms = new DataTable();
            string query = "SELECT * FROM kamar";
            using (var conn = GetConn())
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(rooms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
            return rooms;
        }

        public void DeleteRoom(string no_kamar)
        {
            string deleteQuery = "DELETE FROM kamar WHERE no_kamar = @no_kamar";

            using (MySqlConnection conn = GetConn())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.Add("@no_kamar", MySqlDbType.VarChar).Value = no_kamar;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Room not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete Room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
