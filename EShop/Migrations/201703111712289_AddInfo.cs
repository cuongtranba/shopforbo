namespace EShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "IsSale", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "IsSpecial", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "DiscountPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DiscountPrice");
            DropColumn("dbo.Products", "CreatedDate");
            DropColumn("dbo.Products", "IsSpecial");
            DropColumn("dbo.Products", "IsSale");
        }
    }
}
