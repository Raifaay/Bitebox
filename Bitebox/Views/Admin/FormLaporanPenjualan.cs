using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using Bitebox.Controllers;
using Bitebox.Models.Entity;

namespace Bitebox.Views.Admin
{
    public partial class FormLaporanPenjualan : Form
    {
        private LaporanControllersAdmin laporanController = new LaporanControllersAdmin();
        public FormLaporanPenjualan()
        {
            InitializeComponent();
            IsiKategoriComboBox();
            TampilkanSemua();
        }

        private void IsiKategoriComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Semua Kategori");

            // ambil kategori dari DB lewat controller
            List<string> kategori = laporanController.GetSemuaKategori();
            foreach (var k in kategori)
                comboBox1.Items.Add(k);

            comboBox1.SelectedIndex = 0;
        }

        private void TampilkanSemua()
        {
            // tampilkan semua data tanpa filter
            TampilkanStatistik();
            TampilkanTabel(null);
        }

        private void TampilkanStatistik()
        {
            // view minta data ke controller, controller yang urus ke DB
            int totalPenjualan = laporanController.GetTotalPenjualan();
            int totalTransaksi = laporanController.GetTotalTransaksi();
            int rataRata = laporanController.GetRataRata();

            lbHarga.Text = $"Rp.{totalPenjualan:N0}";
            lbHarga1.Text = totalTransaksi.ToString();
            lbHarga2.Text = $"Rp.{rataRata:N0}";
        }

        private void TampilkanTabel(string? filterKategori)
        {
            // minta data laporan ke controller
            List<LaporanItem> dataLaporan = laporanController.GetLaporan(filterKategori);

            dataGridView1.Rows.Clear();

            foreach (var item in dataLaporan)
            {
                dataGridView1.Rows.Add(
                    item.NamaMenu,
                    item.Kategori,
                    item.JumlahTerjual,
                    $"Rp.{item.TotalPendapat:N0}"
                );
            }


        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard form = new FormDashboard();
            form.Show();
        }

        private void btnPengelolaMenu_Click(object sender, EventArgs e)
        {
            FormPengelolaMenu form = new FormPengelolaMenu();
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

        private void btnPerKategori_Click(object sender, EventArgs e)
        {
            //kasih function
        }
    }
}
