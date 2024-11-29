using HotelManagement.Controller;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void LabelCloseDataRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void AdminRooms_Load(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void BtnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (TextBoxIdRoom.Text == "")
            {
                MessageBox.Show("Please select the room you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        roomsController.DeleteRoom(TextBoxIdRoom.Text);
                        ShowTable();
                        BtnClearRoom_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete Room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GridviewDataRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxIdRoom.Text = GridviewDataRooms.CurrentRow.Cells[0].Value.ToString();
            TextBoxTypeRoom.Text = GridviewDataRooms.CurrentRow.Cells[1].Value.ToString();
            ComboBoxStatusRoom.Text = GridviewDataRooms.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnClearRoom_Click(object sender, EventArgs e)
        {
            TextBoxIdRoom.Text = "";
            TextBoxTypeRoom.Text = "";
            ComboBoxStatusRoom.SelectedIndex = -1;
        }
    }
}
