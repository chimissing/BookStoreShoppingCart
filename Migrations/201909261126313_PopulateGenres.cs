namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id,Name) VALUES (1,'程式語言')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (2,'前端開發')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (3,'網站開發')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (4,'資料庫')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (5,'軟體測試')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (6,'軟體架構')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (7,'資訊安全')");
            Sql("INSERT INTO Genres (Id,Name) VALUES (8,'資料科學')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
        }
    }
}
