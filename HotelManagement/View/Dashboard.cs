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
        private Timer refreshTimer;
        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateLabels();
                refreshTimer = new Timer();
                refreshTimer.Interval = 5000;
                refreshTimer.Tick += RefreshTimer_Tick;
                refreshTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            UpdateLabels();
        }
        private void UpdateLabels()
        {
            try
            {
                LabelAngkaTotalAdmin.Text = AdminConroller.HitungTotalAdmin().ToString();
                LabelAngkaAvailebleRooms.Text = RoomsController.HitungTotalRoomsAvailable().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
