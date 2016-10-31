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

        public OrderDto(Order entity)
        {
            Id = entity.OrderId;
            CreatedOn = entity.CreatedOn;

            var entries = entity.OrderEntries.ToList();

            OrderItems = entries.Select(oe => new OrderEntryDto(oe)).ToList();
        }
    }
}
