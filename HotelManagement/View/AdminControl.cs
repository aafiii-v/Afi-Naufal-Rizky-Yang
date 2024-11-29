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

namespace HotelManagement.View
{
    public partial class AdminControl : UserControl
    {
        private LoginController logincontrol;

        public AdminControl()
        {
            logincontrol = new LoginController();
            InitializeComponent();
        }
        private void AdminControl_Load(object sender, EventArgs e)
        {
            ShowTable();
        }
        public void ShowTable()
        {   
            GridviewDataAdmin.DataSource = logincontrol.TampilAccount(new MySqlCommand("SELECT * FROM admin"));
            GridviewDataAdmin.Columns[0].Width = 350;
            GridviewDataAdmin.Columns[1].Width = 370;
        }
        private void BtnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "")
            {
                MessageBox.Show("Please select the account you want to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        logincontrol.DeleteAccount(TextBoxUsername.Text);
                        ShowTable();
                        BtnClearAdmin_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to delete data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void BtnClearAdmin_Click(object sender, EventArgs e)
        {
            TextBoxUsername.Text = "";
            TextBoxPassword.Text = "";
        }
        private void GridviewDataAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxUsername.Text = GridviewDataAdmin.CurrentRow.Cells[0].Value.ToString();
            TextBoxPassword.Text = GridviewDataAdmin.CurrentRow.Cells[1].Value.ToString();
        }

        private void LabelCloseDataAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
