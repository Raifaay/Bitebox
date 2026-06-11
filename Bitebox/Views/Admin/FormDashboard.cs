using Bitebox.Controllers;
using Bitebox.Models.Entity;
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
                DashboardStats model = _dashboardController.GetDashboardData();

                lbAngka.Text = model.TotalProduk.ToString("N0");
                lbAngka1.Text = model.TotalPenjualan.ToString("N0");
                lbAngka2.Text = "Rp" + model.TotalPenghasilan.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPengelolaMenu_Click(object sender, EventArgs e)
        {
            FormPengelolaMenu form = new FormPengelolaMenu();
            form.Show();
        }

        private void btnLaporanPenjualan_Click(object sender, EventArgs e)
        {
            FormLaporanPenjualan form = new FormLaporanPenjualan();
            form.Show();
        }

        private void btnKelolaCustomer_Click(object sender, EventArgs e)
        {
            FormKelolaCustomer form = new FormKelolaCustomer();
            form.Show();
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

        private void dtpFilterTanggal_ValueChanged(object sender, EventArgs e)
        {
            // 1. Ambil tanggal dari kalender
            DateTime tanggalTerpilih = dtpFilterTanggal.Value;

            try
            {
                // 2. Panggil controller
                DashboardController dashboardController = new DashboardController();
                int totalJual = dashboardController.GetTotalJualByTanggal(tanggalTerpilih);
                long totalCuan = dashboardController.GetTotalPenghasilanByTanggal(tanggalTerpilih);

                // 3. SEKARANG KITA TEMBAK ALAMAT YANG BENER!
                // Mengubah angka gede di tengah tanpa merusak judul atas/bawah
                lbAngka.Text = totalJual.ToString();
                lbAngka2.Text = $"Rp.{totalCuan:N0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data dashboard: " + ex.Message);
            }
        }
    }
}
