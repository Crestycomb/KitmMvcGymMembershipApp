namespace GymMembership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'63f31985-9beb-4a16-ab74-f69ed3100145', N'admin@sveikuoliai.com', 0, N'AEzjr9tqopRLn7IEUeREVucldhhVSmv4Rf0OjSs9ZJny4+WVs2hASHWHYUk18/sFLQ==', N'25329193-4149-46a8-bc76-dd39e2a8b395', NULL, 0, 0, NULL, 1, 0, N'admin@sveikuoliai.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65dbcf8c-0472-4a0b-953d-a9fbdf136456', N'guest@sveikuoliai.com', 0, N'AGo0nusQJROK2Hnv1CCWnLTsQ67Fy4N/w7Sbm66AtWFuk8XW6OaHBbYSxVMP7ksIsg==', N'889690f1-a72a-47ea-98a1-ccb1234e9f0e', NULL, 0, 0, NULL, 1, 0, N'guest@sveikuoliai.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd7b648d4-9915-4aef-9e9f-9d5e429921be', N'CanManageCustomers')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'63f31985-9beb-4a16-ab74-f69ed3100145', N'd7b648d4-9915-4aef-9e9f-9d5e429921be')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
