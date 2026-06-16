using Bitebox.Helpers;
using Bitebox.Models.Entity;
using Npgsql;

namespace Bitebox.Models.Context
{
    public class CustomerContext
    {
        public List<EntityCustomerAdmin> GetAllCustomers()
        {
            var list = new List<EntityCustomerAdmin>();
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM get_semua_customer()", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new EntityCustomerAdmin
                {
                    Id = Convert.ToInt32(reader["id_akun"]),
                    Username = reader["username"]?.ToString() ?? "",
                    NamaLengkap = reader["nama_lengkap"]?.ToString() ?? "",
                    Email = reader["email"]?.ToString() ?? "",
                    IsAktif = Convert.ToBoolean(reader["is_aktif"])
                });
            }
            return list;
        }

        public bool UpdateStatus(int id, bool isAktif)
        {
            using var conn = DatabaseConnection.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("CALL toggle_status_customer(@id, @status)", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@status", isAktif);
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}