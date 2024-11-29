using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class FormBeranda : Form
    {
        public FormBeranda()
        {
            InitializeComponent();
        }
        private void Hideit()
        {
            Dashboard.Hide();
            AdminControl.Hide();
            AdminRooms.Hide();
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
        private void FormBeranda_Load(object sender, EventArgs e)
        {
            Hideit();
        }
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Hideit();
            Dashboard.Show();
        }
        private void BtnRooms_Click(object sender, EventArgs e)
        {
            Hideit();
            AdminRooms.Show();
        }
    }
}