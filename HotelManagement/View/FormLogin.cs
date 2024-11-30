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
            if (string.IsNullOrWhiteSpace(TextBoxUsername.Text) || string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {
                MessageBox.Show("Silakan masukkan data login!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = TextBoxUsername.Text.Trim();
                string password = TextBoxPassword.Text.Trim();

                string query = "SELECT * FROM admin WHERE BINARY username = @username AND BINARY passwordd = @password";

                using (var conn = LoginControl.GetConn())
                {
                    try
                    {
                        if (conn.State != ConnectionState.Open) conn.Open();
                        using (var cmd = new MySqlConnector.MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);

                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    FormBeranda main = new FormBeranda();
                                    main.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan saat login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
