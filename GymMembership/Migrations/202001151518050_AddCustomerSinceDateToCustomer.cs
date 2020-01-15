namespace GymMembership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerSinceDateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerSinceDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerSinceDate");
        }
    }
}
