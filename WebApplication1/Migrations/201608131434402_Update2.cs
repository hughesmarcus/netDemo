namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalesPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Commission = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BuyerId = c.Int(nullable: false),
                        Buyer = c.String(),
                        SellerId = c.Int(nullable: false),
                        Seller = c.String(),
                        ItemId = c.Int(nullable: false),
                        SalesPersonId = c.Int(nullable: false),
                        SalesPerson = c.String(),
                        TotalCharges = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
            DropTable("dbo.SalesPersons");
        }
    }
}
