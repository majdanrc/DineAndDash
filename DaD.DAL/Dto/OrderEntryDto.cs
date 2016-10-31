using DaD.DAL.Models;

namespace DaD.DAL.Dto
{
    public class OrderEntryDto
    {
        public int Id { get; set; }

        public OrderEntryDto(OrderEntry entity)
        {
            Id = entity.OrderId;
        }
    }
}
