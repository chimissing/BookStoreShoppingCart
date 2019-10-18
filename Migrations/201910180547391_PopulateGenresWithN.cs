namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresWithN : DbMigration
    {
        public override void Up()
        {

            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,N'程式語言')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,N'前端開發')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,N'網站開發')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,N'資料庫')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (5,N'軟體測試')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (6,N'軟體架構')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (7,N'資訊安全')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (8,N'資料科學')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
