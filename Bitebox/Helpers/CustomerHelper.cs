using Bitebox.Models.Entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Helpers
{
    public class CustomerHelper
    {
        private string connectionString = "Host=localhost;Database=bitebox;Username=postgres;Password=0402";

        // Ambil data dari tabel 'akun' yang role-nya adalah 'customer'
        public List<EntityCustomerAdmin> GetAllCustomers()
        {
            List<EntityCustomerAdmin> list = new List<EntityCustomerAdmin>();

            // Query disesuaikan dengan tabel 'akun' asli dari pgAdmin
            // Kita anggap IsActive itu TRUE jika dia adalah 'customer'
            string query = "SELECT id_akun, nama_lengkap, email, role_akun FROM akun WHERE role_akun = 'customer' ORDER BY id_akun ASC";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                conn.Open();

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EntityCustomerAdmin
                        {
                            // Mapping disesuaikan dengan kolom di tabel akun kamu
                            Id = Convert.ToInt32(reader["id_akun"]),
                            Name = reader["nama_lengkap"]?.ToString() ?? string.Empty,
                            Email = reader["email"]?.ToString() ?? string.Empty,

                            // Karena di DB kamu tidak ada 'is_active', kita set default true 
                            // untuk semua yang muncul karena query di atas khusus filter 'customer'
                            IsActive = reader["role_akun"]?.ToString() == "customer"
                        });
                    }
                }
            }
            return list;
        }

        // Fungsi update status (Disimulasikan mengubah role_akun atau logic lainnya)
        public bool UpdateStatus(int id, bool isActive)
        {
            // Karena di tabel tidak ada 'is_active', kita simulasikan update role_akun saja sebagai contoh
            // Jika isActive false, kita set jadi admin (misal sebagai bentuk penonaktifan akses customer biasa)
            string targetRole = isActive ? "customer" : "admin";

            string query = "UPDATE akun SET role_akun = @RoleAkun::role_enum WHERE id_akun = @Id";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@RoleAkun", targetRole);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}