using System;
using System.Collections.Generic;
using Npgsql;
using Bitebox.Helpers;
using Bitebox.Models.Entity;

namespace Bitebox.Models.Context
{
    internal class CheckoutContext
    {
        public int Checkout(int idAkun, string jenisLayanan, int? idMeja, string metodePembayaran)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(
                    "CALL checkout_pesanan(@p_id_akun, @p_jenis_layanan, @p_id_meja, @p_metode_pembayaran::metode_pembayaran_enum)", conn))
                {
                    cmd.Parameters.AddWithValue("@p_id_akun", idAkun);
                    cmd.Parameters.AddWithValue("@p_jenis_layanan", jenisLayanan);
                    cmd.Parameters.AddWithValue("@p_id_meja", idMeja.HasValue ? (object)idMeja.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@p_metode_pembayaran", metodePembayaran);
                    cmd.ExecuteNonQuery();
                }

                int idPesanan = 0;
                string? kodePickup = null;

                using (var cmd = new NpgsqlCommand(
                    "SELECT id_pesanan, kode_pickup FROM pesanan WHERE id_akun = @idAkun ORDER BY tanggal_pesanan DESC LIMIT 1", conn))
                {
                    cmd.Parameters.AddWithValue("@idAkun", idAkun);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idPesanan = Convert.ToInt32(reader["id_pesanan"]);
                            kodePickup = reader["kode_pickup"]?.ToString();
                        }
                    }
                }

                foreach (var item in KeranjangSession.Items)
                {
                    using (var cmd = new NpgsqlCommand(
                        "INSERT INTO detail_pesanan (harga_saat_transaksi, jumlah, subtotal, id_menu, id_pesanan) VALUES (@harga, @jumlah, @subtotal, @id_menu, @id_pesanan)", conn))
                    {
                        cmd.Parameters.AddWithValue("@harga", item.HargaMenu);
                        cmd.Parameters.AddWithValue("@jumlah", item.Jumlah);
                        cmd.Parameters.AddWithValue("@subtotal", item.Subtotal);
                        cmd.Parameters.AddWithValue("@id_menu", item.IdMenu);
                        cmd.Parameters.AddWithValue("@id_pesanan", idPesanan);
                        cmd.ExecuteNonQuery();
                    }
                }

                return idPesanan;
            }
        }

        public string? GetKodePickup(int idPesanan)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT kode_pickup FROM pesanan WHERE id_pesanan = @idPesanan", conn))
                {
                    cmd.Parameters.AddWithValue("@idPesanan", idPesanan);
                    return cmd.ExecuteScalar()?.ToString();
                }
            }
        }

        public List<string> GetMejaTersedia()
        {
            var list = new List<string>();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(
                    "SELECT id_meja, nomor_meja FROM meja WHERE status_meja = 'Tersedia'", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            list.Add($"{reader["id_meja"]} - {reader["nomor_meja"]}");
                    }
                }
            }
            return list;
        }
    }
}