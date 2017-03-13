namespace EShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductPriceInItems : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "ProductPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderItems", "ProductPrice");
        }
    }
}
