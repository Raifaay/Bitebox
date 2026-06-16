using System;
using System.Collections.Generic;
using Npgsql;
using Bitebox.Helpers;

namespace Bitebox.Models.Context
{
    internal class PesananContext
    {
        public List<dynamic> GetPesananHariIni(string? filterStatus = null)
        {
            var list = new List<dynamic>();

            string query = "SELECT * FROM get_pesanan_hari_ini(@status)";

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@status", string.IsNullOrEmpty(filterStatus) ? (object)DBNull.Value : filterStatus);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new
                {
                    IdPesanan = Convert.ToInt32(reader["id_pesanan"]),
                    NamaCustomer = reader["nama_lengkap"]?.ToString() ?? "",
                    Tanggal = Convert.ToDateTime(reader["tanggal_pesanan"]),
                    KodePickup = reader["kode_pickup"] as string,
                    MetodePembayaran = reader["metode_pembayaran"]?.ToString() ?? "",
                    NomorMeja = reader["nomor_meja"] as string,
                    StatusPesanan = reader["nama_status_pesanan"]?.ToString() ?? "",
                    StatusPembayaran = reader["nama_status_pembayaran"]?.ToString() ?? "",
                    Total = Convert.ToDecimal(reader["total"])
                });
            }
            return list;
        }

        public int GetCountByStatus(string namaStatus)
        {
            string query = @"SELECT COUNT(*) FROM pesanan p
                            JOIN status_pesanan sp ON p.id_status_pesanan = sp.id_status_pesanan
                            WHERE DATE(p.tanggal_pesanan) = CURRENT_DATE AND sp.nama_status_pesanan = @status";

            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", namaStatus);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public int GetTotalHariIni()
        {
            string query = "SELECT COUNT(*) FROM pesanan WHERE DATE(tanggal_pesanan) = CURRENT_DATE";
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(query, conn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool UpdateStatusPesanan(int idPesanan, int idStatus)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("CALL update_status_pesanan(@id, @status)", conn);
            cmd.Parameters.AddWithValue("@id", idPesanan);
            cmd.Parameters.AddWithValue("@status", idStatus);
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}