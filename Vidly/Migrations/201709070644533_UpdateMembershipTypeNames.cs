namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE ID = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
