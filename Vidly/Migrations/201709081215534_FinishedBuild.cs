namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinishedBuild : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscripedToNewsletter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsSubscripedToNewsletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
        }
    }
}
