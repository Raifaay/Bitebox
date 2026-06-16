using Bitebox.Controllers;
using Bitebox.Models.Entity;
using System.Drawing;
using System.Windows.Forms;

namespace Bitebox.Views.Admin
{
    public partial class FormLaporanPenjualan : Form
    {
        private readonly LaporanControllersAdmin _controller = new LaporanControllersAdmin();
        private string _periode = "bulan";
        private string? _filterKategori = null;

        public FormLaporanPenjualan()
        {
            InitializeComponent();
            SiapkanSidebar();
            SiapkanKategori();
            SiapkanDGV();
            SetToggleAktif(btnBulanIni);
            MuatData();
        }

        private void SiapkanSidebar()
        {
            btnBeranda.Click += (s, e) => { new FormBeranda().Show(); this.Close(); };
            btnPengelolaMenu.Click += (s, e) => { new FormPengelolaMenu().Show(); this.Close(); };
            btnPengelolaPesanan.Click += (s, e) => { new FormPengelolaPesanan().Show(); this.Close(); };
            btnKelolaCustomer.Click += (s, e) => { new FormKelolaCustomer().Show(); this.Close(); };
            btnLogout.Click += (s, e) =>
            {
                var r = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes) { new FormLogin().Show(); this.Close(); }
            };

            btnHariInibtnHariIni.Click += (s, e) => { _periode = "hari"; SetToggleAktif(btnHariInibtnHariIni); MuatData(); };
            btnBulanIni.Click += (s, e) => { _periode = "bulan"; SetToggleAktif(btnBulanIni); MuatData(); };
            btnTahunIni.Click += (s, e) => { _periode = "tahun"; SetToggleAktif(btnTahunIni); MuatData(); };
        }

        private void SetToggleAktif(Button aktif)
        {
            foreach (Button btn in new[] { btnHariInibtnHariIni, btnBulanIni, btnTahunIni })
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(255, 165, 81);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(255, 165, 81);
                btn.FlatAppearance.BorderSize = 1;
            }
            aktif.BackColor = Color.FromArgb(255, 165, 81);
            aktif.ForeColor = Color.White;
        }

        private void SiapkanKategori()
        {
            cmbFilterKatgori.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            cmbFilterKatgori.Items.Clear();
            cmbFilterKatgori.Items.Add("Semua Kategori");
            foreach (var k in _controller.GetSemuaKategori())
                cmbFilterKatgori.Items.Add(k);
            cmbFilterKatgori.SelectedIndex = 0;
            cmbFilterKatgori.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void SiapkanDGV()
        {
            // DGV Per Menu
            dgvPenjualanPermenu.Columns.Clear();
            dgvPenjualanPermenu.AllowUserToAddRows = false;
            dgvPenjualanPermenu.ReadOnly = true;
            dgvPenjualanPermenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenjualanPermenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenjualanPermenu.EnableHeadersVisualStyles = false;
            dgvPenjualanPermenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 126, 34);
            dgvPenjualanPermenu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPenjualanPermenu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPenjualanPermenu.ColumnHeadersHeight = 45;
            dgvPenjualanPermenu.RowTemplate.Height = 40;
            dgvPenjualanPermenu.BorderStyle = BorderStyle.None;
            dgvPenjualanPermenu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPenjualanPermenu.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvPenjualanPermenu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 180);
            dgvPenjualanPermenu.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 66, 50);

            dgvPenjualanPermenu.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNama", HeaderText = "Nama Menu" });
            dgvPenjualanPermenu.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKategori", HeaderText = "Kategori" });
            dgvPenjualanPermenu.Columns.Add(new DataGridViewTextBoxColumn { Name = "colJumlah", HeaderText = "Jumlah Terjual" });
            dgvPenjualanPermenu.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total Pendapatan" });

            // DGV Per Kategori
            dgvPenjualanPerkategori.Columns.Clear();
            dgvPenjualanPerkategori.AllowUserToAddRows = false;
            dgvPenjualanPerkategori.ReadOnly = true;
            dgvPenjualanPerkategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenjualanPerkategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenjualanPerkategori.EnableHeadersVisualStyles = false;
            dgvPenjualanPerkategori.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 126, 34);
            dgvPenjualanPerkategori.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPenjualanPerkategori.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPenjualanPerkategori.ColumnHeadersHeight = 45;
            dgvPenjualanPerkategori.RowTemplate.Height = 40;
            dgvPenjualanPerkategori.BorderStyle = BorderStyle.None;
            dgvPenjualanPerkategori.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPenjualanPerkategori.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvPenjualanPerkategori.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 180);
            dgvPenjualanPerkategori.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 66, 50);

            dgvPenjualanPerkategori.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKategori", HeaderText = "Kategori" });
            dgvPenjualanPerkategori.Columns.Add(new DataGridViewTextBoxColumn { Name = "colJumlah", HeaderText = "Total Terjual" });
            dgvPenjualanPerkategori.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total Pendapatan" });
        }

        private void MuatData()
        {
            try
            {
                // stat cards
                int totalPenjualan = _controller.GetTotalPenjualan(_periode);
                int totalTransaksi = _controller.GetTotalTransaksi(_periode);
                int rataRata = _controller.GetRataRata(_periode);

                lblAngkaTotalPenjualan.Text = $"Rp {totalPenjualan:N0}";
                lblAngkaTotalTransaksi.Text = totalTransaksi.ToString();
                lblRataratatransaksi.Text = $"Rp {rataRata:N0}";

                // tabel per menu
                dgvPenjualanPermenu.Rows.Clear();
                var listMenu = _controller.GetLaporan(_periode, _filterKategori);
                foreach (var item in listMenu)
                    dgvPenjualanPermenu.Rows.Add(item.NamaMenu, item.Kategori, item.JumlahTerjual, $"Rp {item.TotalPendapat:N0}");

                // tabel per kategori
                dgvPenjualanPerkategori.Rows.Clear();
                var listKategori = _controller.GetLaporanRollup(_periode);
                foreach (var item in listKategori)
                    dgvPenjualanPerkategori.Rows.Add(item.Kategori, item.JumlahTerjual, $"Rp {item.TotalPendapat:N0}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string selected = cmbFilterKatgori.SelectedItem?.ToString() ?? "";
            _filterKategori = selected == "Semua Kategori" ? null : selected;
            MuatData();
        }
    }
}