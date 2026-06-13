using System;
using System.Drawing;
using System.Windows.Forms;
using Bitebox.Helpers;
using Bitebox.Models.Context;

namespace Bitebox.Views.Customer
{
    public partial class FormCheckout : Form
    {
        private int idAkun;
        private string jenisLayanan = "dinein";
        private string metodePembayaran = "tunai";
        private CheckoutContext checkoutContext = new CheckoutContext();

        public FormCheckout(int idAkun)
        {
            InitializeComponent();
            this.idAkun = idAkun;
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            TampilkanRingkasan();
            LoadMejaTersedia();
            panel1.Visible = true;
            jenisLayanan = "dinein";
        }

        private void TampilkanRingkasan()
        {
            FlowRingkasan.Controls.Clear();
            FlowRingkasan.FlowDirection = FlowDirection.TopDown;
            FlowRingkasan.WrapContents = false;
            FlowRingkasan.AutoScroll = true;

            foreach (var item in KeranjangSession.Items)
            {
                Label lbl = new Label();
                lbl.Text = $"{item.NamaMenu}  x{item.Jumlah}  →  Rp {item.Subtotal:N0}";
                lbl.Font = new Font("Segoe UI", 11);
                lbl.ForeColor = Color.FromArgb(128, 66, 50);
                lbl.AutoSize = true;
                lbl.Padding = new Padding(5);
                FlowRingkasan.Controls.Add(lbl);
            }

            lblTotal.Text = $"Rp {KeranjangSession.TotalHarga():N0}";
        }

        private void LoadMejaTersedia()
        {
            cmbNomorMeja.Items.Clear();
            try
            {
                var listMeja = checkoutContext.GetMejaTersedia();
                foreach (var meja in listMeja)
                    cmbNomorMeja.Items.Add(meja);
                if (cmbNomorMeja.Items.Count > 0)
                    cmbNomorMeja.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data meja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndinein_Click(object sender, EventArgs e)
        {
            jenisLayanan = "dinein";
            panel1.Visible = true;
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            jenisLayanan = "takeaway";
            panel1.Visible = false;
        }

        private void btnTunai_Click(object sender, EventArgs e)
        {
            metodePembayaran = "tunai";
        }

        private void btnNonTunai_Click(object sender, EventArgs e)
        {
            metodePembayaran = "non-tunai";
        }

        private void btnKonfirmasiPesanan_Click(object sender, EventArgs e)
        {
            if (KeranjangSession.Items.Count == 0)
            {
                MessageBox.Show("Keranjang belanja kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? idMeja = null;
            if (jenisLayanan == "dinein")
            {
                if (cmbNomorMeja.SelectedItem == null)
                {
                    MessageBox.Show("Pilih nomor meja dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string selected = cmbNomorMeja.SelectedItem.ToString() ?? "";
                idMeja = int.Parse(selected.Split('-')[0].Trim());
            }

            try
            {
                int idPesanan = checkoutContext.Checkout(idAkun, jenisLayanan, idMeja, metodePembayaran);
                string? kodePickup = checkoutContext.GetKodePickup(idPesanan);
                KeranjangSession.Clear();

                if (jenisLayanan == "takeaway")
                    MessageBox.Show($"Pesanan Take Away Berhasil!\n\nNomor Pesanan: #{idPesanan}\nKode Pickup: {kodePickup}",
                        "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Pesanan Dine In Berhasil!\n\nNomor Pesanan: #{idPesanan}",
                        "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormMenuUtama formMenu = new FormMenuUtama("", idAkun);
                formMenu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaksi Gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnkeranjang_Click(object sender, EventArgs e)
        {
            FormKeranjang formKeranjang = new FormKeranjang(idAkun);
            formKeranjang.Show();
            this.Close();
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            NavigationHelper.KeluarKeLogin(this);
        }

        private void btnriwayat_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat(idAkun);
            formRiwayat.Show();
            this.Close();
        }

    }
}