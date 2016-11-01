using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DaD.DAL.Dto;
using DaD.DAL.Repositories;
using DineAndDash.ControlModels;

namespace DineAndDash
{
    public partial class OrderHistory : Form
    {
        private List<OrderDto> _orderHeaders = new List<OrderDto>();
        private readonly Dictionary<int, OrderDto> _orders = new Dictionary<int, OrderDto>();

        public OrderHistory()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            ordersList.Items.Clear();

            _orderHeaders = OrderRepository.GetOrdersWithoutEntries();

            var placedOrders = _orderHeaders.Select(d => new OrderListItem(d)).ToArray();
            ordersList.Items.AddRange((OrderListItem[])placedOrders);
        }

        private void orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderView.Nodes.Clear();
            rtbNotes.Text = string.Empty;

            var selected = (OrderListItem)ordersList.SelectedItem;

            OrderDto orderToShow;

            if (!_orders.ContainsKey(selected.OrderId))
            {
                var order = OrderRepository.GetOrderById(selected.OrderId);
                _orders.Add(order.Id, order);
                orderToShow = order;
            }
            else
            {
                orderToShow = _orders[selected.OrderId];
            }

            if (orderToShow != null)
            {
                foreach (var orderItem in orderToShow.OrderItems.Where(oi => !oi.Extra))
                {
                    var orderNode = new TreeNode(orderItem.ItemName);

                    orderView.Nodes.Add(orderNode);

                    foreach (var orderItemExtra in orderItem.Extras)
                    {
                        orderNode.Nodes.Add(orderItemExtra.ItemName);
                    }
                }

                orderView.ExpandAll();

                rtbNotes.Text = orderToShow.Notes;
            }
        }
    }
}
