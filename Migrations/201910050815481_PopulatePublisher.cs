namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePublisher : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Publishers ON");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (1,'�ڵ�§')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (2,'�֮p')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (3,'�X��')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (4,'�պ�')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (5,'�λ�')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (6,'�W�_')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (7,'�q�l�u�~')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (8,'����')");
            Sql("INSERT INTO Publishers (Id,Name) VALUES (9,'�M�ؤj��')");
            Sql("SET IDENTITY_INSERT Publishers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
