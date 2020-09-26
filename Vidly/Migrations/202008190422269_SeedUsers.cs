namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5b33151e-d450-46f5-a5c4-fff31c6ad8bb', N'guest@vidly.com', 0, N'APy2NU3eq85KIHV7EaiInZVIpBx176GW/LARwwshPZ+cYxzcR/Vqs19KnCWIsW7GHw==', N'3345a7f9-377b-4b58-95c5-290a016f0c69', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c36e46a-96dc-4462-b59b-09fb7c21ab48', N'admin@vidly.com', 0, N'AAaDsd8sgFhsg5UbM/6ZlABzPEBLdczzVXriysUvGm0YC7qi74kdm6beyui0OrOOSw==', N'24e5beff-6cf0-4192-b352-5635f5a9a23c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b10a6e75-b785-4e8c-b377-fc7dd893f01f', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9c36e46a-96dc-4462-b59b-09fb7c21ab48', N'b10a6e75-b785-4e8c-b377-fc7dd893f01f')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
