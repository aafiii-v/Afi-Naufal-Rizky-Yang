using HotelManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement.View
{
    public partial class FormRegister : Form
    {
        LoginController Register;
        public FormRegister()
        {
            InitializeComponent();
            Register = new LoginController();
        }
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.PasswordChar = CheckBoxShowPassword.Checked ? '\0' : '*';
        }
        private void LabelCloseSignIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == "" || TextBoxPassword.Text == "")
            {
                MessageBox.Show("Please Fill All Blank Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Register.AddAccount(TextBoxUsername.Text, TextBoxPassword.Text);
                this.Controls.Clear();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
        }
        private void ButtonToLogin_Click_1(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
