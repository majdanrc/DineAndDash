using System.Collections.Generic;
using DaD.DAL.Dto;
using DaD.DAL.Models;

namespace OrdersContainer
{
    public class OrdersContainer
    {
        private List<Order> _orders;

        public OrdersContainer()
        {
            _orders = new List<Order>();
        }

        public OrderDto PlaceNewOrder(OrderDto orderDto)
        {
            var order = new Order();

            _orders.Add(order);

            return new OrderDto(order);
        }
    }
}
