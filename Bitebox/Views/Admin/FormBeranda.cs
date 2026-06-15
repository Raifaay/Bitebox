using Bitebox.Controllers;
using Bitebox.Helpers;
using Bitebox.Models.Context;
using Bitebox.Models.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bitebox.Views.Admin
{
    public partial class FormBeranda : Form
    {
        private readonly BerandaController _berandaController;
        private readonly BerandaContext _berandaContext;

        public FormBeranda()
        {
            InitializeComponent();
            _berandaController = new BerandaController();
            _berandaContext = new BerandaContext();
        }

        private void FormBeranda_Load(object sender, EventArgs e)
        {
            LoadBerandaData();
            LoadStatusMeja();
        }

        private void LoadBerandaData()
        {
            lblTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"));
            try
            {
                Beranda model = _berandaController.GetDashboardData();
                lblAngkaProduk.Text = model.TotalProduk.ToString("N0");
                lblAngkaItemTerjual.Text = model.TotalPenjualan.ToString("N0");
                lblAngkaDariPenjualan.Text = "Rp " + model.TotalPenghasilan.ToString("N0");
                lblJumlahMeja.Text = $"{model.MejaTersedia}/{model.TotalMeja}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatusMeja()
        {
            try
            {
                dgvStatusMeja.Rows.Clear();
                dgvStatusMeja.Columns.Clear();

                dgvStatusMeja.EnableHeadersVisualStyles = false;
                dgvStatusMeja.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 126, 34);
                dgvStatusMeja.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvStatusMeja.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgvStatusMeja.ColumnHeadersHeight = 45;
                dgvStatusMeja.RowTemplate.Height = 45;
                dgvStatusMeja.GridColor = Color.FromArgb(255, 240, 222);
                dgvStatusMeja.BorderStyle = BorderStyle.None;
                dgvStatusMeja.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvStatusMeja.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
                dgvStatusMeja.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 180);
                dgvStatusMeja.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 66, 50);
                dgvStatusMeja.AllowUserToAddRows = false;
                dgvStatusMeja.ReadOnly = true;
                dgvStatusMeja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                var colNomor = new DataGridViewTextBoxColumn();
                colNomor.Name = "nomor";
                colNomor.HeaderText = "Nomor Meja";
                colNomor.Width = 200;

                var colStatus = new DataGridViewTextBoxColumn();
                colStatus.Name = "status";
                colStatus.HeaderText = "Status";
                colStatus.Width = 200;

                var colAksi = new DataGridViewButtonColumn();
                colAksi.Name = "aksi";
                colAksi.HeaderText = "Aksi";
                colAksi.UseColumnTextForButtonValue = false;
                colAksi.FlatStyle = FlatStyle.Flat;
                colAksi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvStatusMeja.Columns.Add(colNomor);
                dgvStatusMeja.Columns.Add(colStatus);
                dgvStatusMeja.Columns.Add(colAksi);

                dgvStatusMeja.Columns["nomor"].HeaderCell.Style.BackColor = Color.FromArgb(230, 126, 34);
                dgvStatusMeja.Columns["nomor"].HeaderCell.Style.ForeColor = Color.White;
                dgvStatusMeja.Columns["status"].HeaderCell.Style.BackColor = Color.FromArgb(230, 126, 34);
                dgvStatusMeja.Columns["status"].HeaderCell.Style.ForeColor = Color.White;
                dgvStatusMeja.Columns["aksi"].HeaderCell.Style.BackColor = Color.FromArgb(230, 126, 34);
                dgvStatusMeja.Columns["aksi"].HeaderCell.Style.ForeColor = Color.White;

                var listMeja = _berandaContext.GetStatusMeja();
                foreach (var meja in listMeja)
                {
                    bool tersedia = meja.StatusMeja == "Tersedia";
                    int idx = dgvStatusMeja.Rows.Add(meja.NomorMeja, meja.StatusMeja, tersedia ? "Tandai Tidak Tersedia" : "Tandai Tersedia");

                    dgvStatusMeja.Rows[idx].Cells["nomor"].Style.ForeColor = Color.FromArgb(128, 66, 50);
                    dgvStatusMeja.Rows[idx].Cells["status"].Style.BackColor = tersedia
                        ? Color.FromArgb(209, 250, 229) : Color.FromArgb(254, 202, 202);
                    dgvStatusMeja.Rows[idx].Cells["status"].Style.ForeColor = tersedia
                        ? Color.FromArgb(6, 95, 70) : Color.FromArgb(153, 27, 27);
                    dgvStatusMeja.Rows[idx].Cells["status"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    dgvStatusMeja.Rows[idx].Tag = meja.IdMeja;
                }

                dgvStatusMeja.CellClick -= dgvStatusMeja_CellClick;
                dgvStatusMeja.CellClick += dgvStatusMeja_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat status meja:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStatusMeja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvStatusMeja.Columns["aksi"].Index) return;

            int idMeja = (int)dgvStatusMeja.Rows[e.RowIndex].Tag;
            string statusSekarang = dgvStatusMeja.Rows[e.RowIndex].Cells["status"].Value.ToString();
            string statusBaru = statusSekarang == "Tersedia" ? "Tidak Tersedia" : "Tersedia";

            try
            {
                _berandaContext.UpdateStatusMeja(idMeja, statusBaru);

                bool tersedia = statusBaru == "Tersedia";
                dgvStatusMeja.Rows[e.RowIndex].Cells["status"].Value = statusBaru;
                dgvStatusMeja.Rows[e.RowIndex].Cells["status"].Style.BackColor = tersedia
                    ? Color.FromArgb(209, 250, 229) : Color.FromArgb(254, 202, 202);
                dgvStatusMeja.Rows[e.RowIndex].Cells["status"].Style.ForeColor = tersedia
                    ? Color.FromArgb(6, 95, 70) : Color.FromArgb(153, 27, 27);
                dgvStatusMeja.Rows[e.RowIndex].Cells["aksi"].Value = tersedia ? "Tandai Tidak Tersedia" : "Tandai Tersedia";

                LoadBerandaData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update status:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private void btnPengelolaPesanan_Click(object sender, EventArgs e)
        {
            FormPengelolaPesanan form = new FormPengelolaPesanan();
            form.Show();
        }
    }
}