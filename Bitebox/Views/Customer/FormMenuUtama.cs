using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bitebox.Controllers;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Views
{
    public partial class FormMenuUtama : Form
    {
        private MenuController menuController = new MenuController();
        private string namaCustomer = "";

        public FormMenuUtama(string nama)
        {
            InitializeComponent();
            this.namaCustomer = nama;
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
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();

            int index = 0;
            foreach (MenuEntity menu in listMenu)
            {
                Panel kartu = BuatKartuMenu(menu);
                if (index == 0) flowLayoutPanel1.Controls.Add(kartu);
                else if (index == 1) flowLayoutPanel2.Controls.Add(kartu);
                else if (index == 2) flowLayoutPanel3.Controls.Add(kartu);
                index++;
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
            gambar.BackColor = Color.LightGray;

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
                    gambar.BackColor = Color.LightGray;
                }
            }
            else
            {
                gambar.BackColor = Color.LightGray;
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
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void pcblogo_Click(object sender, EventArgs e) { }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}