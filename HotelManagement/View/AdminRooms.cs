using HotelManagement.Controller;
using MySqlConnector;
using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class AdminRooms : UserControl
    {
        RoomsController roomsController;
        public AdminRooms()
        {
            InitializeComponent();
            roomsController = new RoomsController();
        }
        public void ShowTable()
        {
            GridviewDataRooms.DataSource = roomsController.ShowRooms(new MySqlCommand("SELECT * FROM kamar"));
            GridviewDataRooms.Columns[0].Width = 150;
            GridviewDataRooms.Columns[1].Width = 450;
            GridviewDataRooms.Columns[2].Width = 360;
        }
        private void AdminRooms_Load(object sender, EventArgs e)
        {
            ShowTable();
        }
        private void GridviewDataRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxNoRoom.Text = GridviewDataRooms.CurrentRow.Cells[0].Value.ToString();
            TextBoxTypeRoom.Text = GridviewDataRooms.CurrentRow.Cells[1].Value.ToString();
            ComboBoxStatusRoom.Text = GridviewDataRooms.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnClearRoom_Click(object sender, EventArgs e)
        {
            TextBoxNoRoom.Text = "";
            TextBoxTypeRoom.Text = "";
            ComboBoxStatusRoom.SelectedIndex = -1;
        }
        
        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            if (TextBoxTypeRoom.Text == "" || ComboBoxStatusRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Harap isi semua kolom untuk menambah kamar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int noKamar = int.Parse(TextBoxNoRoom.Text);
                    string tipeKamar = TextBoxTypeRoom.Text;
                    string statusKamar = ComboBoxStatusRoom.Text;

                    roomsController.TambahRoom(noKamar, tipeKamar, statusKamar);
                    ShowTable();
                    BtnClearRoom_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Add room Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
