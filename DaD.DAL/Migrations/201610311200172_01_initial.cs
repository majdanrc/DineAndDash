namespace DaD.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01_initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        MenuItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.Int(nullable: false),
                        Extra = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MenuItemId);
            
            CreateTable(
                "dbo.OrderEntries",
                c => new
                    {
                        OrderEntryId = c.Int(nullable: false, identity: true),
                        MenuItemId = c.Int(nullable: false),
                        ParentId = c.Int(),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderEntryId)
                .ForeignKey("dbo.MenuItems", t => t.MenuItemId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.OrderEntries", t => t.ParentId)
                .Index(t => t.MenuItemId)
                .Index(t => t.ParentId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderEntries", "ParentId", "dbo.OrderEntries");
            DropForeignKey("dbo.OrderEntries", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderEntries", "MenuItemId", "dbo.MenuItems");
            DropIndex("dbo.OrderEntries", new[] { "OrderId" });
            DropIndex("dbo.OrderEntries", new[] { "ParentId" });
            DropIndex("dbo.OrderEntries", new[] { "MenuItemId" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderEntries");
            DropTable("dbo.MenuItems");
        }
    }
}
