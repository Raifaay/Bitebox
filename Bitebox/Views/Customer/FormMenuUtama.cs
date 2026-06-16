using Bitebox.Controllers;
using Bitebox.Helpers;
using Bitebox.Models.Entity;
using Bitebox.Views.Customer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Views
{
    public partial class FormMenuUtama : Form
    {
        private MenuController menuController = new MenuController();
        private string namaCustomer = "";
        private int idAkun;

        public FormMenuUtama(string nama, int idAkun)
        {
            InitializeComponent();
            this.namaCustomer = nama;
            this.idAkun = idAkun;
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            lblHai.Text = $"Hai, {namaCustomer}!";
            lbltanggal.Text = DateTime.Now.ToString("dd MMMM yyyy");
            TampilkanMenu(menuController.GetAllMenu());
        }

        private void TampilkanMenu(List<MenuEntity> listMenu)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoScroll = true;

            foreach (MenuEntity menu in listMenu)
            {
                Panel kartu = BuatKartuMenu(menu);
                flowLayoutPanel1.Controls.Add(kartu);
            }
        }

        private Panel BuatKartuMenu(MenuEntity menu)
        {
            Panel kartu = new Panel();
            kartu.Size = new Size(340, 180);
            kartu.BackColor = Color.White;
            kartu.Margin = new Padding(5);

            PictureBox gambar = new PictureBox();
            gambar.Size = new Size(120, 120);
            gambar.Location = new Point(10, 10);
            gambar.SizeMode = PictureBoxSizeMode.Zoom;
            gambar.BackColor = Color.White;

            if (menu.GambarMenu != null && menu.GambarMenu.Length > 0)
            {
                try
                {
                    using (var ms = new System.IO.MemoryStream(menu.GambarMenu))
                    {
                        gambar.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    gambar.BackColor = Color.White;
                }
            }
            else
            {
                gambar.BackColor = Color.White;
            }

            Label lblNama = new Label();
            lblNama.Text = menu.NamaMenu;
            lblNama.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNama.ForeColor = Color.FromArgb(128, 66, 50);
            lblNama.Location = new Point(140, 10);
            lblNama.Size = new Size(190, 40);

            Label lblDeskripsi = new Label();
            lblDeskripsi.Text = menu.DeskripsiMenu;
            lblDeskripsi.Font = new Font("Segoe UI", 8);
            lblDeskripsi.ForeColor = Color.Gray;
            lblDeskripsi.Location = new Point(140, 50);
            lblDeskripsi.Size = new Size(190, 50);

            Label lblHarga = new Label();
            lblHarga.Text = $"Rp {menu.HargaMenu:N0}";
            lblHarga.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblHarga.ForeColor = Color.FromArgb(255, 140, 0);
            lblHarga.Location = new Point(140, 100);
            lblHarga.Size = new Size(190, 30);

            Button btnTambah = new Button();
            btnTambah.Text = "Tambah";
            btnTambah.BackColor = Color.FromArgb(255, 165, 81);
            btnTambah.ForeColor = Color.White;
            btnTambah.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnTambah.Location = new Point(10, 140);
            btnTambah.Size = new Size(320, 35);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Tag = menu;

            btnTambah.Click += (s, e) =>
            {
                MenuEntity m = (MenuEntity)btnTambah.Tag;
                KeranjangSession.TambahItem(new KeranjangItem
                {
                    IdMenu = m.IdMenu,
                    NamaMenu = m.NamaMenu,
                    HargaMenu = m.HargaMenu,
                    Jumlah = 1,
                    IdAkun = this.idAkun
                });
                MessageBox.Show($"{m.NamaMenu} ditambahkan ke keranjang!");
            };

            kartu.Controls.Add(gambar);
            kartu.Controls.Add(lblNama);
            kartu.Controls.Add(lblDeskripsi);
            kartu.Controls.Add(lblHarga);
            kartu.Controls.Add(btnTambah);

            return kartu;
        }

        private void btnburger_Click(object sender, EventArgs e)
        {
            TampilkanMenu(menuController.GetMenuByKategori(1));
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            TampilkanMenu(menuController.GetMenuByKategori(2));
        }

        private void btnminuman_Click(object sender, EventArgs e)
        {
            TampilkanMenu(menuController.GetMenuByKategori(3));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            NavigationHelper.KeluarKeLogin(this);
        }

        private void btnkeranjang_Click(object sender, EventArgs e)
        {
            FormKeranjang formKeranjang = new FormKeranjang(idAkun);
            formKeranjang.Show();
            this.Hide();
        }

        private void btnriwayat_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat(idAkun);
            formRiwayat.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}