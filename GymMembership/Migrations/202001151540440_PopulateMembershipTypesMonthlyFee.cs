namespace GymMembership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesMonthlyFee : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MonthlyFee = 0 WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET MonthlyFee = 30 WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET MonthlyFee = 20 WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
