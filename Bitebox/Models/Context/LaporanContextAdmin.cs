using Bitebox.Helpers;
using Bitebox.Models.Entity;
using Npgsql;

namespace Bitebox.Models.Context
{
    internal class LaporanContextAdmin
    {
        public int GetTotalPenjualan(string periode = "bulan")
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT get_total_penjualan(@periode)", conn);
            cmd.Parameters.AddWithValue("@periode", periode);
            return Convert.ToInt32(cmd.ExecuteScalar()!);
        }

        public int GetTotalTransaksi(string periode = "bulan")
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT get_total_transaksi(@periode)", conn);
            cmd.Parameters.AddWithValue("@periode", periode);
            return Convert.ToInt32(cmd.ExecuteScalar()!);
        }

        public List<LaporanItem> GetLaporan(string periode = "bulan", string? filterKategori = null)
        {
            var list = new List<LaporanItem>();
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM get_laporan_per_menu(@periode, @kategori)", conn);
            cmd.Parameters.AddWithValue("@periode", periode);
            cmd.Parameters.Add("@kategori", NpgsqlTypes.NpgsqlDbType.Text).Value = (object?)filterKategori ?? DBNull.Value;
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
            return list;
        }

        public List<LaporanRollup> GetLaporanRollup(string periode = "bulan")
        {
            var list = new List<LaporanRollup>();
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM get_laporan_per_kategori(@periode)", conn);
            cmd.Parameters.AddWithValue("@periode", periode);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new LaporanRollup
                {
                    Kategori = reader["nama_kategori"]?.ToString() ?? "",
                    NamaMenu = "-",
                    JumlahTerjual = Convert.ToInt32(reader["jumlah_terjual"]),
                    TotalPendapat = Convert.ToInt32(reader["total_pendapat"])
                });
            }
            return list;
        }

        public List<string> GetSemuaKategori()
        {
            var list = new List<string>();
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT nama_kategori FROM kategori_menu ORDER BY nama_kategori", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add(reader["nama_kategori"]?.ToString() ?? "");
            return list;
        }
    }
}