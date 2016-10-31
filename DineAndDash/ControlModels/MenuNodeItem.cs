using System.Windows.Forms;
using DaD.DAL.Dto;
using DaD.DAL.Enums;

namespace DineAndDash.ControlModels
{
    public class MenuNodeItem : TreeNode
    {
        public int MenuItemId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public bool Extra { get; set; }

        public MenuNodeItem(MenuItemDto menuItemDto)
        {
            MenuItemId = menuItemDto.Id;
            ItemName = menuItemDto.Name;
            Price = menuItemDto.Price;
            Category = menuItemDto.Category;
            Extra = menuItemDto.Extra;

            Text = menuItemDto.Name;
        }
    }
}
