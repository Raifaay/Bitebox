using Bitebox.Helpers;
using Npgsql;
using System;
using System.Data;

namespace Bitebox.Models.Context
{
    public class AkunContextAdmin
    {
        public DataTable GetCustomerFromDatabase()
        {
            DataTable dt = new DataTable();
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM get_semua_customer()";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public void ExecuteNonaktifkanCustomer(int idAkun)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                bool isAktif;
                using (var cmd = new NpgsqlCommand("SELECT is_aktif FROM akun WHERE id_akun = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAkun);
                    isAktif = (bool)cmd.ExecuteScalar()!;
                }
                using (var cmd = new NpgsqlCommand("CALL toggle_status_customer(@id, @status)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAkun);
                    cmd.Parameters.AddWithValue("@status", !isAktif);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}