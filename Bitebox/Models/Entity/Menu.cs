using System;
using System.Collections.Generic;
using System.Text;

namespace Bitebox.Models.Entity
{
    public class Menu
    {
        private int idMenu;
        private string namaMenu;
        private int hargaMenu;
        private string deskripsiMenu;
        private byte[] gambarMenu;
        private int idKategoriMenu;

        public int IdMenu
        {
            get { return idMenu; }
            set { idMenu = value; }
        }
        public string NamaMenu
        {
            get { return namaMenu; }
            set { namaMenu = value; }
        }
        public int HargaMenu
        {
            get { return hargaMenu; }
            set { hargaMenu = value; }
        }
        public string DeskripsiMenu
        {
            get { return deskripsiMenu; }
            set { deskripsiMenu = value; }
        }
        public byte[] GambarMenu
        {
            get { return gambarMenu; }
            set { gambarMenu = value; }
        }
        public int IdKategoriMenu
        {
            get { return idKategoriMenu; }
            set { idKategoriMenu = value; }
        }

        public Menu() { }

        public Menu(int idMenu, string namaMenu, int hargaMenu, string deskripsiMenu, byte[] gambarMenu, int idKategoriMenu)
        {
            this.idMenu = idMenu;
            this.namaMenu = namaMenu;
            this.hargaMenu = hargaMenu;
            this.deskripsiMenu = deskripsiMenu;
            this.gambarMenu = gambarMenu;
            this.idKategoriMenu = idKategoriMenu;
        }

        public string InfoMenu()
        {
            return $"{namaMenu} - Rp {hargaMenu:N0}";
        }
    }
}
