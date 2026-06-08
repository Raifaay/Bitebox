using Bitebox.Controllers;
using Bitebox.Models.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Views.Admin
{
    public partial class FormPengelolaMenu : Form
    {
        private MenuControllerAdmin menuController = new MenuControllerAdmin();
        private MenuEntity? menuYangDiedit = null;
        private byte[]? gambarDipilih = null;

        private Panel pnlInput = null!;
        private TextBox txtNama = null!, txtDeskripsi = null!;
        private NumericUpDown nudHarga = null!;
        private ComboBox cmbKategori = null!;
        private PictureBox pbGambar = null!;
        public FormPengelolaMenu()
        {
            InitializeComponent();
            BuatPanelInput();
            TampilkanMenu();

        }

        private void BuatPanelInput()
        {
            pnlInput = new Panel
            {
                Location = new Point(295, 155),
                Size = new Size(1590, 220),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            var lblNama = new Label { Text = "Nama Menu", Location = new Point(15, 15), AutoSize = true };
            txtNama = new TextBox
            {
                Location = new Point(15, 35),
                Size = new Size(260, 28),
                Font = new Font("Segoe UI", 10)
            };

            var lblHarga = new Label { Text = "Harga (Rp)", Location = new Point(295, 15), AutoSize = true };
            nudHarga = new NumericUpDown
            {
                Location = new Point(295, 35),
                Size = new Size(180, 28),
                Font = new Font("Segoe UI", 10),
                Maximum = 9999999,
                ThousandsSeparator = true,
                Increment = 1000
            };

            var lblKategori = new Label { Text = "Kategori", Location = new Point(495, 15), AutoSize = true };
            cmbKategori = new ComboBox
            {
                Location = new Point(495, 35),
                Size = new Size(180, 28),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cmbKategori.Items.AddRange(new object[]
            {
                new KategoriItem(1, "Burger"),
                new KategoriItem(2, "Pizza"),
                new KategoriItem(3, "Minuman")
            });
            cmbKategori.SelectedIndex = 0;

            var lblDeskripsi = new Label { Text = "Deskripsi", Location = new Point(695, 15), AutoSize = true };
            txtDeskripsi = new TextBox
            {
                Location = new Point(695, 35),
                Size = new Size(350, 60),
                Font = new Font("Segoe UI", 10),
                Multiline = true
            };

            var lblGambar = new Label { Text = "Gambar", Location = new Point(1065, 15), AutoSize = true };
            pbGambar = new PictureBox
            {
                Location = new Point(1065, 35),
                Size = new Size(60, 60),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            var btnPilihGambar = new Button
            {
                Text = "Pilih Gambar",
                Location = new Point(1135, 35),
                Size = new Size(120, 32),
                Cursor = Cursors.Hand
            };
            btnPilihGambar.Click += PilihGambar;

            var btnSimpan = new Button
            {
                Text = "Simpan",
                Location = new Point(1375, 35),
                Size = new Size(95, 35),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.Click += Simpan;

            var btnBatal = new Button
            {
                Text = "Batal",
                Location = new Point(1480, 35),
                Size = new Size(85, 35),
                BackColor = Color.Tomato,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnBatal.FlatAppearance.BorderSize = 0;
            btnBatal.Click += (s, e) => SembunyikanInput();

            pnlInput.Controls.AddRange(new Control[]
           {
                lblNama, txtNama,
                lblHarga, nudHarga,
                lblKategori, cmbKategori,
                lblDeskripsi, txtDeskripsi,
                lblGambar, pbGambar, btnPilihGambar,
                btnSimpan, btnBatal
           });

            this.Controls.Add(pnlInput);
            pnlInput.BringToFront();
        }

        private void TampilkanMenu()
        {
            fLPMenu.Controls.Clear();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();

            List<MenuEntity> daftarMenu = menuController.GetAllMenu();

            if (daftarMenu.Count == 0)
            {
                fLPMenu.Controls.Add(new Label
                {
                    Text = "Belum ada menu. Klik Tambah untuk menambahkan.",
                    Font = new Font("Segoe UI", 10),
                    ForeColor = Color.Gray,
                    AutoSize = true,
                    Margin = new Padding(10)
                });
                return;
            }

            for (int i = 0; i < daftarMenu.Count; i++)
            {
                Panel kartu = BuatKartu(daftarMenu[i]);

                if (i % 3 == 0) fLPMenu.Controls.Add(kartu);
                else if (i % 3 == 1) flowLayoutPanel1.Controls.Add(kartu);
                else flowLayoutPanel2.Controls.Add(kartu);
            }
        }

        private Panel BuatKartu(MenuEntity menu)
        {
            var kartu = new Panel
            {
                Size = new Size(270, 300),
                BackColor = Color.White,
                Margin = new Padding(8)
            };

            kartu.Paint += (s, e) =>
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(220, 220, 220)), 0, 0, kartu.Width - 1, kartu.Height - 1);

            var gambar = new PictureBox
            {
                Size = new Size(270, 150),
                Location = new Point(0, 0),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(240, 240, 240)
            };

            if (menu.GambarMenu?.Length > 0)
            {
                try
                {
                    using var ms = new MemoryStream(menu.GambarMenu);
                    gambar.Image = new Bitmap(ms);
                }
                catch { }
            }

            var lblNama = new Label
            {
                Text = menu.NamaMenu,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 158),
                Size = new Size(250, 24),
                AutoEllipsis = true
            };

            var lblHarga = new Label
            {
                Text = $"Rp {menu.HargaMenu:N0}",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.ForestGreen,
                Location = new Point(10, 184),
                Size = new Size(250, 20)
            };

            var lblDeskripsi = new Label
            {
                Text = string.IsNullOrWhiteSpace(menu.DeskripsiMenu) ? "-" : menu.DeskripsiMenu,
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.DimGray,
                Location = new Point(10, 206),
                Size = new Size(250, 36),
                AutoEllipsis = true
            };

            var btnEdit = new Button
            {
                Text = "Edit",
                Size = new Size(118, 32),
                Location = new Point(8, 258),
                BackColor = Color.DodgerBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += (s, e) => TampilkanInputUntukEdit(menu);

            var btnHapus = new Button
            {
                Text = "Hapus",
                Size = new Size(118, 32),
                Location = new Point(138, 258),
                BackColor = Color.Tomato,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.Click += (s, e) => HapusMenu(menu);

            kartu.Controls.AddRange(new Control[] { gambar, lblNama, lblHarga, lblDeskripsi, btnEdit, btnHapus });
            return kartu;
        }





        private void btnEdit1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            menuYangDiedit = null;
            gambarDipilih = null;
            BersihkanInput();
            pnlInput.Visible = true;
            pnlInput.BringToFront();
        }

        private void TampilkanInputUntukEdit(MenuEntity menu)
        {
            // mode edit, isi form dengan data menu yang dipilih
            menuYangDiedit = menu;
            txtNama.Text = menu.NamaMenu;
            nudHarga.Value = menu.HargaMenu;
            txtDeskripsi.Text = menu.DeskripsiMenu;

            foreach (KategoriItem item in cmbKategori.Items)
                if (item.Id == menu.IdKategoriMenu)
                { cmbKategori.SelectedItem = item; break; }

            if (menu.GambarMenu?.Length > 0)
            {
                try
                {
                    gambarDipilih = menu.GambarMenu;
                    using var ms = new MemoryStream(gambarDipilih);
                    pbGambar.Image = new Bitmap(ms);
                }
                catch { }
            }
            else
            {
                gambarDipilih = null;
                pbGambar.Image = null;
            }

            pnlInput.Visible = true;
            pnlInput.BringToFront();
        }

        private void PilihGambar(object? s, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Pilih Gambar Menu"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            gambarDipilih = File.ReadAllBytes(dialog.FileName);
            using var ms = new MemoryStream(gambarDipilih);
            pbGambar.Image = new Bitmap(ms);
        }

        private void Simpan(object? s, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama menu tidak boleh kosong!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (nudHarga.Value <= 0)
            {
                MessageBox.Show("Harga harus lebih dari 0!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudHarga.Focus();
                return;
            }


            var menu = new MenuEntity
            {
                NamaMenu = txtNama.Text.Trim(),
                HargaMenu = (int)nudHarga.Value,
                DeskripsiMenu = txtDeskripsi.Text.Trim(),
                GambarMenu = gambarDipilih,
                IdKategoriMenu = ((KategoriItem)cmbKategori.SelectedItem!).Id
            };

            bool berhasil;

            if (menuYangDiedit == null)
            {
                berhasil = menuController.TambahMenu(menu);
                MessageBox.Show(berhasil ? "Menu berhasil ditambahkan!" : "Gagal menambahkan menu.");
            }
            else
            {
                menu.IdMenu = menuYangDiedit.IdMenu;
                berhasil = menuController.UpdateMenu(menu);
                MessageBox.Show(berhasil ? "Menu berhasil diupdate!" : "Gagal mengupdate menu.");
            }

            if (berhasil)
            {
                SembunyikanInput();
                TampilkanMenu();
            }
        }

        private void HapusMenu(MenuEntity menu)
        {
            var jawab = MessageBox.Show(
                $"Yakin mau hapus \"{menu.NamaMenu}\"?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (jawab != DialogResult.Yes) return;

            bool berhasil = menuController.HapusMenu(menu.IdMenu);
            MessageBox.Show(berhasil ? "Menu berhasil dihapus!" : "Gagal menghapus menu.");

            if (berhasil) TampilkanMenu();
        }

        private void BersihkanInput()
        {
            txtNama.Text = "";
            nudHarga.Value = 0;
            txtDeskripsi.Text = "";
            cmbKategori.SelectedIndex = 0;
            pbGambar.Image = null;
        }

        private void SembunyikanInput()
        {
            menuYangDiedit = null;
            gambarDipilih = null;
            BersihkanInput();
            pnlInput.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard form = new FormDashboard();
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
                FormLogin fromLogin = new FormLogin();
                fromLogin.Show();
                this.Close();
            }
        }
    }

    public class KategoriItem
    {
        public int Id { get; }
        public string Nama { get; }

        public KategoriItem(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }

        public override string ToString() => Nama;
    }
}
