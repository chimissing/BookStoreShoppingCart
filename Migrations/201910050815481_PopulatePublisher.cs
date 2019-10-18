namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePublisher : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Publishers ON");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (1,'歐萊禮')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (2,'碁峰')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (3,'旗標')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (4,'博碩')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (5,'佳魁')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (6,'上奇')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (7,'電子工業')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (8,'悅知')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (9,'清華大學')");
            Sql("SET IDENTITY_INSERT Publishers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
