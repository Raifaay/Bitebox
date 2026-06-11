using System;
using System.Collections.Generic;
using Npgsql;
using Bitebox.Helpers;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Models.Context
{
    internal class MenuContext
    {
        public List<MenuEntity> GetAllMenu()
        {
            List<MenuEntity> listMenu = new List<MenuEntity>();
            string query = "SELECT * FROM menu ORDER BY id_menu ASC";
            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MenuEntity menu = new MenuEntity();

                            menu.IdMenu = Convert.ToInt32(reader["id_menu"]);
                            menu.NamaMenu = reader["nama_menu"]?.ToString() ?? "";
                            menu.HargaMenu = Convert.ToInt32(reader["harga_menu"]);
                            menu.DeskripsiMenu = reader["deskripsi_menu"]?.ToString() ?? "";
                            menu.GambarMenu = reader["gambar_menu"] as byte[];
                            menu.IdKategoriMenu = Convert.ToInt32(reader["id_kategori_menu"]);

                            listMenu.Add(menu);
                        }
                    }
                }
            }
            return listMenu;
        }

        public List<MenuEntity> GetMenuByKategori(int idKategori)
        {
            List<MenuEntity> listMenu = new List<MenuEntity>();
            string query = "SELECT * FROM menu WHERE id_kategori_menu = @idKategori ORDER BY id_menu ASC";

            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idKategori", idKategori);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MenuEntity menu = new MenuEntity();

                            menu.IdMenu = Convert.ToInt32(reader["id_menu"]);
                            menu.NamaMenu = reader["nama_menu"]?.ToString() ?? "";
                            menu.HargaMenu = Convert.ToInt32(reader["harga_menu"]);
                            menu.DeskripsiMenu = reader["deskripsi_menu"]?.ToString() ?? "";
                            menu.GambarMenu = reader["gambar_menu"] as byte[];
                            menu.IdKategoriMenu = Convert.ToInt32(reader["id_kategori_menu"]);

                            listMenu.Add(menu);
                        }
                    }
                }
            }
            return listMenu;
        }
    }
}