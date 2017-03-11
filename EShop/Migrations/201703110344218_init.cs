namespace EShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        InStock = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Price = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TagId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        Phone = c.String(),
                        Description = c.String(),
                        UserId = c.String(maxLength: 128),
                        UserName = c.String(),
                        OrderStatus = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderItemId = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.TagProducts",
                c => new
                    {
                        Tag_TagId = c.Int(nullable: false),
                        Product_ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_TagId, t.Product_ProductId })
                .ForeignKey("dbo.Tags", t => t.Tag_TagId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Tag_TagId)
                .Index(t => t.Product_ProductId);
            
            
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.OrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.TagProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.TagProducts", "Tag_TagId", "dbo.Tags");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.TagProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.TagProducts", new[] { "Tag_TagId" });
            DropIndex("dbo.OrderItems", new[] { "ProductId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "UserId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.TagProducts");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Tags");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
