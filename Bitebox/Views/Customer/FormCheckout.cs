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
        private string jenisLayanan = "eatin";

        public FormCheckout(int idAkun)
        {
            InitializeComponent();
            this.idAkun = idAkun;
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            TampilkanRingkasan();
            LoadMejaTersedia();
            btneatin.BackColor = Color.FromArgb(255, 165, 81);
            btneatin.ForeColor = Color.White;
            btnTakeAway.BackColor = Color.FromArgb(255, 249, 243);
            btnTakeAway.ForeColor = Color.FromArgb(128, 66, 50);

            btneatin.Click += btneatin_Click;
            btnTakeAway.Click += btnTakeAway_Click;
            btnberanda.Click += btnberanda_Click;
            btnkeranjang.Click += btnkeranjang_Click;
            btnkeluar.Click += btnkeluar_Click;
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

        private void btneatin_Click(object sender, EventArgs e)
        {
            jenisLayanan = "eatin";
            btneatin.BackColor = Color.FromArgb(255, 165, 81);
            btneatin.ForeColor = Color.White;
            btnTakeAway.BackColor = Color.FromArgb(255, 249, 243);
            btnTakeAway.ForeColor = Color.FromArgb(128, 66, 50);
            panel1.Visible = true;
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            jenisLayanan = "takeaway";
            btnTakeAway.BackColor = Color.FromArgb(255, 165, 81);
            btnTakeAway.ForeColor = Color.White;
            btneatin.BackColor = Color.FromArgb(255, 249, 243);
            btneatin.ForeColor = Color.FromArgb(128, 66, 50);
            panel1.Visible = false;
        }

        private void btnKonfirmasiPesanan_Click(object sender, EventArgs e)
        {
            if (jenisLayanan == "eatin" && cmbNomorMeja.SelectedItem == null)
            {
                MessageBox.Show("Pilih nomor meja dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? idMeja = null;
            if (jenisLayanan == "eatin")
            {
                string selected = cmbNomorMeja.SelectedItem?.ToString() ?? "";
                idMeja = int.Parse(selected.Split('-')[0].Trim());
            }

            try
            {
                using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("CALL checkout_pesanan(@idAkun, @jenis, @idMeja)", conn))
                    {
                        cmd.Parameters.AddWithValue("@idAkun", idAkun);
                        cmd.Parameters.AddWithValue("@jenis", jenisLayanan);
                        cmd.Parameters.AddWithValue("@idMeja", idMeja.HasValue ? (object)idMeja.Value : DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                KeranjangSession.Clear();
                MessageBox.Show("Pesanan berhasil dikonfirmasi!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMenuUtama formMenu = new FormMenuUtama("", idAkun);
                formMenu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var konfirmasi = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (konfirmasi == DialogResult.Yes)
            {
                KeranjangSession.Clear();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
        }

        private void pnlsidebar_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { }

        private void btnkeranjang_Click_1(object sender, EventArgs e)
        {
            FormKeranjang formKeranjang = new FormKeranjang(idAkun);
            formKeranjang.Show();
            this.Hide();
        }

        private void btnriwayat_Click(object sender, EventArgs e)
        {
            FormRiwayat formRiwayat = new FormRiwayat(idAkun);
            formRiwayat.Show();
            this.Close();
        }
    }
}