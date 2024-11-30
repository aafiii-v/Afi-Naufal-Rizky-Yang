using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.Controller
{
    internal class RoomsController : Model.Connection
    {
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

        public void TambahRoom(int noKamar, string tipeKamar, string statusKamar)
        {
            try
            {
                string query = "INSERT INTO kamar VALUES (@no_kamar, @tipe_kamar, @status_kamar)";
                MySqlCommand cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.Add("@no_kamar", MySqlDbType.Int64).Value = noKamar;
                cmd.Parameters.Add("@tipe_kamar", MySqlDbType.VarChar).Value = tipeKamar;
                cmd.Parameters.Add("@status_kamar", MySqlDbType.Enum).Value = statusKamar;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah kamar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateRoom(int noKamar, string tipeKamar, string statusKamar)
        {
            try
            {
                string query = "UPDATE kamar SET tipe_kamar = @tipe_kamar, status_kamar = @status_kamar WHERE no_kamar = @no_kamar";
                MySqlCommand cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.Add("@no_kamar", MySqlDbType.Int32).Value = noKamar;
                cmd.Parameters.Add("@tipe_kamar", MySqlDbType.VarChar).Value = tipeKamar;
                cmd.Parameters.Add("@status_kamar", MySqlDbType.Enum).Value = statusKamar;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate kamar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public int HitungTotalRoomsAvailable()
        {
            string query = "SELECT COUNT(*) FROM kamar WHERE status_kamar = 'Tersedia'";
            try
            {
                using (var conn = GetConn())
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
                            MessageBox.Show("Data kamar tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error menghitung jumlah kamar tersedia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
