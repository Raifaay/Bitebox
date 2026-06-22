using Bitebox.Models.Context;
using System;
using System.Collections.Generic;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Controllers
{
    public class MenuControllerAdmin
    {
        private readonly MenuContext _menuContext = new MenuContext();

        public List<MenuEntity> GetAllMenu()
        {
            return _menuContext.GetAllMenu();
        }

        public bool TambahMenu(MenuEntity menu)
        {
            return _menuContext.TambahMenu(menu);
        }

        public bool UpdateMenu(MenuEntity menu)
        {
            return _menuContext.UpdateMenu(menu);
        }

        public bool HapusMenu(int idMenu)
        {
            return _menuContext.HapusMenu(idMenu);
        }
    }
}