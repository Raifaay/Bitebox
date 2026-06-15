using Bitebox.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bitebox.Views.Admin
{
    public partial class FormKelolaCustomer : Form
    {
        private CustomerController _controller = new CustomerController();
        public FormKelolaCustomer()
        {
            InitializeComponent();
            LoadData();
        }

        // Alur: View meminta data ke Controller -> Ditampilkan ke DataGridView
        private void LoadData()
        {
            // Controller mengembalikan List<CustomerModel> ke View
            dGVKelolaCustomer.DataSource = _controller.GetCustomerList();

            // Opsional: Mempercantik teks tombol berdasarkan status di baris tersebut
            FormatGridButtons();
        }

        private void FormatGridButtons()
        {
            // Loop untuk mengubah text tombol di grid (misal tombol ada di kolom indeks ke-4)
            foreach (DataGridViewRow row in dGVKelolaCustomer.Rows)
            {
                if (row.Cells["IsActive"].Value != null)
                {
                    bool isActive = Convert.ToBoolean(row.Cells["IsActive"].Value);
                    row.Cells["btnAksi"].Value = isActive ? "Nonaktifkan" : "Aktifkan";
                }
            }
        }

        // Kejadian ketika tombol di dalam DataGridView diklik
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan yang diklik adalah kolom tombol Aksi (misal nama kolomnya "btnAksi")
            if (dGVKelolaCustomer.Columns[e.ColumnIndex].Name == "btnAksi" && e.RowIndex >= 0)
            {
                // Ambil data dari baris yang diklik
                int id = Convert.ToInt32(dGVKelolaCustomer.Rows[e.RowIndex].Cells["Id"].Value);
                bool currentStatus = Convert.ToBoolean(dGVKelolaCustomer.Rows[e.RowIndex].Cells["IsActive"].Value);

                // Minta Controller untuk mengubah statusnya
                bool isSuccess = _controller.ToggleCustomerStatus(id, currentStatus);

                if (isSuccess)
                {
                    MessageBox.Show("Status customer berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Refresh grid agar datanya paling update
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormBeranda form = new FormBeranda();
            form.Show();
        }

        private void btnPengelolaMenu_Click(object sender, EventArgs e)
        {
            FormPengelolaMenu form = new FormPengelolaMenu();
            form.Show();
        }

        private void btnLaporanPenjualan_Click(object sender, EventArgs e)
        {
            FormPengelolaMenu form = new FormPengelolaMenu();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}