using Bitebox.Helpers;
using Bitebox.IABS;
using Npgsql;
using System;
using System.Collections.Generic;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Models.Context
{
    public class MenuContext : BaseContext
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
                            menu.HargaMenu = Convert.ToDecimal(reader["harga_menu"]);
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
                            menu.HargaMenu = Convert.ToDecimal(reader["harga_menu"]);
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

       
        public bool TambahMenu(MenuEntity menu)
        {
            string query = "INSERT INTO menu (nama_menu, harga_menu, deskripsi_menu, gambar_menu, id_kategori_menu) VALUES (@nama, @harga, @deskripsi, @gambar, @idKategori)";
            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", menu.NamaMenu);
                    cmd.Parameters.AddWithValue("@harga", menu.HargaMenu);
                    cmd.Parameters.AddWithValue("@deskripsi", menu.DeskripsiMenu);
                    cmd.Parameters.AddWithValue("@gambar", (object)menu.GambarMenu ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idKategori", menu.IdKategoriMenu);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateMenu(MenuEntity menu)
        {
            string query = "UPDATE menu SET nama_menu = @nama, harga_menu = @harga, deskripsi_menu = @deskripsi, gambar_menu = @gambar, id_kategori_menu = @idKategori WHERE id_menu = @id";
            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", menu.IdMenu);
                    cmd.Parameters.AddWithValue("@nama", menu.NamaMenu);
                    cmd.Parameters.AddWithValue("@harga", menu.HargaMenu);
                    cmd.Parameters.AddWithValue("@deskripsi", menu.DeskripsiMenu);
                    cmd.Parameters.AddWithValue("@gambar", (object)menu.GambarMenu ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idKategori", menu.IdKategoriMenu);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool HapusMenu(int idMenu)
        {
            string query = "DELETE FROM menu WHERE id_menu = @id";
            using (NpgsqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idMenu);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public override string GetNamaEntitas() => "Menu Customer & Admin";
    }
}