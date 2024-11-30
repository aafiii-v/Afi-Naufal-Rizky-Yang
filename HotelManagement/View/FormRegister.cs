using HotelManagement.Controller;
using System;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class FormRegister : Form
    {
        Validation validation;
        LoginController Register;
        public FormRegister()
        {
            InitializeComponent();
            Register = new LoginController();
            validation = new Validation();
        }
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.PasswordChar = CheckBoxShowPassword.Checked ? '\0' : '*';
        }
        private void LabelCloseSignIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool Verify()
        {
            if(!validation.ValidasiUsername(TextBoxUsername.Text))
            {
                return false;
            }
            if (!validation.ValidasiPassword(TextBoxPassword.Text))
            {
                return false;
            }
            return true;
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (Verify())
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
        }
        private void ButtonToLogin_Click_1(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
