using HotelManagement.Controller;
using System;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class TxtBoxKodePemesanan : UserControl
    {
        PemesananController pemesananController;
        public event Action DataPemesananChanged;

        public TxtBoxKodePemesanan()
        {
            InitializeComponent();
            pemesananController = new PemesananController();
        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        public void ShowTable()
        {
            DGV_Pemesanan.DataSource = pemesananController.ShowPemesanan();
            DGV_Pemesanan.Columns[0].Width = 95;
            DGV_Pemesanan.Columns[1].Width = 150;
            DGV_Pemesanan.Columns[2].Width = 150;
            DGV_Pemesanan.Columns[3].Width = 90;
            DGV_Pemesanan.Columns[4].Width = 190;
            DGV_Pemesanan.Columns[5].Width = 110;
            DGV_Pemesanan.Columns[6].Width = 90;
            DGV_Pemesanan.Columns[7].Width = 90;
            DGV_Pemesanan.Columns[8].Width = 90;
        }

        private void DGV_Pemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxKodePemesanan.Text = DGV_Pemesanan.CurrentRow.Cells[0].Value.ToString();
            DateTimePicker_masuk.Value = Convert.ToDateTime(DGV_Pemesanan.CurrentRow.Cells[1].Value);
            DateTimePicker_keluar.Value = Convert.ToDateTime(DGV_Pemesanan.CurrentRow.Cells[2].Value);
            TxtBoxKodeTamu.Text = DGV_Pemesanan.CurrentRow.Cells[3].Value.ToString();
            TextBoxNamaTamu.Text = DGV_Pemesanan.CurrentRow.Cells[4].Value.ToString();
            TxtBoxNoHp.Text = DGV_Pemesanan.CurrentRow.Cells[5].Value.ToString();
            TxtBoxNoKamar.Text = DGV_Pemesanan.CurrentRow.Cells[6].Value.ToString();
            TxtBoxTipeRoom.Text = DGV_Pemesanan.CurrentRow.Cells[7].Value.ToString();
            TxtBoxStatusRoom.Text = DGV_Pemesanan.CurrentRow.Cells[8].Value.ToString();
            
        }

        private void BtnClearPemesanan_Click(object sender, EventArgs e)
        {
            TextBoxKodePemesanan.Text = "";
            DateTimePicker_masuk.Value = DateTime.Now;
            DateTimePicker_keluar.Value = DateTime.Now;
            TxtBoxKodeTamu.Text = "";
            TextBoxNamaTamu.Text = "";
            TxtBoxNoHp.Text = "";
            TxtBoxNoKamar.Text = "";
            TxtBoxTipeRoom.Text = "";
            TxtBoxStatusRoom.Text = "";
        }

        private void BtnDeletePemesanan_Click(object sender, EventArgs e)
        {
            string kodePemesanan = TextBoxKodePemesanan.Text.Trim();
            if (string.IsNullOrEmpty(kodePemesanan))
            {
                MessageBox.Show("Pilih pemesanan yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus pemesanan ini beserta data tamu?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    pemesananController.DeletePemesanan(kodePemesanan);
                    
                    ShowTable(); 
                    BtnClearPemesanan_Click(sender, e); 
                    DataPemesananChanged?.Invoke();
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("Kesalahan saat menghapus data pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnAddPemesanan_Click(object sender, EventArgs e)
        {
            DateTime waktuMasuk = DateTimePicker_masuk.Value;
            DateTime waktuKeluar = DateTimePicker_keluar.Value;
            string namaTamu = TextBoxNamaTamu.Text.Trim();
            string noHp = TxtBoxNoHp.Text.Trim();
            string noKamar = TxtBoxNoKamar.Text.Trim();

            if (string.IsNullOrEmpty(namaTamu) || string.IsNullOrEmpty(noHp) || string.IsNullOrEmpty(noKamar))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (waktuMasuk >= waktuKeluar)
            {
                MessageBox.Show("Waktu keluar harus lebih besar dari waktu masuk!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pemesananController.CekKamarTerpakai(noKamar))
            {
                MessageBox.Show("Nomor kamar sudah digunakan! Silakan pilih nomor kamar yang lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                pemesananController.AddPemesanan(waktuMasuk, waktuKeluar, namaTamu, noHp, noKamar);

                ShowTable();
                BtnClearPemesanan_Click(sender, e);
                DataPemesananChanged?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdatePemesanan_Click(object sender, EventArgs e)
        {
            string kodePemesanan = TextBoxKodePemesanan.Text.Trim();
            DateTime waktuMasuk = DateTimePicker_masuk.Value;
            DateTime waktuKeluar = DateTimePicker_keluar.Value;
            string namaTamu = TextBoxNamaTamu.Text.Trim();
            string noHp = TxtBoxNoHp.Text.Trim();
            string noKamar = TxtBoxNoKamar.Text.Trim();

            if (string.IsNullOrEmpty(kodePemesanan) || string.IsNullOrEmpty(namaTamu) || string.IsNullOrEmpty(noHp) || string.IsNullOrEmpty(noKamar))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (waktuMasuk >= waktuKeluar)
            {
                MessageBox.Show("Waktu keluar harus lebih besar dari waktu masuk!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pemesananController.CekKamarTerpakai(noKamar) && noKamar != DGV_Pemesanan.CurrentRow.Cells[6].Value.ToString())
            {
                MessageBox.Show("Nomor kamar sudah digunakan! Silakan pilih nomor kamar yang lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                pemesananController.UpdatePemesanan(kodePemesanan, waktuMasuk, waktuKeluar, namaTamu, noHp, noKamar);

                ShowTable();
                BtnClearPemesanan_Click(sender, e);
                DataPemesananChanged?.Invoke();

                MessageBox.Show("Data pemesanan berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kesalahan saat memperbarui pemesanan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

