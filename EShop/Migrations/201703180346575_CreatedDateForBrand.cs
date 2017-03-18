namespace EShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDateForBrand : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Brands", "CreatedDate");
        }
    }
}
