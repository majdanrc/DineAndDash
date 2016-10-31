using System.Collections.Generic;
using System.Linq;
using DaD.DAL.Dto;
using DaD.DAL.Enums;

namespace DaD.DAL.Queries
{
    public static class MenuItemQueries
    {
        public static List<MenuItemDto> MainByCategory(this IEnumerable<MenuItemDto> items, Category category)
        {
            return items.Where(d => d.Category == category && !d.Extra).ToList();
        }

        public static List<MenuItemDto> ExtrasByCategory(this IEnumerable<MenuItemDto> items, Category category)
        {
            return items.Where(d => d.Category == category && d.Extra).ToList();
        }
    }
}
