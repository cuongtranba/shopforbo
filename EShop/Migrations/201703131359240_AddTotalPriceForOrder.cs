namespace EShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTotalPriceForOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Total", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Total");
        }
    }
}
