using Bitebox.Helpers;
using Bitebox.Models.Context;
using Npgsql;
using System;
using System.Drawing;
using System.Windows.Forms;
using Bitebox.Models.Entity;
using Bitebox.Models.Context;

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
            btnriwayat.Click += btnriwayat_Click;
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
            dgvRiwayat.Columns.Add("total", "Total");
            dgvRiwayat.Columns.Add("status", "Status Pesanan");

            RiwayatContext riwayatContext = new RiwayatContext();
            List<RiwayatItem> listRiwayat = riwayatContext.GetRiwayatByAkun(idAkun);

            foreach (RiwayatItem r in listRiwayat)
            {
                string jenis = r.KodePickup != null ? "Take Away" : $"Eat In - {r.NomorMeja}";
                dgvRiwayat.Rows.Add(
                    $"#{r.IdPesanan}",
                    r.TanggalPesanan.ToString("dd MMM yyyy"),
                    jenis,
                    $"Rp {r.Total:N0}",
                    r.NamaStatus
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
            var konfirmasi = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == DialogResult.Yes)
            {
                KeranjangSession.Clear();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private void dgvRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnriwayat_Click(object sender, EventArgs e)
        {

        }
    }
}