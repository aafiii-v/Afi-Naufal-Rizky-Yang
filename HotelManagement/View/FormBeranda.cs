using System;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class FormBeranda : Form
    {
        public FormBeranda()
        {
            InitializeComponent();
            Pemesanan.DataPemesananChanged += Customers.ShowTable;
            Pemesanan.DataPemesananChanged += AdminRooms.ShowTable;
        }
        private void Hideit()
        {
            AdminControl.Hide();
            AdminRooms.Hide();
            Customers.Hide();
            Pemesanan.Hide();
        }
        private void FormBeranda_Load(object sender, EventArgs e)
        {
            Hideit();
        }
        private void LabelCloseApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void BtnLogoutBeranda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out of your account?", "Konfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin login  = new FormLogin();
                login.Show();
                this.Hide();
            }
        }
        private void BtnAdminControl_Click(object sender, EventArgs e)
        {
            Hideit();
            AdminControl.Show();
        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Hideit();
            Dashboard.Show();
        }
        private void BtnRooms_Click_1(object sender, EventArgs e)
        {
            Hideit();
            AdminRooms.Show();
        }
        private void BtnPemesanan_Click(object sender, EventArgs e)
        {
            Hideit();
            Pemesanan.Show();
        }
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            Hideit();
            Customers.Show();
        }
    }
}