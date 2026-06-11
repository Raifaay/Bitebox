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

        public List<EntityCustomerAdmin> GetAllCustomers()
        {
            List<EntityCustomerAdmin> list = new List<EntityCustomerAdmin>();

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
                            
                            Id = Convert.ToInt32(reader["id_akun"]),
                            Name = reader["nama_lengkap"]?.ToString() ?? string.Empty,
                            Email = reader["email"]?.ToString() ?? string.Empty,

                            
                            IsActive = reader["role_akun"]?.ToString() == "customer"
                        });
                    }
                }
            }
            return list;
        }

      
        public bool UpdateStatus(int id, bool isActive)
        {
        
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