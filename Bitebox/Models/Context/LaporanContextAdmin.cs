using Bitebox.Helpers;
using Bitebox.Models.Entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Context
{
    internal class LaporanContextAdmin
    {
        // ambil total penjualan dari semua subtotal di detail_pesanan
        public int GetTotalPenjualan()
        {
            string query = "SELECT COALESCE(SUM(subtotal), 0) FROM detail_pesanan";

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                return (int)(long)cmd.ExecuteScalar()!; 
            }
        }

        // hitung jumlah pesanan yang ada
        public int GetTotalTransaksi()
        {
            string query = "SELECT COUNT(*) FROM pesanan";

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                return (int)(long)cmd.ExecuteScalar()!;//groupby
            }
        }

        // ambil data per menu - join ke menu dan kategori_menu buat dapat nama kategori
        public List<LaporanItem> GetLaporan(string? filterKategori = null)
        {
            var list = new List<LaporanItem>();

            string query = @"
                SELECT 
                    dp.nama_menu,
                    km.nama_kategori,
                    SUM(dp.jumlah) AS jumlah_terjual,
                    SUM(dp.subtotal) AS total_pendapat
                FROM detail_pesanan dp
                JOIN menu m ON dp.id_menu = m.id_menu
                JOIN kategori_menu km ON m.id_kategori_menu = km.id_kategori_menu
                WHERE (@kategori IS NULL OR km.nama_kategori = @kategori)
                GROUP BY dp.nama_menu, km.nama_kategori
                ORDER BY jumlah_terjual DESC"; //bungkus

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.Add("@kategori", NpgsqlTypes.NpgsqlDbType.Text).Value =
                    (object?)filterKategori ?? DBNull.Value;

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new LaporanItem
                    {
                        NamaMenu = reader["nama_menu"]?.ToString() ?? "",
                        Kategori = reader["nama_kategori"]?.ToString() ?? "",
                        JumlahTerjual = Convert.ToInt32(reader["jumlah_terjual"]),
                        TotalPendapat = Convert.ToInt32(reader["total_pendapat"])
                    });
                }
            }
            return list;
        }
        // ambil semua nama kategori buat isi combobox
        public List<string> GetSemuaKategori()
        {
            var list = new List<string>();
            string query = "SELECT nama_kategori FROM kategori_menu ORDER BY nama_kategori";

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(reader["nama_kategori"]?.ToString() ?? "");
            }
            return list;
        }
    }
}
