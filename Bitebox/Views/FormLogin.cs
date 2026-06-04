using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bitebox.Controllers;
using Bitebox.Models.Entity;

namespace Bitebox.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void lblemail_Click(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string emailInput = txtemail.Text;
            string passwordInput = txtpassword.Text;

            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Email dan password tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AkunController akunController = new AkunController();
            Akun? akun = akunController.Login(emailInput, passwordInput);

            if (akun == null)
            {
                MessageBox.Show("Username/Email atau password salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (akun.Role == "admin")
            {
                MessageBox.Show("Login sebagai Admin", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login sebagai Customer", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndaftarakun_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcblogo_Click(object sender, EventArgs e)
        {
        }
    }
}