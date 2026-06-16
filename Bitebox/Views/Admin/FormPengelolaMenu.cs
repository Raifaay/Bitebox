using Bitebox.Controllers;
using Bitebox.Models.Entity;
using System.IO;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Views.Admin
{
    public partial class FormPengelolaMenu : Form
    {
        private readonly MenuControllerAdmin _menuController = new MenuControllerAdmin();
        private MenuEntity? _menuYangDiedit = null;
        private byte[]? _gambarDipilih = null;
        private PictureBox _pbPreview = null!;

        public FormPengelolaMenu()
        {
            InitializeComponent();
            pnlTambahMenu.Visible = false;
            SiapkanKategori();
            SiapkanDGV();
            SiapkanPbPreview();
            SiapkanTombol();
            TampilkanMenu();
        }

        private void SiapkanKategori()
        {
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Items.Clear();
            cmbKategori.Items.AddRange(new object[]
            {
                new KategoriItem(1, "Burger"),
                new KategoriItem(2, "Pizza"),
                new KategoriItem(3, "Minuman")
            });
            cmbKategori.SelectedIndex = 0;
        }

        private void SiapkanPbPreview()
        {
            _pbPreview = new PictureBox
            {
                Location = new Point(16, 415),
                Size = new Size(369, 153),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 240, 240),
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };
            pnlTambahMenu.Controls.Add(_pbPreview);
            _pbPreview.BringToFront();
        }

        private void SiapkanTombol()
        {
            button8.Text = "Simpan";
            button8.Click += Simpan;
            btnBatal.Click += (s, e) => SembunyikanForm();
            btnUploadGambar.Click += PilihGambar;

            button6.Click += (s, e) => { new FormBeranda().Show(); this.Close(); };
            button2.Click += (s, e) =>
            {
                var r = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes) { new FormLogin().Show(); this.Close(); }
            };
            button3.Click += (s, e) => { new FormKelolaCustomer().Show(); this.Close(); };
            button4.Click += (s, e) => { new FormLaporanPenjualan().Show(); this.Close(); };
            button1.Click += (s, e) => { new FormPengelolaPesanan().Show(); this.Close(); };
        }

        private void SiapkanDGV()
        {
            dgvPengelolaMenu.Columns.Clear();
            dgvPengelolaMenu.AllowUserToAddRows = false;
            dgvPengelolaMenu.ReadOnly = true;
            dgvPengelolaMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPengelolaMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPengelolaMenu.EnableHeadersVisualStyles = false;
            dgvPengelolaMenu.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 126, 34);
            dgvPengelolaMenu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPengelolaMenu.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvPengelolaMenu.ColumnHeadersHeight = 45;
            dgvPengelolaMenu.RowTemplate.Height = 55;
            dgvPengelolaMenu.BorderStyle = BorderStyle.None;
            dgvPengelolaMenu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPengelolaMenu.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvPengelolaMenu.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 220, 180);
            dgvPengelolaMenu.DefaultCellStyle.SelectionForeColor = Color.FromArgb(128, 66, 50);

            dgvPengelolaMenu.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNama", HeaderText = "Nama Menu" });
            dgvPengelolaMenu.Columns.Add(new DataGridViewTextBoxColumn { Name = "colKategori", HeaderText = "Kategori" });
            dgvPengelolaMenu.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHarga", HeaderText = "Harga" });

            var colEdit = new DataGridViewButtonColumn
            {
                Name = "colEdit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };
            var colHapus = new DataGridViewButtonColumn
            {
                Name = "colHapus",
                HeaderText = "Hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 100
            };

            dgvPengelolaMenu.Columns.Add(colEdit);
            dgvPengelolaMenu.Columns.Add(colHapus);

            dgvPengelolaMenu.CellClick += DGV_CellClick;
        }

        private void TampilkanMenu()
        {
            dgvPengelolaMenu.Rows.Clear();
            var list = _menuController.GetAllMenu();
            foreach (var m in list)
            {
                string kategori = m.IdKategoriMenu switch { 1 => "Burger", 2 => "Pizza", 3 => "Minuman", _ => "-" };
                int idx = dgvPengelolaMenu.Rows.Add(m.NamaMenu, kategori, $"Rp {m.HargaMenu:N0}");
                dgvPengelolaMenu.Rows[idx].Tag = m;
            }
        }

        private void DGV_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var menu = dgvPengelolaMenu.Rows[e.RowIndex].Tag as MenuEntity;
            if (menu == null) return;

            if (e.ColumnIndex == dgvPengelolaMenu.Columns["colEdit"].Index)
                TampilkanFormEdit(menu);
            else if (e.ColumnIndex == dgvPengelolaMenu.Columns["colHapus"].Index)
                HapusMenu(menu);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            _menuYangDiedit = null;
            _gambarDipilih = null;
            BersihkanForm();
            lblTambahMenu.Text = "Tambah Menu";
            pnlTambahMenu.Visible = true;
        }

        private void TampilkanFormEdit(MenuEntity menu)
        {
            _menuYangDiedit = menu;
            lblTambahMenu.Text = "Edit Menu";
            txtNamaMenu.Text = menu.NamaMenu;
            txtHargaMenu.Text = menu.HargaMenu.ToString();
            textBox1.Text = menu.DeskripsiMenu;

            foreach (KategoriItem item in cmbKategori.Items)
                if (item.Id == menu.IdKategoriMenu) { cmbKategori.SelectedItem = item; break; }

            if (menu.GambarMenu?.Length > 0)
            {
                try
                {
                    _gambarDipilih = menu.GambarMenu;
                    using var ms = new MemoryStream(_gambarDipilih);
                    _pbPreview.Image = new Bitmap(ms);
                    _pbPreview.Visible = true;
                    btnUploadGambar.Visible = false;
                }
                catch { }
            }
            else
            {
                _gambarDipilih = null;
                _pbPreview.Image = null;
                _pbPreview.Visible = false;
                btnUploadGambar.Visible = true;
            }

            pnlTambahMenu.Visible = true;
        }

        private void PilihGambar(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Pilih Gambar Menu"
            };
            if (dialog.ShowDialog() != DialogResult.OK) return;

            _gambarDipilih = File.ReadAllBytes(dialog.FileName);
            using var ms = new MemoryStream(_gambarDipilih);
            _pbPreview.Image = new Bitmap(ms);
            _pbPreview.Visible = true;
            btnUploadGambar.Visible = false;
        }

        private void Simpan(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaMenu.Text))
            {
                MessageBox.Show("Nama menu tidak boleh kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtHargaMenu.Text, out decimal harga) || harga <= 0)
            {
                MessageBox.Show("Harga tidak valid!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var menu = new MenuEntity
            {
                NamaMenu = txtNamaMenu.Text.Trim(),
                HargaMenu = (int)harga,
                DeskripsiMenu = textBox1.Text.Trim(),
                GambarMenu = _gambarDipilih ?? _menuYangDiedit?.GambarMenu, 
                IdKategoriMenu = ((KategoriItem)cmbKategori.SelectedItem!).Id
            };

            bool berhasil;
            if (_menuYangDiedit == null)
            {
                berhasil = _menuController.TambahMenu(menu);
                MessageBox.Show(berhasil ? "Menu berhasil ditambahkan!" : "Gagal menambahkan menu.");
            }
            else
            {
                menu.IdMenu = _menuYangDiedit.IdMenu;
                berhasil = _menuController.UpdateMenu(menu);
                MessageBox.Show(berhasil ? "Menu berhasil diupdate!" : "Gagal mengupdate menu.");
            }

            if (berhasil) { SembunyikanForm(); TampilkanMenu(); }
        }

        private void HapusMenu(MenuEntity menu)
        {
            var jawab = MessageBox.Show($"Yakin hapus \"{menu.NamaMenu}\"?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab != DialogResult.Yes) return;
            bool berhasil = _menuController.HapusMenu(menu.IdMenu);
            MessageBox.Show(berhasil ? "Menu berhasil dihapus!" : "Gagal menghapus menu.");
            if (berhasil) TampilkanMenu();
        }

        private void BersihkanForm()
        {
            txtNamaMenu.Text = "";
            txtHargaMenu.Text = "";
            textBox1.Text = "";
            cmbKategori.SelectedIndex = 0;
            _pbPreview.Image = null;
            _pbPreview.Visible = false;
            btnUploadGambar.Visible = true;
        }

        private void SembunyikanForm()
        {
            _menuYangDiedit = null;
            _gambarDipilih = null;
            BersihkanForm();
            pnlTambahMenu.Visible = false;
        }

        private void FormPengelolaMenu_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblTambahMenu_Click(object sender, EventArgs e) { }
        private void lblKategori_Click(object sender, EventArgs e) { }
        private void dgvPengelolaMenu_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }

    public class KategoriItem
    {
        public int Id { get; }
        public string Nama { get; }
        public KategoriItem(int id, string nama) { Id = id; Nama = nama; }
        public override string ToString() => Nama;
    }
}