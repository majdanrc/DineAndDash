using DaD.DAL.Dto;
using DaD.DAL.Repositories;

namespace DaD.BackOffice.Services
{
    public class OrderingService
    {
        public OrderDto PlaceOrder(OrderDto orderDto)
        {
            var orderId = OrderRepository.SaveOrder(orderDto);

            var order = OrderRepository.GetOrderById(orderId);

            return order;
        }
    }
}
