using Bitebox.Models.Context;
using System;
using System.Collections.Generic;
using System.Text;
using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.Controllers
{
    internal class MenuControllerAdmin
    {
        private MenuContextadmin menuContext = new MenuContextadmin();
        public List<MenuEntity> GetAllMenu()
        {
            return menuContext.GetAllMenu();
        }

        public bool TambahMenu(MenuEntity menu)
        {
            return menuContext.TambahMenu(menu);
        }

        public bool UpdateMenu(MenuEntity menu)
        {
            return menuContext.UpdateMenu(menu);
        }

        public bool HapusMenu(int idMenu)
        {
            return menuContext.HapusMenu(idMenu);
        }

    }
}
