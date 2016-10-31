using System.Windows.Forms;
using DaD.DAL.Dto;
using DaD.DAL.Enums;

namespace DineAndDash.ControlModels
{
    public class MenuListItem : ListViewItem
    {
        public int MenuItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? Price { get; set; }
        public Category Category { get; set; }

        public MenuListItem(Category category)
        {
            ItemName = EnumHelper.GetDisplayValue(category);
            Category = category;
        }

        public MenuListItem(MenuItemDto menuItemDto)
        {
            MenuItemId = menuItemDto.Id;
            ItemName = menuItemDto.Name;
            Category = menuItemDto.Category;
            Price = menuItemDto.Price;
        }

        public override string ToString()
        {
            return Price.HasValue ? string.Format("{0} - {1} PLN", ItemName, Price) : ItemName;
        }
    }
}
