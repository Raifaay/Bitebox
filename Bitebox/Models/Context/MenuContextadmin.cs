using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using Bitebox.Helpers;
using MenuEntity = Bitebox.Models.Entity.Menu;
using System.Runtime.CompilerServices;

namespace Bitebox.Models.Context
{
    internal class MenuContextadmin
    {
        public List<MenuEntity> GetAllMenu()
        {
            var list = new List<MenuEntity>();
            string query = "SELECT * FROM menu"; 

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(PetakanKeModel(reader));
            }
            return list; 
        }

        public bool TambahMenu(MenuEntity menu)
        {
            string query = @"INSERT INTO menu
                            (nama_menu, harga_menu, deskripsi_menu, gambar_menu, id_kategori_menu)
                VALUES (@nama, @harga, @deskripsi, @gambar, @kategori)";

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", menu.NamaMenu);
                cmd.Parameters.AddWithValue("@harga", menu.HargaMenu);
                cmd.Parameters.AddWithValue("@deskripsi", menu.DeskripsiMenu);
                cmd.Parameters.AddWithValue("@gambar", (object?)menu.GambarMenu ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@kategori", menu.IdKategoriMenu);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateMenu(MenuEntity menu)
        {
            string query = @"UPDATE menu SET
                nama_menu = @nama,
                harga_menu = @harga,
                deskripsi_menu = @deskripsi,
                gambar_menu = @gambar,
                id_kategori_menu = @kategori
                WHERE id_menu = @id"; 

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", menu.IdMenu);
                cmd.Parameters.AddWithValue("@nama", menu.NamaMenu);
                cmd.Parameters.AddWithValue("@harga", menu.HargaMenu);
                cmd.Parameters.AddWithValue("@deskripsi", menu.DeskripsiMenu ?? " ");
                cmd.Parameters.AddWithValue("@gambar", (object?)menu.GambarMenu ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@kategori", menu.IdKategoriMenu);
                return cmd.ExecuteNonQuery() > 0;

            }
        }

        public bool HapusMenu(int idMenu)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using var cmd = new NpgsqlCommand("DELETE FROM menu WHERE id_menu = @id", conn);
                cmd.Parameters.AddWithValue("@id", idMenu);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private MenuEntity PetakanKeModel(NpgsqlDataReader reader)
        {
            return new MenuEntity(
                (int)reader["id_menu"],
                reader["nama_menu"]?.ToString() ?? " ",
                (int)reader["harga_menu"],
                reader["deskripsi_menu"]?.ToString() ?? " ",
                reader["gambar_menu"] as byte[],
                (int)reader["id_kategori_menu"]
                ); //:: 
        }
    }
}
