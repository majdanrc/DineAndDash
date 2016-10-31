using System.Data.Entity;
using DaD.DAL.Models;

namespace DaD.DAL
{
    public class DineAndDashContext : DbContext
    {
        public DineAndDashContext()
            : base("DineAndDashDBConnectionString")
        {
            Database.SetInitializer(new DineAndDashInitializer());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<OrderEntry> OrderEntries { get; set; }
    }
}
