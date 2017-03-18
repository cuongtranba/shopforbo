namespace EShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class brand : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            AddColumn("dbo.Products", "BrandId", c => c.Int(nullable: true));
            CreateIndex("dbo.Products", "BrandId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "BrandId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropColumn("dbo.Products", "BrandId");
            DropTable("dbo.Brands");
        }
    }
}
