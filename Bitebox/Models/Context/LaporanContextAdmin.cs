using Bitebox.Helpers;
using Bitebox.Models.Entity;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Bitebox.Models.Context
{
    internal class LaporanContextAdmin
    {
        public int GetTotalPenjualan()
        {
            string query = "SELECT COALESCE(SUM(subtotal), 0) FROM detail_pesanan";
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar()!);
            }
        }

        public int GetTotalTransaksi()
        {
            string query = "SELECT COUNT(*) FROM pesanan";
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                return Convert.ToInt32(cmd.ExecuteScalar()!);
            }
        }

        public List<LaporanItem> GetLaporan(string? filterKategori = null)
        {
            var list = new List<LaporanItem>();
            string query = @"SELECT * FROM view_laporan_per_menu
                WHERE (@kategori IS NULL OR nama_kategori = @kategori)
                ORDER BY jumlah_terjual DESC";
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.Add("@kategori", NpgsqlTypes.NpgsqlDbType.Text).Value =
                    (object?)filterKategori ?? DBNull.Value;
                using var reader = cmd.ExecuteReader(); //ini masih crash
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

        public List<LaporanRollup> GetLaporanRollup()
        {
            var list = new List<LaporanRollup>();
            string query = "SELECT * FROM view_laporan_rollup";
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new LaporanRollup
                    {
                        Kategori = reader["nama_kategori"] == DBNull.Value ? "GRAND TOTAL" : reader["nama_kategori"].ToString()!,
                        NamaMenu = reader["nama_menu"] == DBNull.Value ? "-" : reader["nama_menu"].ToString()!,
                        JumlahTerjual = reader["jumlah_terjual"] == DBNull.Value ? 0 : Convert.ToInt32(reader["jumlah_terjual"]),
                        TotalPendapat = reader["total_pendapat"] == DBNull.Value ? 0 : Convert.ToInt32(reader["total_pendapat"])
                    });
                }
            }
            return list;
        }

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