using HotelManagement.Controller;
using System;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class Dashboard : UserControl
    {
        LoginController AdminConroller;
        RoomsController RoomsController;
        public Dashboard()
        {
            InitializeComponent();
            AdminConroller = new LoginController();
            RoomsController = new RoomsController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                LabelAngkaTotalAdmin.Text = AdminConroller.HitungTotalAdmin().ToString();
                LabelAngkaAvailebleRooms.Text = RoomsController.HitungTotalRoomsAvailable().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
