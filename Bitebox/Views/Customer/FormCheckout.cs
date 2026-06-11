using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using Bitebox.Helpers;

namespace Bitebox.Views.Customer
{
    public partial class FormCheckout : Form
    {
        private int idAkun;
        private string jenisLayanan = "dinein";
        private string metodePembayaran = "tunai";

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
            string query = "SELECT id_meja, nomor_meja FROM meja WHERE status_meja = 'Tersedia'";

            try
            {
                using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbNomorMeja.Items.Add($"{reader["id_meja"]} - {reader["nomor_meja"]}");
                            }
                        }
                    }
                }

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
                if (cmbNomorMeja.SelectedItem == null || string.IsNullOrEmpty(cmbNomorMeja.SelectedItem.ToString()))
                {
                    MessageBox.Show("Pilih nomor meja dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selected = cmbNomorMeja.SelectedItem.ToString() ?? "";
                idMeja = int.Parse(selected.Split('-')[0].Trim());
            }
            else
            {
                idMeja = null;
            }

            try
            {
                using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("CALL checkout_pesanan(@p_id_akun, @p_jenis_layanan, @p_id_meja, @p_metode_pembayaran::metode_pembayaran_enum)", conn))
                    {
                        cmd.Parameters.AddWithValue("@p_id_akun", idAkun);
                        cmd.Parameters.AddWithValue("@p_jenis_layanan", jenisLayanan);
                        cmd.Parameters.AddWithValue("@p_id_meja", idMeja.HasValue ? (object)idMeja.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@p_metode_pembayaran", metodePembayaran);
                        cmd.ExecuteNonQuery();
                    }

                    int idPesanan = 0;
                    string? kodePickup = null;

                    using (NpgsqlCommand cmdGet = new NpgsqlCommand(
                        "SELECT id_pesanan, kode_pickup FROM pesanan WHERE id_akun = @idAkun ORDER BY tanggal_pesanan DESC LIMIT 1", conn))
                    {
                        cmdGet.Parameters.AddWithValue("@idAkun", idAkun);
                        using (NpgsqlDataReader reader = cmdGet.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPesanan = Convert.ToInt32(reader["id_pesanan"]);
                                kodePickup = reader["kode_pickup"]?.ToString();
                            }
                        }
                    }

                    foreach (var item in KeranjangSession.Items)
                    {
                        string qDetail = "INSERT INTO detail_pesanan (harga_saat_transaksi, jumlah, subtotal, id_menu, id_pesanan) VALUES (@harga_saat_transaksi, @jumlah, @subtotal, @id_menu, @id_pesanan)";
                        using (NpgsqlCommand cmdDetail = new NpgsqlCommand(qDetail, conn))
                        {
                            int hargaSatuan = (int)(item.Subtotal / item.Jumlah);

                            cmdDetail.Parameters.AddWithValue("@harga_saat_transaksi", hargaSatuan);
                            cmdDetail.Parameters.AddWithValue("@jumlah", item.Jumlah);
                            cmdDetail.Parameters.AddWithValue("@subtotal", (int)item.Subtotal);
                            cmdDetail.Parameters.AddWithValue("@id_menu", item.IdMenu);
                            cmdDetail.Parameters.AddWithValue("@id_pesanan", idPesanan);

                            cmdDetail.ExecuteNonQuery();
                        }
                    }

                    KeranjangSession.Clear();

                    if (jenisLayanan == "takeaway")
                    {
                        MessageBox.Show($"Pesanan Take Away Berhasil!\n\nNomor Pesanan: #{idPesanan}\nKode Pickup: {kodePickup}",
                            "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Pesanan Dine In Berhasil!\n\nNomor Pesanan: #{idPesanan}",
                            "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

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
            var konfirmasi = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (konfirmasi == DialogResult.Yes)
            {
                KeranjangSession.Clear();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private void btnriwayat_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat(idAkun);
            formRiwayat.Show();
            this.Close();
        }

        private void btnkeranjang_Click_1(object sender, EventArgs e)
        {
            FormKeranjang formKeranjang = new FormKeranjang(idAkun);
            formKeranjang.Show();
            this.Hide();
        }

        private void pnlsidebar_Paint(object sender, PaintEventArgs e) { }
    }
}