using Bitebox.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using Bitebox.Models.Entity; 

namespace Bitebox.Models.Context
{
    public class DashboardContext
    {
        public DashboardStats GetDashboardStatsData()
        {
            DashboardStats stats = new DashboardStats();

            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM menu", conn))
                {
                    stats.TotalProduk = Convert.ToInt64(cmd.ExecuteScalar());
                }

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM pesanan", conn))
                {
                    stats.TotalPenjualan = Convert.ToInt64(cmd.ExecuteScalar()); 

                }

                string queryPenghasilan = @"
                    SELECT COALESCE(SUM(dp.subtotal),0)
                    FROM detail_pesanan dp
                    JOIN pesanan p ON dp.id_pesanan = p.id_pesanan
                    WHERE p.id_status_pembayaran = 1"; 

                using (NpgsqlCommand cmd = new NpgsqlCommand(queryPenghasilan, conn))
                {
                    stats.TotalPenghasilan = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            return stats;
        }
    }
}
