namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresWithN : DbMigration
    {
        public override void Up()
        {

            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,N'�{���y��')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,N'�e�ݶ}�o')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,N'�����}�o')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,N'��Ʈw')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (5,N'�n�����')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (6,N'�n��[�c')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (7,N'��T�w��')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (8,N'��Ƭ��')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
