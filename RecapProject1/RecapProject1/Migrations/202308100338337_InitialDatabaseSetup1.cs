namespace RecapProject1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseSetup1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SupplierID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "UnitsInStock", c => c.Short(nullable: false));
            AddColumn("dbo.Products", "UnitsOnOrder", c => c.Short(nullable: false));
            AddColumn("dbo.Products", "ReorderLevel", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ReorderLevel");
            DropColumn("dbo.Products", "UnitsOnOrder");
            DropColumn("dbo.Products", "UnitsInStock");
            DropColumn("dbo.Products", "SupplierID");
        }
    }
}
