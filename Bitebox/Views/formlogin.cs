using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bitebox.Views
{
    public partial class FormLogin : Form
    {
        private string username;
        private string password;
        public FormLogin()
        {
            InitializeComponent();
            username = "aqila";
            password = "aqila123"; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // tes push ulang 
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usernameInput = TbUsername.Text;
            string passwordInput = TbPassword.Text;

            if (usernameInput == username && passwordInput == password)
            {
                MessageBox.Show("Login Berhasil", "success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }

            else
            {
                MessageBox.Show("Username Atau Password Salah", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
