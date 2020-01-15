namespace GymMembership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetSingleTicketsBoughtInCustomersToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "SingleTicketsBought", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "SingleTicketsBought", c => c.Int(nullable: false));
        }
    }
}
