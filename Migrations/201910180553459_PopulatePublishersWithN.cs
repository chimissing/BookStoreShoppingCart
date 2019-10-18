namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePublishersWithN : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Publishers ON");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (1,N'歐萊禮')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (2,N'碁峰')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (3,N'旗標')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (4,N'博碩')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (5,N'佳魁')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (6,N'上奇')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (7,N'電子工業')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (8,N'悅知')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (9,N'清華大學')");
            Sql("SET IDENTITY_INSERT Publishers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
