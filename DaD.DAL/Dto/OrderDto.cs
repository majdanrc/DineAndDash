using System;
using System.Collections.Generic;
using System.Linq;
using DaD.DAL.Models;

namespace DaD.DAL.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<OrderEntryDto> OrderItems { get; set; }
        public string Notes { get; set; }

        public OrderDto()
        {
            OrderItems = new List<OrderEntryDto>();
        }

        public OrderDto(Order entity, bool full = true)
        {
            Id = entity.OrderId;
            CreatedOn = entity.CreatedOn;
            Notes = entity.Notes;
            OrderItems = new List<OrderEntryDto>();

            if (full)
            {
                var entries = entity.OrderEntries.ToList();
                OrderItems = entries.Select(oe => new OrderEntryDto(oe)).ToList();
            }
        }

        public Order CreateOrderEntity()
        {
            var order = new Order
            {
                CreatedOn = CreatedOn,
                Notes = Notes
            };

            return order;
        }
    }
}
