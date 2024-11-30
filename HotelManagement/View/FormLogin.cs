using HotelManagement.Controller;
using HotelManagement.View;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FormLogin : Form
    {
        LoginController LoginControl;
        public FormLogin()
        {
            InitializeComponent();
            LoginControl = new LoginController();
        }

        private void LabelCloseSignIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if ((TextBoxUsername.Text == "") || (TextBoxPassword.Text == ""))
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = TextBoxUsername.Text;
                string pass = TextBoxPassword.Text;
                DataTable table = LoginControl.GetList(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM admin WHERE username = '" + name + "' AND passwordd = '" + pass + "'"));
                if (table.Rows.Count > 0)
                {
                    FormBeranda main = new FormBeranda();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("== Username or Password is Wrong ==", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.PasswordChar = CheckBoxShowPassword.Checked ? '\0' : '*';
        }
    }
}
