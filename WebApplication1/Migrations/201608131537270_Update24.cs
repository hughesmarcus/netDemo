namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update24 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Item", c => c.String());
            AddColumn("dbo.Transactions", "Shipping", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Shipping");
            DropColumn("dbo.Transactions", "Item");
        }
    }
}
