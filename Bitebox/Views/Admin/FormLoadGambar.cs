using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using Bitebox.Helpers;

namespace Bitebox.Views.Admin
{
    public partial class FormLoadGambar : Form
    {
        public FormLoadGambar()
        {
            InitializeComponent();
        }

        private void FormLoadGambar_Load(object sender, EventArgs e)
        {
            LoadDaftarMenu();
        }

        private void LoadDaftarMenu()
        {
            cmbMenu.Items.Clear();
            string query = "SELECT id_menu, nama_menu FROM menu ORDER BY id_menu";

            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbMenu.Items.Add($"{reader["id_menu"]} - {reader["nama_menu"]}");
                        }
                    }
                }
            }
        }

        private void btnpilihgambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pcbPreview.Image = Image.FromFile(dialog.FileName);
                pcbPreview.SizeMode = PictureBoxSizeMode.Zoom;
                pcbPreview.Tag = dialog.FileName;
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (cmbMenu.SelectedItem == null || pcbPreview.Tag == null)
            {
                MessageBox.Show("Pilih menu dan gambar dulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selected = cmbMenu.SelectedItem.ToString() ?? "";
            int idMenu = int.Parse(selected.Split('-')[0].Trim());
            byte[] gambarBytes = File.ReadAllBytes(pcbPreview.Tag.ToString() ?? "");

            string query = "UPDATE menu SET gambar_menu = @gambar WHERE id_menu = @id";

            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@gambar", gambarBytes);
                    cmd.Parameters.AddWithValue("@id", idMenu);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Gambar berhasil disimpan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}