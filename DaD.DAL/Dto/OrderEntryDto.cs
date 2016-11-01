using System.Collections.Generic;
using DaD.DAL.Models;

namespace DaD.DAL.Dto
{
    public class OrderEntryDto
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public string ItemName { get; set; }
        public bool Extra { get; set; }
        public List<OrderEntryDto> Extras { get; set; }

        public OrderEntryDto()
        {
            Extras = new List<OrderEntryDto>();
        }

        public OrderEntryDto(OrderEntry entity)
        {
            Id = entity.OrderEntryId;
            MenuItemId = entity.MenuItemId;
            ItemName = entity.MenuItem.Name;
            Extra = entity.MenuItem.Extra;
            Extras = new List<OrderEntryDto>();

            foreach (var extra in entity.Children)
            {
                Extras.Add(new OrderEntryDto(extra));
            }
        }
    }
}
