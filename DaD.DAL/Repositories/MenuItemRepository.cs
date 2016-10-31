using System.Collections.Generic;
using System.Linq;
using DaD.DAL.Dto;

namespace DaD.DAL.Repositories
{
    public static class MenuItemRepository
    {
        public static List<MenuItemDto> GetMenuItems()
        {
            using (var context = new DineAndDashContext())
            {
                var menuItems = context.MenuItems.ToList();

                return menuItems.Select(m => new MenuItemDto(m)).ToList();
            }
        }
    }
}
