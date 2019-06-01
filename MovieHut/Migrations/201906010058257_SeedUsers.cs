namespace MovieHut.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a9558b56-8e6c-4808-b3e4-bae436276ed1', N'admin@moviehut.com', 0, N'AJvUv92LN4hDnvI+IU1Q3f8t1sWES6AeZ4S3kbQE+iFZSKtu8Q4F/xGjKQK5KVUdVA==', N'fd5ca821-4a53-4ecf-830a-fba0d0dbc4e8', NULL, 0, 0, NULL, 1, 0, N'admin@moviehut.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f7bbba00-071e-4cb2-b7de-2f9ab8a4972a', N'guest671@gmail.com', 0, N'ANX/ItFAONMi0RR9xDYshLNUcdvX4CIpDr1wwbvAqTXucHI8xL70T3oNwMMOHaP9dQ==', N'9a9d035a-da2c-4af3-8cda-871780a04dcb', NULL, 0, 0, NULL, 1, 0, N'guest671@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5b24bec7-f583-437d-98b2-2a7350d61c47', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a9558b56-8e6c-4808-b3e4-bae436276ed1', N'5b24bec7-f583-437d-98b2-2a7350d61c47')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
