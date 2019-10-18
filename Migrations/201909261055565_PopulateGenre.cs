namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('程式語言')");
            Sql("INSERT INTO Genres (Name) VALUES ('前端開發')");
            Sql("INSERT INTO Genres (Name) VALUES ('網站開發')");
            Sql("INSERT INTO Genres (Name) VALUES ('資料庫')");
            Sql("INSERT INTO Genres (Name) VALUES ('軟體測試')");
            Sql("INSERT INTO Genres (Name) VALUES ('軟體架構')");
            Sql("INSERT INTO Genres (Name) VALUES ('資訊安全')");
            Sql("INSERT INTO Genres (Name) VALUES ('資料科學')");
        }
        
        public override void Down()
        {
        }
    }
}
