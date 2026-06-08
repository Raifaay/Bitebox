using System;
using System.Drawing;
using System.Windows.Forms;
using Bitebox.Helpers;
using Bitebox.Models.Entity;

namespace Bitebox.Views.Customer
{
    public partial class FormKeranjang : Form
    {
        public FormKeranjang()
        {
            InitializeComponent();
        }

        private void FormKeranjang_Load(object sender, EventArgs e)
        {
            TampilkanKeranjang();
        }

        private void TampilkanKeranjang()
        {
            FlowKeranjang.Controls.Clear();
            FlowKeranjang.AutoScroll = true;
            FlowKeranjang.FlowDirection = FlowDirection.TopDown;
            FlowKeranjang.WrapContents = false;

            foreach (KeranjangItem item in KeranjangSession.Items)
            {
                Panel baris = BuatBarisItem(item);
                FlowKeranjang.Controls.Add(baris);
            }

            lblharga.Text = $"Rp {KeranjangSession.TotalHarga():N0}";
        }

        private Panel BuatBarisItem(KeranjangItem item)
        {
            Panel baris = new Panel();
            baris.Size = new Size(1230, 130);
            baris.BackColor = Color.FromArgb(255, 240, 222);
            baris.Margin = new Padding(0, 0, 0, 5);

            Label lblNama = new Label();
            lblNama.Text = item.NamaMenu;
            lblNama.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblNama.ForeColor = Color.FromArgb(128, 66, 50);
            lblNama.Location = new Point(15, 15);
            lblNama.Size = new Size(400, 25);

            Label lblHarga = new Label();
            lblHarga.Text = $"Rp {item.HargaMenu:N0}";
            lblHarga.Font = new Font("Segoe UI", 9);
            lblHarga.ForeColor = Color.FromArgb(255, 140, 0);
            lblHarga.Location = new Point(15, 45);
            lblHarga.Size = new Size(200, 20);

            Button btnPlus = new Button();
            btnPlus.Text = "+";
            btnPlus.Size = new Size(50, 50);
            btnPlus.Location = new Point(700, 40);
            btnPlus.BackColor = Color.FromArgb(255, 165, 81);
            btnPlus.ForeColor = Color.White;
            btnPlus.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Click += (s, e) => { item.Jumlah++; TampilkanKeranjang(); };
            btnPlus.Location = new Point(900, 30);
            

            Label lblJumlah = new Label();
            lblJumlah.Text = item.Jumlah.ToString();
            lblJumlah.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblJumlah.Location = new Point(960, 37);
            lblJumlah.Size = new Size(40, 35);
            lblJumlah.TextAlign = ContentAlignment.MiddleCenter;
            btnPlus.Location = new Point(900, 30);

            Button btnMinus = new Button();
            btnMinus.Text = "-";
            btnMinus.Size = new Size(50, 50);
            btnMinus.Location = new Point(1010, 30);
            btnMinus.BackColor = Color.FromArgb(255, 165, 81);
            btnMinus.ForeColor = Color.White;
            btnMinus.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Click += (s, e) =>
            {
                if (item.Jumlah > 1) item.Jumlah--;
                else KeranjangSession.HapusItem(item.IdMenu);
                TampilkanKeranjang();
            };

            Label lblSubtotal = new Label();
            lblSubtotal.Text = $"Sub Total:  Rp {item.Subtotal:N0}";
            lblSubtotal.Font = new Font("Segoe UI", 9);
            lblSubtotal.ForeColor = Color.Gray;
            lblSubtotal.Location = new Point(900, 90);
            lblSubtotal.Size = new Size(300, 20);

            Button btnHapus = new Button();
            btnHapus.Location = new Point(1270, 0);
            btnHapus.BackColor = Color.Red;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.BackgroundImage = Properties.Resources.sampahkeranjang;
            btnHapus.BackgroundImageLayout = ImageLayout.Center;
            btnHapus.Click += (s, e) =>
            {
                KeranjangSession.HapusItem(item.IdMenu);
                TampilkanKeranjang();
            };

            baris.Controls.Add(lblNama);
            baris.Controls.Add(lblHarga);
            baris.Controls.Add(btnPlus);
            baris.Controls.Add(lblJumlah);
            baris.Controls.Add(btnMinus);
            baris.Controls.Add(lblSubtotal);
            baris.Controls.Add(btnHapus);

            return baris;
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

        private void lblKeranjangPesanan_Click(object sender, EventArgs e) { }

        private void btnsampah_Click(object sender, EventArgs e)
        {
           
            if (KeranjangSession.Items.Count == 0)
            {
                MessageBox.Show("Keranjang sudah kosong!");
                return;
            }
            var konfirmasi = MessageBox.Show("Hapus semua item dari keranjang?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == DialogResult.Yes)
            {
                KeranjangSession.Clear();
                TampilkanKeranjang();
            
        }
    }
    }
}