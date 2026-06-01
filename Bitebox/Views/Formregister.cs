using Bitebox.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bitebox.Views
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblnamalengkap_Click(object sender, EventArgs e)
        {

        }
        private void btndaftar_Click(object sender, EventArgs e)
        {
            string nama = txtnamalengkap.Text;
            string email = txtemail.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AkunController akunController = new AkunController();
            bool berhasil = akunController.Register(nama, email, username, password);

            if (berhasil)
            {
                MessageBox.Show("Akun berhasil dibuat, silakan login", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registrasi gagal, coba lagi", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlogindisini_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
    }
}
