namespace EShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeleteForBrand : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Brands", "IsDeleted");
        }
    }
}
