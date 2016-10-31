using System;
using System.Collections.Generic;

namespace DaD.DAL.Models
{
    public class Order
    {
        public Order()
        {
            OrderEntries = new HashSet<OrderEntry>();
        }

        public int OrderId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<OrderEntry> OrderEntries { get; set; }
    }
}
