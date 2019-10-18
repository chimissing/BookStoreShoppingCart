namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'�{���y��')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'�e�ݶ}�o')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'�����}�o')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,'��Ʈw')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (5,'�n�����')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (6,'�n��[�c')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (7,'��T�w��')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (8,'��Ƭ��')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
