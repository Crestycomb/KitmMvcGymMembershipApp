namespace GymMembership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSingleTicketsBoughtToCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SingleTicketsBought", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "SingleTicketsBought");
        }
    }
}
