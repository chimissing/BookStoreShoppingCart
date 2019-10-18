namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReversePopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Genres where Name='程式語言'");
            Sql("DELETE FROM Genres where Name='前端開發'");
            Sql("DELETE FROM Genres where Name='網站開發'");
            Sql("DELETE FROM Genres where Name='資料庫'");
            Sql("DELETE FROM Genres where Name='軟體測試'");
            Sql("DELETE FROM Genres where Name='軟體架構'");
            Sql("DELETE FROM Genres where Name='資訊安全'");
            Sql("DELETE FROM Genres where Name='資料科學'");
        }
        
        public override void Down()
        {
        }
    }
}
