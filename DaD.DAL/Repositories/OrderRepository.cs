﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DaD.DAL.Dto;
using DaD.DAL.Models;

namespace DaD.DAL.Repositories
{
    public static class OrderRepository
    {
        public static List<OrderDto> GetOrdersWithoutEntries()
        {
            using (var context = new DineAndDashContext())
            {
                var orders = context.Set<Order>().ToList();

                return orders.Select(o => new OrderDto(o, false)).ToList();
            }
        }

        public static OrderDto GetOrderById(int orderId)
        {
            using (var context = new DineAndDashContext())
            {
                try
                {
                    var order = context.Set<Order>().FirstOrDefault(o => o.OrderId == orderId);

                    return new OrderDto(order);
                }
                catch (Exception exc)
                {
                    Debug.WriteLine(exc.Message);
                    return null;
                }
            }
        }

        public static int SaveOrder(OrderDto orderDto)
        {
            var orderId = 0;

            try
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

                        orderId = order.OrderId;
                    }
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                orderId = 0;
            }

            return orderId;
        }
    }
}
