using DaD.DAL.Enums;
using DaD.DAL.Models;

namespace DaD.DAL.Dto
{
    public class MenuItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public bool Extra { get; set; }
        public decimal Price { get; set; }

        public MenuItemDto(MenuItem entity)
        {
            Id = entity.MenuItemId;
            Name = entity.Name;
            Category = entity.Category;
            Extra = entity.Extra;
            Price = entity.Price;
        }
    }
}
