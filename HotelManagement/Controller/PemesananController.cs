using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.Controller
{
    internal class PemesananController : Model.Connection
    {
        public DataTable ShowPemesanan()
        {
            DataTable pemesanan = new DataTable();
            string query = @"SELECT p.kode_pemesanan AS 'Kode Pemesanan',
            p.waktu_masuk AS 'Waktu Masuk',
            p.waktu_keluar AS 'Waktu Keluar',
            t.kode_tamu AS 'Kode Tamu',
            t.nama_tamu AS 'Nama Tamu',
            t.no_hp AS 'No HP',
            k.no_kamar AS 'No Kamar',
            k.tipe_kamar AS 'Tipe Kamar',
            k.status_kamar AS 'Status Kamar'
            FROM pemesanan p
            JOIN tamu t ON p.kode_pemesanan = t.kode_pemesanan
            JOIN kamar k ON p.no_kamar = k.no_kamar";

            using (var conn = GetConn())
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(pemesanan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Fetching Data: " + ex.Message);
                }
            }
            return pemesanan;
        }

        public void AddPemesanan(DateTime waktuMasuk, DateTime waktuKeluar, string namaTamu, string noHp, string noKamar)
        {
            try
            {
                string checkQuery = "SELECT COUNT(*) FROM pemesanan WHERE no_kamar = @no_kamar AND waktu_keluar > @waktu_masuk";

                string insertQuery = @"INSERT INTO pemesanan (no_kamar, waktu_masuk, waktu_keluar) VALUES (@no_kamar, @waktu_masuk, @waktu_keluar);
                INSERT INTO tamu (nama_tamu, no_hp, no_kamar, kode_pemesanan) VALUES (@nama_tamu, @no_hp, @no_kamar, 
                (SELECT kode_pemesanan FROM pemesanan WHERE no_kamar = @no_kamar AND waktu_masuk = @waktu_masuk LIMIT 1)); ";

                using (var conn = GetConn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@no_kamar", noKamar);
                        checkCmd.Parameters.AddWithValue("@waktu_masuk", waktuMasuk);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Kamar ini sudah digunakan oleh tamu lain. Silakan pilih kamar lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@waktu_masuk", waktuMasuk);
                        insertCmd.Parameters.AddWithValue("@waktu_keluar", waktuKeluar);
                        insertCmd.Parameters.AddWithValue("@nama_tamu", namaTamu);
                        insertCmd.Parameters.AddWithValue("@no_hp", noHp);
                        insertCmd.Parameters.AddWithValue("@no_kamar", noKamar);

                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Pemesanan berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Kamar Tidak Tersedia, Silahkan Cek kembali inputan Anda: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        public void UpdatePemesanan(string kodePemesanan, DateTime waktuMasuk, DateTime waktuKeluar, string namaTamu, string noHp, string noKamar)
        {
            string queryPemesanan = "UPDATE pemesanan SET waktu_masuk = @waktu_masuk, waktu_keluar = @waktu_keluar WHERE kode_pemesanan = @kode_pemesanan";
            string queryTamu = "UPDATE tamu SET nama_tamu = @nama_tamu, no_hp = @no_hp WHERE kode_pemesanan = @kode_pemesanan";

            using (var conn = GetConn())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    using (var cmdPemesanan = new MySqlCommand(queryPemesanan, conn))
                    {
                        cmdPemesanan.Parameters.AddWithValue("@kode_pemesanan", kodePemesanan);
                        cmdPemesanan.Parameters.AddWithValue("@waktu_masuk", waktuMasuk);
                        cmdPemesanan.Parameters.AddWithValue("@waktu_keluar", waktuKeluar);

                        int rowsAffectedPemesanan = cmdPemesanan.ExecuteNonQuery();
                        if (rowsAffectedPemesanan == 0)
                        {
                            MessageBox.Show("Data pemesanan tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    using (var cmdTamu = new MySqlCommand(queryTamu, conn))
                    {
                        cmdTamu.Parameters.AddWithValue("@kode_pemesanan", kodePemesanan);
                        cmdTamu.Parameters.AddWithValue("@nama_tamu", namaTamu);
                        cmdTamu.Parameters.AddWithValue("@no_hp", noHp);

                        cmdTamu.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kesalahan saat memperbarui data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public void DeletePemesanan(string kodePemesanan)
        {
            try
            {
                string deleteTamuQuery = "DELETE FROM tamu WHERE kode_pemesanan = @kode_pemesanan";
                string updateKamarQuery = "UPDATE kamar SET status_kamar = 'Tersedia' WHERE no_kamar = (SELECT no_kamar FROM pemesanan WHERE kode_pemesanan = @kode_pemesanan)";
                string deletePemesananQuery = "DELETE FROM pemesanan WHERE kode_pemesanan = @kode_pemesanan";

                using (var conn = GetConn())
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    using (var cmdTamu = new MySqlCommand(deleteTamuQuery, conn))
                    {
                        cmdTamu.Parameters.AddWithValue("@kode_pemesanan", kodePemesanan);
                        cmdTamu.ExecuteNonQuery();
                    }
                    using (var cmdKamar = new MySqlCommand(updateKamarQuery, conn))
                    {
                        cmdKamar.Parameters.AddWithValue("@kode_pemesanan", kodePemesanan);
                        cmdKamar.ExecuteNonQuery();
                    }

                    using (var cmdPemesanan = new MySqlCommand(deletePemesananQuery, conn))
                    {
                        cmdPemesanan.Parameters.AddWithValue("@kode_pemesanan", kodePemesanan);
                        int rowsAffected = cmdPemesanan.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pemesanan beserta data tamu berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data pemesanan tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan saat menghapus data pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public bool CekKamarTerpakai(string noKamar)
        {
            bool isTerpakai = false;
            string query = "SELECT COUNT(*) FROM pemesanan WHERE no_kamar = @no_kamar AND waktu_keluar >= NOW()";

            using (var conn = GetConn())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@no_kamar", noKamar);
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isTerpakai = (count > 0);
                }
            }
            return isTerpakai;
        }
    }
}
