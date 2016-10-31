using System.ComponentModel.DataAnnotations.Schema;

namespace DaD.DAL.Models
{
    public class OrderEntry
    {
        public int OrderEntryId { get; set; }

        public int MenuItemId { get; set; }
        public virtual MenuItem MenuItem { get; set; }

        // for extras
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual OrderEntry Parent { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
