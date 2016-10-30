using DaD.DAL.Enums;

namespace DaD.DAL.Models
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public bool Extra { get; set; }
        public decimal Price { get; set; }
    }
}
