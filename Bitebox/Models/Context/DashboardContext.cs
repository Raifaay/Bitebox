using Bitebox.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using Bitebox.Models.Entity; 

namespace Bitebox.Models.Context
{
    public class DashboadContext
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

                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COALESCE(SUM(total_penghasilan), 0) FROM pesanan", conn))
                {
                    stats.TotalPenghasilan = Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            return stats;
        }
    }
}
