namespace codefirstdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "age", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "Email", c => c.String());
            AddColumn("dbo.Customers", "Nationality", c => c.String());
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(maxLength: 30, unicode: false));
            DropColumn("dbo.Customers", "Nationality");
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "age");
        }
    }
}
