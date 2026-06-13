using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bitebox.Controllers;
using Bitebox.Models.Entity;
using Bitebox.Views.Admin;

namespace Bitebox.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string emailInput = txtemail.Text.Trim();
            string passwordInput = txtpassword.Text.Trim();

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

            string pesanSelamatDatang = akun.GetHakAksesDashboard();
            MessageBox.Show(pesanSelamatDatang, "Berhasil Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (akun.RoleAkun.ToLower() == "admin")
            {
                FormDashboard formDashboard = new FormDashboard();
                formDashboard.Show();
                this.Hide();
            }
            else
            {
                FormMenuUtama formMenu = new FormMenuUtama(akun.NamaLengkap, akun.IdAkun);
                formMenu.Show();
                this.Hide();
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

    }
}