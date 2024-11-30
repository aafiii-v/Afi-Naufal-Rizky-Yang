using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Controller
{
    internal class Validation
    {
        public bool ValidasiUsername(string username)
        {
            for (int a = 0; a < username.Length; a++)
            {
                if (username[a] == ' ' || username[a] == '-' || username[a] == '/' || username[a] == '\\' || username[a] == '?' ||
                    username[a] == '!' || username[a] == '@' || username[a] == '#' || username[a] == '$' || username[a] == '%' ||
                    username[a] == '^' || username[a] == '&' || username[a] == '*' || username[a] == '(' || username[a] == ')' ||
                    username[a] == '`' || username[a] == '~' || username[a] == '+' || username[a] == '=' || username[a] == '[' ||
                    username[a] == ']' || username[a] == '{' || username[a] == '}' || username[a] == ';' || username[a] == '\'' ||
                    username[a] == ':' || username[a] == '\"' || username[a] == ',' || username[a] == '.' || username[a] == '/' ||
                    username[a] == '>' || username[a] == '<' || username[a] == '|')
                {
                    MessageBox.Show("Input Username gagal, perbaiki inputan anda", "Tambah Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (username[0] == ' ' || username[username.Length - 1] == ' ')
            {
                MessageBox.Show("Input Username gagal. Username tidak boleh diawali atau diakhiri dengan spasi",
                                "Validasi Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (username.Length < 3 || username.Length > 26)
            {
                MessageBox.Show("Username tidak boleh kurang dari 2 huruf atau lebih dari 26 huruf", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool ValidasiPassword(string password)
        {
            if (password.Length < 8 || password.Length > 25 || password[0] == ' ' || password[password.Length - 1] == ' ')
            {
                MessageBox.Show("Password gagal. Password harus memiliki panjang antara 8-20 karakter dan tidak boleh diawali atau diakhiri dengan spasi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool ValidasiNohp(string telp)
        {
            for (int a = 0; a < telp.Length; a++)
            {
                if ((telp[a] >= 'A' && telp[a] <= 'Z') || (telp[a] >= 'a' && telp[a] <= 'z') ||
                    telp[a] == ' ' || telp[a] == '-' || telp[a] == '/' || telp[a] == '\\' || telp[a] == '?' ||
                    telp[a] == '!' || telp[a] == '@' || telp[a] == '#' || telp[a] == '$' || telp[a] == '%' ||
                    telp[a] == '^' || telp[a] == '&' || telp[a] == '*' || telp[a] == '(' || telp[a] == ')' ||
                    telp[a] == '`' || telp[a] == '~' || telp[a] == '+' || telp[a] == '=' || telp[a] == '[' ||
                    telp[a] == ']' || telp[a] == '{' || telp[a] == '}' || telp[a] == ';' || telp[a] == '\'' ||
                    telp[a] == ':' || telp[a] == '\"' || telp[a] == ',' || telp[a] == '.' || telp[a] == '/' ||
                    telp[a] == '>' || telp[a] == '<' || telp[a] == '|')
                {
                    MessageBox.Show("Input No Hp gagal, perbaiki inputan anda", "Tambah No Hp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (telp[0] != '0' || telp[1] != '8')
            {
                MessageBox.Show("Nomor HP harus diawali dengan '08'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (telp.Length < 10 || telp.Length > 13)
            {
                MessageBox.Show("Nomor telepon harus memiliki minimal 10 digit - 13 digit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public bool ValidasiNama(String nama)
        {
            for (int a = 0; a < nama.Length; a++)
            {
                if ((nama[a] >= '0' && nama[a] <= '9') || nama[nama.Length - 1] == ' ' || nama[a] == '-' ||
                    nama[a] == '/' || nama[a] == '\\' || nama[a] == '?' || nama[a] == '!' ||
                    nama[a] == '@' || nama[a] == '#' || nama[a] == '$' || nama[a] == '%' ||
                    nama[a] == '^' || nama[a] == '&' || nama[a] == '*' || nama[a] == '(' ||
                    nama[a] == ')' || nama[a] == '`' || nama[a] == '~' || nama[a] == '+' ||
                    nama[a] == '=' || nama[a] == '[' || nama[a] == ']' || nama[a] == '{' ||
                    nama[a] == '}' || nama[a] == ';' || nama[a] == '\'' || nama[a] == ':' ||
                    nama[a] == '\"' || nama[a] == ',' || nama[a] == '.' || nama[a] == '/' ||
                    nama[a] == '>' || nama[a] == '<' || nama[a] == '|')
                {
                    MessageBox.Show("Input nama gagal, Inputan hanya huruf saja", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (nama.Length < 3)
                {
                    MessageBox.Show("Minimal Inputan Nama 3 Huruf", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
    }
}
