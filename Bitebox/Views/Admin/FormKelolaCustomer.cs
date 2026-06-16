using Bitebox.Controllers;
using Bitebox.Models.Entity;

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
                var list = _controller.GetCustomerList();
                foreach (var c in list)
                {
                    int idx = dgvKelolaCustomer.Rows.Add(
                        c.Username,
                        c.NamaLengkap,
                        c.Email,
                        c.IsAktif ? "Aktif" : "Nonaktif",
                        c.IsAktif ? "Nonaktifkan" : "Aktifkan"
                    );
                    dgvKelolaCustomer.Rows[idx].Cells["colStatus"].Style.ForeColor = c.IsAktif
                        ? Color.FromArgb(6, 95, 70) : Color.FromArgb(153, 27, 27);
                    dgvKelolaCustomer.Rows[idx].Cells["colStatus"].Style.BackColor = c.IsAktif
                        ? Color.FromArgb(209, 250, 229) : Color.FromArgb(254, 202, 202);
                    dgvKelolaCustomer.Rows[idx].Tag = c;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvKelolaCustomer.Columns["colAksi"].Index) return;
            if (dgvKelolaCustomer.Rows[e.RowIndex].Tag is not EntityCustomerAdmin customer) return;

            string aksi = customer.IsAktif ? "nonaktifkan" : "aktifkan";
            var jawab = MessageBox.Show($"Yakin mau {aksi} akun {customer.Username}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab != DialogResult.Yes) return;

            bool berhasil = _controller.ToggleCustomerStatus(customer.Id, customer.IsAktif);
            if (berhasil) TampilkanCustomer();
            else MessageBox.Show("Gagal update status customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}