using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Bitebox.Models.Context
{
    public class AkunContextAdmin
    {

        private string connString = "Host=localhost;Username=postgres;Password=0402;Database=bitebox";

        public DataTable GetCustomerFromDatabase()
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
 
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


        public void ExecuteNonaktifkanCustomer(int idAkun)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();

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
