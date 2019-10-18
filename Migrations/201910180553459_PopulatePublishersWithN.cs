namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePublishersWithN : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Publishers ON");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (1,N'�ڵ�§')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (2,N'�֮p')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (3,N'�X��')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (4,N'�պ�')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (5,N'�λ�')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (6,N'�W�_')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (7,N'�q�l�u�~')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (8,N'����')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (9,N'�M�ؤj��')");
            Sql("SET IDENTITY_INSERT Publishers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
