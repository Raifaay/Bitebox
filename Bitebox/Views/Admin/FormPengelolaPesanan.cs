using Bitebox.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bitebox.Views.Admin
{
    public partial class FormPengelolaPesanan : Form
    {
        private readonly PesananControllerAdmin _controller = new PesananControllerAdmin();
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();

        public FormPengelolaPesanan()
        {
            InitializeComponent();
            SiapkanSidebar();
            SiapkanComboBox();
            SiapkanDGV();
            _timer.Interval = 5000;
            _timer.Tick += (s, e) => RefreshData();
        }

        private void FormPengelolaPesanan_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy");
            RefreshData();
            _timer.Start();
        }

        private void SiapkanSidebar()
        {
            button6.Click += (s, e) => { new FormBeranda().Show(); this.Close(); };
            button5.Click += (s, e) => { new FormPengelolaMenu().Show(); this.Close(); };
            button3.Click += (s, e) => { new FormKelolaCustomer().Show(); this.Close(); };
            button4.Click += (s, e) => { new FormLaporanPenjualan().Show(); this.Close(); };
            button2.Click += (s, e) =>
            {
                var r = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes) { new FormLogin().Show(); this.Close(); }
            };
        }

        private void SiapkanComboBox()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Semua", "Diproses", "Siap Diambil", "Selesai" });
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += (s, e) => RefreshData();
        }

        private void SiapkanDGV()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 126, 34);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 180);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 66, 50);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", AutoSizeMode = DataGridViewAutoSizeColumnMode.None, Width = 60 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCustomer", HeaderText = "Customer" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colLayanan", HeaderText = "Layanan" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMejaKode", HeaderText = "Meja / Kode" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPembayaran", HeaderText = "Pembayaran" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status Pesanan" });

            var colAksi = new DataGridViewButtonColumn
            {
                Name = "colAksi",
                HeaderText = "Aksi",
                Text = "Update",
                UseColumnTextForButtonValue = false,
                FlatStyle = FlatStyle.Flat,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 160
            };
            dataGridView1.Columns.Add(colAksi);

            var colGagal = new DataGridViewButtonColumn
            {
                Name = "colGagal",
                HeaderText = "Gagalkan",
                Text = "Gagalkan",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 120
            };
            dataGridView1.Columns.Add(colGagal);

            dataGridView1.CellClick += DGV_CellClick;
        }

        private void RefreshData()
        {
            string? filter = comboBox1.SelectedIndex == 0 ? null : comboBox1.SelectedItem?.ToString();

            lblAngkaTotalPesanan.Text = _controller.GetTotal().ToString();
            lblAngkaDiproses.Text = _controller.GetCountByStatus("Diproses").ToString();
            lblAngkaSIapDIambil.Text = _controller.GetCountByStatus("Siap Diambil").ToString();
            lblAngkaSelesai.Text = _controller.GetCountByStatus("Selesai").ToString();

            var list = _controller.GetPesananHariIni(filter);
            dataGridView1.Rows.Clear();

            foreach (var p in list)
            {
                string layanan = p.NomorMeja != null ? "Dine-in" : "Take Away";
                string mejaKode = p.NomorMeja ?? p.KodePickup ?? "-";

                string aksiText = p.StatusPesanan switch
                {
                    "Diproses" => "→ Siap Diambil",
                    "Siap Diambil" => "→ Selesai",
                    _ => "-"
                };

                int idx = dataGridView1.Rows.Add(
                    p.IdPesanan,
                    p.NamaCustomer,
                    layanan,
                    mejaKode,
                    $"Rp {p.Total:N0}",
                    p.StatusPembayaran,
                    p.StatusPesanan
                );

                dataGridView1.Rows[idx].Tag = p;
                dataGridView1.Rows[idx].Cells["colAksi"].Value = aksiText;

                bool bisaAksi = p.StatusPesanan == "Diproses" || p.StatusPesanan == "Siap Diambil";
                if (!bisaAksi)
                {
                    dataGridView1.Rows[idx].Cells["colAksi"].Value = "";
                    dataGridView1.Rows[idx].Cells["colGagal"].Value = "";
                }
            }
        }

        private void DGV_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            var p = row.Tag as dynamic;
            if (p == null) return;

            if (e.ColumnIndex == dataGridView1.Columns["colAksi"].Index)
            {
                string status = p.StatusPesanan;
                if (status == "Diproses")
                {
                    _controller.UpdateStatus(p.IdPesanan, 2);
                    RefreshData();
                }
                else if (status == "Siap Diambil")
                {
                    _controller.UpdateStatus(p.IdPesanan, 3);
                    RefreshData();
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["colGagal"].Index)
            {
                string status = p.StatusPesanan;
                if (status != "Diproses" && status != "Siap Diambil") return;

                var konfirmasi = MessageBox.Show(
                    $"Yakin gagalkan pesanan #{p.IdPesanan}?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (konfirmasi == DialogResult.Yes)
                {
                    _controller.UpdateStatus(p.IdPesanan, 4);
                    RefreshData();
                }
            }
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _timer.Stop();
            base.OnFormClosed(e);
        }

        private void lblMejaTersedia_Click(object sender, EventArgs e) { }
    }
}