using System;
using Npgsql;
using Bitebox.Models.Entity;
using Bitebox.Helpers;

namespace Bitebox.Models.Context
{
    internal class AkunContext
    {
        public Akun? GetAkunByCredentials(string usernameOrEmail, string password)
        {
            Akun? akun = null;
            string query = "SELECT * FROM akun WHERE (username = @input1 OR email = @input2) AND password_akun = @password AND is_aktif = TRUE";

            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@input1", usernameOrEmail);
                    cmd.Parameters.AddWithValue("@input2", usernameOrEmail);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["role_akun"]?.ToString() ?? "";

                            if (role == "admin")
                            {
                                akun = new Admin();
                            }
                            else
                            {
                                akun = new Customer();
                            }

                            if (reader["id_akun"] != DBNull.Value)
                            {
                                akun.IdAkun = Convert.ToInt32(reader["id_akun"]);
                            }

                            akun.Username = reader["username"]?.ToString() ?? "";
                            akun.NamaLengkap = reader["nama_lengkap"]?.ToString() ?? "";
                            akun.Email = reader["email"]?.ToString() ?? "";
                            akun.Role = role;
                        }
                    }
                }
            }
            return akun;
        }

        public bool InsertAkun(string namaLengkap, string email, string username, string password)
        {
            string query = "INSERT INTO akun (username, password_akun, nama_lengkap, email, role_akun) VALUES (@username, @password, @nama, @email, 'customer')";

            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@nama", namaLengkap);
                    cmd.Parameters.AddWithValue("@email", email);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }
    }
}