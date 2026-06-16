using MenuEntity = Bitebox.Models.Entity.Menu;

namespace Bitebox.IABS
{
    public interface ICrudMenu
    {
        List<MenuEntity> GetAllMenu();
        bool TambahMenu(MenuEntity menu);
        bool UpdateMenu(MenuEntity menu);
        bool HapusMenu(int idMenu);
    }
}