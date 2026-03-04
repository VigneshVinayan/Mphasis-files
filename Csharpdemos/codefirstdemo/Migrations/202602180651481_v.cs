namespace codefirstdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "phone", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "phone", c => c.String(maxLength: 15, unicode: false));
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(maxLength: 100));
        }
    }
}
