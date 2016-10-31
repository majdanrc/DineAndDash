using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DaD.DAL.Dto;
using DaD.DAL.Models;

namespace DaD.DAL.Repositories
{
    public static class OrderRepository
    {
        public static OrderDto GetOrderById(int orderId)
        {
            using (var context = new DineAndDashContext())
            {
                var order = context.Set<Order>().FirstOrDefault(o => o.OrderId == orderId);

                return new OrderDto(order);
            }
        }

        public static bool SaveOrder(OrderDto orderDto)
        {
            using (var context = new DineAndDashContext())
            {
                var originalOrder = orderDto.Id != 0
                    ? context.Set<Order>().FirstOrDefault(o => o.OrderId == orderDto.Id)
                    : null;

                if (originalOrder == null)
                {
                    
                }
            }

            return true;
        }
    }
}
