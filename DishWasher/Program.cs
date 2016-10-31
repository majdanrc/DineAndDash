using DaD.DAL;
using DaD.DAL.Repositories;

namespace DishWasher
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = MenuItemRepository.GetMenuItems();

            using (var db = new DineAndDashContext())
            {
                //var menuItem = new MenuItem();
                //menuItem.Category = Category.Pizza;
                //menuItem.Name = "Margheritta";
                //menuItem.Price = 20.0M;
                //menuItem.Extra = false;

                //var menuItems = db.Set<MenuItem>();
                //menuItems.Add(menuItem);

                //db.SaveChanges();
            }

            using (var db = new DineAndDashContext())
            {
                //var menuItems = db.Set<MenuItem>();

                //var available = menuItems.Select(m => m).ToList();

                //var orders = db.Set<Order>();

                //var order = new Order();
                //order.CreatedOn = DateTime.UtcNow;

                //var orderEntry = new OrderEntry();
                ////orderEntry.MenuItem = available.First();
                //orderEntry.MenuItemId = 1;

                //order.OrderEntries.Add(orderEntry);

                //orders.Add(order);

                //db.SaveChanges();

                //var test = orderEntry.OrderEntryId;
            }
        }
    }
}
