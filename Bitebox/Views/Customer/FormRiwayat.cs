using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using Bitebox.Helpers;

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

            string query = @"SELECT p.id_pesanan, p.tanggal_pesanan, p.kode_pickup, p.id_meja,
                            m.nomor_meja, sp.nama_status_pesanan,
                            SUM(dp.subtotal) as total
                            FROM pesanan p
                            LEFT JOIN meja m ON p.id_meja = m.id_meja
                            LEFT JOIN status_pesanan sp ON p.id_status_pesanan = sp.id_status_pesanan
                            LEFT JOIN detail_pesanan dp ON p.id_pesanan = dp.id_pesanan
                            WHERE p.id_akun = @idAkun
                            GROUP BY p.id_pesanan, p.tanggal_pesanan, p.kode_pickup, p.id_meja,
                            m.nomor_meja, sp.nama_status_pesanan
                            ORDER BY p.tanggal_pesanan DESC"; //bungkus view + taro context 

            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idAkun", idAkun);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string jenis = reader["id_meja"] == DBNull.Value
                                ? $"Take Away"
                                : $"Eat In - {reader["nomor_meja"]}";

                            dgvRiwayat.Rows.Add(
                                $"#{reader["id_pesanan"]}",
                                Convert.ToDateTime(reader["tanggal_pesanan"]).ToString("dd MMM yyyy"),
                                jenis,
                                $"Rp {(reader["total"] == DBNull.Value ? 0 : Convert.ToInt32(reader["total"])):N0}",
                                reader["nama_status_pesanan"]?.ToString()
                            );
                        }
                    }
                }
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