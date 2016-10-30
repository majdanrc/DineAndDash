using System.Data.Entity;
using DaD.DAL.Models;

namespace DaD.DAL
{
    public class DineAndDashContext : DbContext
    {
        public DineAndDashContext()
            : base("DineAndDashDBConnectionString")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}
