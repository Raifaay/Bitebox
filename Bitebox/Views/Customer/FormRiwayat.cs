using Bitebox.Helpers;
using Bitebox.Models.Context;
using Bitebox.Models.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bitebox.Views.Customer
{
    public partial class FormRiwayat : Form
    {
        private int idAkun;

        public FormRiwayat(int idAkun)
        {
            InitializeComponent();
            this.idAkun = idAkun;
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            LoadRiwayat();
            StylingDgv();
            btnberanda.Click += btnberanda_Click;
            btnkeranjang.Click += btnkeranjang_Click;
            btnkeluar.Click += btnkeluar_Click;
        }

        private void StylingDgv()
        {
            dgvRiwayat.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 165, 81);
            dgvRiwayat.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRiwayat.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRiwayat.EnableHeadersVisualStyles = false;
            dgvRiwayat.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRiwayat.DefaultCellStyle.ForeColor = Color.FromArgb(128, 66, 50);
            dgvRiwayat.RowTemplate.Height = 45;
        }

        private void LoadRiwayat()
        {
            dgvRiwayat.Rows.Clear();
            dgvRiwayat.Columns.Clear();
            dgvRiwayat.Columns.Add("id_pesanan", "ID Pesanan");
            dgvRiwayat.Columns.Add("tanggal", "Tanggal");
            dgvRiwayat.Columns.Add("jenis", "Jenis Layanan");
            dgvRiwayat.Columns.Add("metode", "Metode Pembayaran");
            dgvRiwayat.Columns.Add("total", "Total");
            dgvRiwayat.Columns.Add("status", "Status Pesanan");
            dgvRiwayat.Columns.Add("status_bayar", "Status Pembayaran");

            RiwayatContext riwayatContext = new RiwayatContext();
            List<RiwayatItem> listRiwayat = riwayatContext.GetRiwayatByAkun(idAkun);

            foreach (RiwayatItem r in listRiwayat)
            {
                string jenis = r.KodePickup != null ? "Take Away" : $"Dine In - {r.NomorMeja}";
                dgvRiwayat.Rows.Add(
                    $"#{r.IdPesanan}",
                    r.TanggalPesanan.ToString("dd MMM yyyy"),
                    jenis,
                    r.MetodePembayaran,
                    $"Rp {r.Total:N0}",
                    r.NamaStatus,
                    r.NamaStatusPembayaran
                );
            }
        }

        private void btnberanda_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormMenuUtama)
                {
                    f.Show();
                    break;
                }
            }
            this.Close();
        }

        private void btnkeranjang_Click(object sender, EventArgs e)
        {
            FormKeranjang formKeranjang = new FormKeranjang(idAkun);
            formKeranjang.Show();
            this.Close();
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            NavigationHelper.KeluarKeLogin(this);
        }
    }
}