﻿using System.Data.Entity;
using System.Linq;
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
                    var order = orderDto.CreateOrderEntity();

                    foreach (var orderItem in orderDto.OrderItems)
                    {
                        var orderEntry = new OrderEntry
                        {
                            MenuItemId = orderItem.MenuItemId
                        };

                        foreach (var extra in orderItem.Extras)
                        {
                            var extraEntry = new OrderEntry
                            {
                                MenuItemId = extra.MenuItemId,
                                Parent = orderEntry
                            };

                            orderEntry.Children.Add(extraEntry);
                        }

                        order.OrderEntries.Add(orderEntry);
                    }

                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }

            return true;
        }
    }
}
