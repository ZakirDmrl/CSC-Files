namespace RecapProject1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseSetup : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "UnitInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "UnitInStock", c => c.Short(nullable: false));
        }
    }
}
