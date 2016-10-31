using DaD.DAL.Enums;
using DaD.DAL.Models;

namespace DaD.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DaD.DAL.DineAndDashContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DaD.DAL.DineAndDashContext context)
        {
            context.MenuItems.AddOrUpdate(
                m => m.Name,

                // pizzas
                new MenuItem
                {
                    Category = Category.Pizza,
                    Name = "Margheritta",
                    Extra = false,
                    Price = 20.0M
                },
                new MenuItem
                {
                    Category = Category.Pizza,
                    Name = "Vegetariana",
                    Extra = false,
                    Price = 22.0M
                },
                new MenuItem
                {
                    Category = Category.Pizza,
                    Name = "Tosca",
                    Extra = false,
                    Price = 25.0M
                },
                new MenuItem
                {
                    Category = Category.Pizza,
                    Name = "Venecia",
                    Extra = false,
                    Price = 25.0M
                },

                // pizza extras
                new MenuItem
                {
                    Category = Category.Pizza,
                    Name = "Podwójny ser",
                    Extra = true,
                    Price = 2.0M
                },
                new MenuItem
                {
                    Category = Category.Pizza,
                    Name = "Salami",
                    Extra = true,
                    Price = 2.0M
                },
                new MenuItem
                {
                    Category = Category.Pizza,
                    Name = "Szynka",
                    Extra = true,
                    Price = 2.0M
                },
                new MenuItem
                {
                    Category = Category.Pizza,
                    Name = "Pieczarki",
                    Extra = true,
                    Price = 2.0M
                },

                // main dishes
                new MenuItem
                {
                    Category = Category.Main,
                    Name = "Schabowy z frytkami/ry¿em/ziemniakami",
                    Extra = false,
                    Price = 30.0M
                },
                new MenuItem
                {
                    Category = Category.Main,
                    Name = "Ryba z frytkami",
                    Extra = false,
                    Price = 28.0M
                },
                new MenuItem
                {
                    Category = Category.Main,
                    Name = "Placek po wêgiersku",
                    Extra = false,
                    Price = 27.0M
                },

                // main dishes extras
                new MenuItem
                {
                    Category = Category.Main,
                    Name = "Bar sa³atkowy",
                    Extra = true,
                    Price = 5.0M
                },
                new MenuItem
                {
                    Category = Category.Main,
                    Name = "Zestaw sosów",
                    Extra = true,
                    Price = 6.0M
                },

                // soups
                new MenuItem
                {
                    Category = Category.Soup,
                    Name = "Pomidorowa",
                    Extra = false,
                    Price = 12.0M
                },
                new MenuItem
                {
                    Category = Category.Soup,
                    Name = "Rosó³",
                    Extra = false,
                    Price = 10.0M
                },

                // drinks
                new MenuItem
                {
                    Category = Category.Drink,
                    Name = "Kawa",
                    Extra = false,
                    Price = 5.0M
                },
                new MenuItem
                {
                    Category = Category.Drink,
                    Name = "Herbata",
                    Extra = false,
                    Price = 5.0M
                },
                new MenuItem
                {
                    Category = Category.Drink,
                    Name = "Cola",
                    Extra = false,
                    Price = 5.0M
                }
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
