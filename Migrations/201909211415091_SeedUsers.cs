namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'15471841-0c08-4548-9b11-e257f27cc94a', N'guest@gmail.com', 0, N'AFf8ON7cZYeq2x0nAaptAGL3W+MnJKa7ocGuJkfSQcCQw5TAbQgnCZU3rmaKT4ZSwQ==', N'cf49a338-f251-43f1-8284-4f8d7dd8cb21', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'59401c96-1bbb-41f9-a88b-75089fc94e69', N'Admin@gmail.com', 0, N'ALyOrrbTtZb0u4tjZTc4+JIBGxIZZSQ+PxDDk97YKmVAf+gTGpoIJZy4s8wrjuEb9A==', N'dd1a623c-360b-43c7-a0ee-b7239ab2e3f1', NULL, 0, 0, NULL, 1, 0, N'Admin@gmail.com')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'52db98c0-cd20-4842-aef5-7f01f4651a8a', N'Admin')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'59401c96-1bbb-41f9-a88b-75089fc94e69', N'52db98c0-cd20-4842-aef5-7f01f4651a8a')

");
        }
        
        public override void Down()
        {
        }
    }
}
