using Bitebox.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Bitebox.Views.Admin
{
    public partial class FormDashboard : Form
    {
        private readonly DashboardController _dashboardController;
        private Form formAktif = null; 

        public FormDashboard()
        {
            InitializeComponent();
            _dashboardController = new DashboardController();

        }

        private void lbTotalProduk_Click(object sender, EventArgs e)
        {

        }

        private void lbAngka1_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                long totalProduk = _dashboardController.GetTotalProduk();
                long totalPenjualan = _dashboardController.GetTotalPenjualan();
                decimal totalPenhasilan = _dashboardController.GetTotalPenghasilan();

                lbAngka.Text = totalProduk.ToString();
                lbAngka1.Text = totalPenjualan.ToString();
                lbAngka2.Text = string.Format("Rp.{0:n0}", totalPenghasilan); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error memuat statistik: " + ex.Message, " BiteBox Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BukaFormAnak(Form formAnak)
        {
            if (formAktif != null)
            {
                formAktif.Close();
            }

            formAktif = formAnak;
            formAnak.TopLevel = false; 

        }

        private void btnPengelolaMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnLaporanPenjualan_Click(object sender, EventArgs e)
        {

        }

        private void btnKelolaCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormLogin fromLogin = new FormLogin();
                fromLogin.Show();
                this.Close(); 
            }
        }
    }
}
