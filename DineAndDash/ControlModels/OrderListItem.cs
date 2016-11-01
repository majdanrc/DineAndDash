using System;
using System.Globalization;
using System.Windows.Forms;
using DaD.DAL.Dto;
using DaD.DAL.Enums;

namespace DineAndDash.ControlModels
{
    public class OrderListItem : ListViewItem
    {
        public int OrderId { get; set; }
        public DateTime CreatedOn { get; set; }

        public OrderListItem(OrderDto orderDto)
        {
            OrderId = orderDto.Id;
            CreatedOn = orderDto.CreatedOn;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", OrderId, CreatedOn.ToString(CultureInfo.InvariantCulture));
        }
    }
}
