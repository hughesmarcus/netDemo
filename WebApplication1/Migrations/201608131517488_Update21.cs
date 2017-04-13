namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Date");
        }
    }
}
