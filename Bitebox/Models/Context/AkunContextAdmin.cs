using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bitebox.Models.Context
{
    public class AkunContextAdmin
    {
        // GANTI DENGAN PASSWORD DAN DB KAMU
        private string connString = "Host=localhost;Username=postgres;Password=0402;Database=bitebox";

        public DataTable GetCustomerFromDatabase()
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                // Memanggil VIEW dari database PostgreSQL sesuai materi kuliah
                string query = "SELECT id_akun, username, nama_lengkap, email, is_aktif FROM v_kelola_customer";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // 2. Fungsi eksekusi SP yang dipanggil oleh Controller kamu di baris ke-43
        public void ExecuteNonaktifkanCustomer(int idAkun)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                // Memanggil Stored Procedure PostgreSQL sesuai materi kuliah
                string query = "CALL nonaktifkan_customer(@id)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", idAkun);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
