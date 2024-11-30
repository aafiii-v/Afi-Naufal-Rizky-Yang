using HotelManagement.Controller;
using System;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class Customers : UserControl
    {
        CustomerController customerController;
        public Customers()
        {
            InitializeComponent();
            customerController = new CustomerController();
        }

        public void ShowTable()
        {
            GridviewDataTamu.DataSource = customerController.ShowCustomers();
            GridviewDataTamu.Columns[0].Width = 130;
            GridviewDataTamu.Columns[1].Width = 130;
            GridviewDataTamu.Columns[2].Width = 270;
            GridviewDataTamu.Columns[3].Width = 260;
            GridviewDataTamu.Columns[4].Width = 170;
        }
        private void Customers_Load(object sender, EventArgs e)
        {
            ShowTable();
        }
        private void GridviewDataTamu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxKodeTamu.Text = GridviewDataTamu.CurrentRow.Cells[0].Value.ToString();
            TxtBoxNoKamar.Text = GridviewDataTamu.CurrentRow.Cells[1].Value.ToString();
            TextBoxNamaTamu.Text = GridviewDataTamu.CurrentRow.Cells[2].Value.ToString();
            TextBoxNoHp.Text = GridviewDataTamu.CurrentRow.Cells[3].Value.ToString();
            TxtBoxKodePemesanan.Text = GridviewDataTamu.CurrentRow.Cells[4].ToString();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxKodeTamu.Text     = "";
            TxtBoxNoKamar.Text       = "";
            TextBoxNamaTamu.Text     = "";
            TextBoxNoHp.Text         = "";
            TxtBoxKodePemesanan.Text = "";
        }
    }
}
