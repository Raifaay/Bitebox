using System;
using System.Collections.Generic;
using Npgsql;
using Bitebox.Helpers;
using Bitebox.Models.Entity;

namespace Bitebox.Models.Context
{
    internal class RiwayatContext
    {
        public List<RiwayatItem> GetRiwayatByAkun(int idAkun)
        {
            List<RiwayatItem> list = new List<RiwayatItem>();
            string query = "SELECT * FROM view_riwayat_pesanan WHERE id_akun = @idAkun ORDER BY tanggal_pesanan DESC";
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idAkun", idAkun);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new RiwayatItem
                            {
                                IdPesanan = (int)reader["id_pesanan"],
                                TanggalPesanan = (DateTime)reader["tanggal_pesanan"],
                                KodePickup = reader["kode_pickup"] as string,
                                NomorMeja = reader["nomor_meja"] as string,
                                NamaStatus = reader["nama_status_pesanan"]?.ToString() ?? "",
                                Total = reader["total"] == DBNull.Value ? 0 : Convert.ToInt32(reader["total"])
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}