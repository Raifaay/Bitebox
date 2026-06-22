using Bitebox.Controllers;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bitebox.Views.Admin
{
    public partial class FormKelolaCustomer : Form
    {
        private readonly CustomerController _controller = new CustomerController();

        public FormKelolaCustomer()
        {
            InitializeComponent();
            SiapkanSidebar();
            SiapkanDGV();
            TampilkanCustomer();
        }

        private void SiapkanSidebar()
        {
            btnBeranda.Click += (s, e) => { new FormBeranda().Show(); this.Close(); };
            btnPengelolaMenu.Click += (s, e) => { new FormPengelolaMenu().Show(); this.Close(); };
            btnPengelolaPesanan.Click += (s, e) => { new FormPengelolaPesanan().Show(); this.Close(); };
            btnLaporanPenjualan.Click += (s, e) => { new FormLaporanPenjualan().Show(); this.Close(); };
            btnLogout.Click += (s, e) =>
            {
                var r = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes) { new FormLogin().Show(); this.Close(); }
            };
        }

        private void SiapkanDGV()
        {
            dgvKelolaCustomer.Columns.Clear();
            dgvKelolaCustomer.AllowUserToAddRows = false;
            dgvKelolaCustomer.ReadOnly = true;
            dgvKelolaCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKelolaCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKelolaCustomer.EnableHeadersVisualStyles = false;
            dgvKelolaCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 126, 34);
            dgvKelolaCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKelolaCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvKelolaCustomer.ColumnHeadersHeight = 45;
            dgvKelolaCustomer.RowTemplate.Height = 45;
            dgvKelolaCustomer.BorderStyle = BorderStyle.None;
            dgvKelolaCustomer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvKelolaCustomer.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvKelolaCustomer.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 180);
            dgvKelolaCustomer.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 66, 50);

            // Tambahkan kolom ID tersembunyi untuk menyimpan ID Akun saat diklik aksi
            dgvKelolaCustomer.Columns.Add(new DataGridViewTextBoxColumn { Name = "colIdAkun", Visible = false });
            dgvKelolaCustomer.Columns.Add(new DataGridViewTextBoxColumn { Name = "colUsername", HeaderText = "Username" });
            dgvKelolaCustomer.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNama", HeaderText = "Nama Lengkap" });
            dgvKelolaCustomer.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEmail", HeaderText = "Email" });
            dgvKelolaCustomer.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status" });

            var colAksi = new DataGridViewButtonColumn
            {
                Name = "colAksi",
                HeaderText = "Aksi",
                UseColumnTextForButtonValue = false,
                FlatStyle = FlatStyle.Flat,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 180
            };
            dgvKelolaCustomer.Columns.Add(colAksi);
            dgvKelolaCustomer.CellClick += DGV_CellClick;
        }

        private void TampilkanCustomer()
        {
            try
            {
                dgvKelolaCustomer.Rows.Clear();

                // 1. Mengambil data dalam bentuk DataTable dari controller
                DataTable dt = _controller.GetCustomerList();

                // 2. Iterasi Baris DataTable dengan DataRow (Bukan foreach biasa)
                foreach (DataRow row in dt.Rows)
                {
                    // Menyesuaikan nama kolom sesuai dengan get_semua_customer() di database PostgreSQL
                    int idAkun = Convert.ToInt32(row["id_akun"]);
                    string username = row["username"]?.ToString() ?? "";
                    string namaLengkap = row["nama_lengkap"]?.ToString() ?? "";
                    string email = row["email"]?.ToString() ?? "";
                    bool isAktif = Convert.ToBoolean(row["is_aktif"]);

                    int idx = dgvKelolaCustomer.Rows.Add(
                        idAkun,
                        username,
                        namaLengkap,
                        email,
                        isAktif ? "Aktif" : "Nonaktif",
                        isAktif ? "Nonaktifkan" : "Aktifkan"
                    );

                    // Mengatur warna status label biar cantik
                    dgvKelolaCustomer.Rows[idx].Cells["colStatus"].Style.ForeColor = isAktif
                        ? Color.FromArgb(6, 95, 70) : Color.FromArgb(153, 27, 27);
                    dgvKelolaCustomer.Rows[idx].Cells["colStatus"].Style.BackColor = isAktif
                        ? Color.FromArgb(209, 250, 229) : Color.FromArgb(254, 202, 202);

                    // Menyimpan status aktif saat ini ke dalam Tag baris grid agar mudah dibaca saat tombol Aksi diklik
                    dgvKelolaCustomer.Rows[idx].Tag = isAktif;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validasi baris dan kolom klik aksi
            if (e.RowIndex < 0 || e.ColumnIndex != dgvKelolaCustomer.Columns["colAksi"].Index) return;

            var row = dgvKelolaCustomer.Rows[e.RowIndex];
            int idAkun = Convert.ToInt32(row.Cells["colIdAkun"].Value);
            string username = row.Cells["colUsername"].Value?.ToString() ?? "";
            bool isAktif = (bool)(row.Tag ?? true); // Mengambil status dari Tag baris

            string aksi = isAktif ? "nonaktifkan" : "aktifkan";
            var jawab = MessageBox.Show($"Yakin mau {aksi} akun {username}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab != DialogResult.Yes) return;

            // Memanggil controller dengan 2 argumen sesuai request form aslimu (Error CS1501 solved!)
            bool berhasil = _controller.ToggleCustomerStatus(idAkun, isAktif);
            if (berhasil)
            {
                TampilkanCustomer();
            }
            else
            {
                MessageBox.Show("Gagal update status customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}