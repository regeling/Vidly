namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeWithNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE ID = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE ID = 2");
        }
        
        public override void Down()
        {
        }
    }
}
