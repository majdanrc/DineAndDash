using System.Data.Entity;
using DaD.DAL.Enums;
using DaD.DAL.Models;

namespace DaD.DAL
{
    public class DineAndDashInitializer : CreateDatabaseIfNotExists<DineAndDashContext>
    {
        protected override void Seed(DineAndDashContext context)
        {
            var menuItems = context.Set<MenuItem>();

            // pizzas
            menuItems.Add(new MenuItem
            {
                Category = Category.Pizza,
                Name = "Margheritta",
                Extra = false,
                Price = 20.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Pizza,
                Name = "Vegetariana",
                Extra = false,
                Price = 22.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Pizza,
                Name = "Tosca",
                Extra = false,
                Price = 25.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Pizza,
                Name = "Venecia",
                Extra = false,
                Price = 25.0M
            });

            // pizza extras
            menuItems.Add(new MenuItem
            {
                Category = Category.Pizza,
                Name = "Podwójny ser",
                Extra = true,
                Price = 2.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Pizza,
                Name = "Salami",
                Extra = true,
                Price = 2.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Pizza,
                Name = "Szynka",
                Extra = true,
                Price = 2.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Pizza,
                Name = "Pieczarki",
                Extra = true,
                Price = 2.0M
            });

            // main dishes
            menuItems.Add(new MenuItem
            {
                Category = Category.Main,
                Name = "Schabowy z frytkami/ryżem/ziemniakami",
                Extra = false,
                Price = 30.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Main,
                Name = "Ryba z frytkami",
                Extra = false,
                Price = 28.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Main,
                Name = "Placek po węgiersku",
                Extra = false,
                Price = 27.0M
            });

            // main dishes extras
            menuItems.Add(new MenuItem
            {
                Category = Category.Main,
                Name = "Bar sałatkowy",
                Extra = true,
                Price = 5.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Main,
                Name = "Zestaw sosów",
                Extra = true,
                Price = 6.0M
            });

            // soups
            menuItems.Add(new MenuItem
            {
                Category = Category.Soup,
                Name = "Pomidorowa",
                Extra = false,
                Price = 12.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Soup,
                Name = "Rosół",
                Extra = false,
                Price = 10.0M
            });

            // drinks
            menuItems.Add(new MenuItem
            {
                Category = Category.Drink,
                Name = "Kawa",
                Extra = false,
                Price = 5.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Drink,
                Name = "Herbata",
                Extra = false,
                Price = 5.0M
            });
            menuItems.Add(new MenuItem
            {
                Category = Category.Drink,
                Name = "Cola",
                Extra = false,
                Price = 5.0M
            });

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
