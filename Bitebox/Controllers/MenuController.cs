using System;
using System.Collections.Generic;
using Bitebox.Models.Context;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Controllers
{
    internal class MenuController
    {
        private MenuContext menuContext = new MenuContext();

        public List<MenuEntity> GetAllMenu()
        {
            return menuContext.GetAllMenu();
        }

        public List<MenuEntity> GetMenuByKategori(int idKategori)
        {
            return menuContext.GetMenuByKategori(idKategori);
        }
    }
}