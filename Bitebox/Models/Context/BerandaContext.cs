using Bitebox.Helpers;
using Bitebox.Models.Entity;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Bitebox.Models.Context
{
    public class BerandaContext
    {
        public Beranda GetDashboardStatsData()
        {
            Beranda stats = new Beranda();
            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM menu", conn))
                    stats.TotalProduk = Convert.ToInt64(cmd.ExecuteScalar());
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM pesanan", conn))
                    stats.TotalPenjualan = Convert.ToInt64(cmd.ExecuteScalar());
                using (var cmd = new NpgsqlCommand(@"
                    SELECT COALESCE(SUM(dp.subtotal), 0)
                    FROM detail_pesanan dp
                    JOIN pesanan p ON dp.id_pesanan = p.id_pesanan
                    WHERE p.id_status_pembayaran = 1", conn))
                    stats.TotalPenghasilan = Convert.ToDecimal(cmd.ExecuteScalar());
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM meja WHERE status_meja = 'Tersedia'", conn))
                    stats.MejaTersedia = Convert.ToInt32(cmd.ExecuteScalar());
                using (var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM meja", conn))
                    stats.TotalMeja = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return stats;
        }

        public List<MejaItem> GetStatusMeja()
        {
            var list = new List<MejaItem>();
            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_meja, nomor_meja, status_meja FROM meja ORDER BY nomor_meja", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MejaItem
                        {
                            IdMeja = reader.GetInt32(0),
                            NomorMeja = reader.GetString(1),
                            StatusMeja = reader.GetString(2)
                        });
                    }
                }
            }
            return list;
        }

        public void UpdateStatusMeja(int idMeja, string statusBaru)
        {
            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "UPDATE meja SET status_meja = @status::status_meja_enum WHERE id_meja = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@status", statusBaru);
                    cmd.Parameters.AddWithValue("@id", idMeja);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}