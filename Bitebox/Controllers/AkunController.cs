using System;
using Npgsql;
using Bitebox.Models;
using Bitebox.Helpers;

namespace Bitebox.Controllers
{
    internal class AkunController
    {
        public Akun Login(string usernameOrEmail, string password)
        {
            Akun akun = null;
            string query = "SELECT * FROM akun WHERE (username = @input OR email = @input) AND password_akun = @password";

            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@input", usernameOrEmail);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["role_akun"].ToString();

                            if (role == "admin")
                            {
                                akun = new Admin();
                            }
                            else
                            {
                                akun = new Customer();
                            }

                            akun.IdAkun = (int)reader["id_akun"];
                            akun.Username = reader["username"].ToString();
                            akun.NamaLengkap = reader["nama_lengkap"].ToString();
                            akun.Email = reader["email"].ToString();
                            akun.Role = role;
                        }
                    }
                }
            }
            return akun;
        }

        public bool Register(string namaLengkap, string email, string username, string password)
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