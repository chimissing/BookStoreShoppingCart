namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('�{���y��')");
            Sql("INSERT INTO Genres (Name) VALUES ('�e�ݶ}�o')");
            Sql("INSERT INTO Genres (Name) VALUES ('�����}�o')");
            Sql("INSERT INTO Genres (Name) VALUES ('��Ʈw')");
            Sql("INSERT INTO Genres (Name) VALUES ('�n�����')");
            Sql("INSERT INTO Genres (Name) VALUES ('�n��[�c')");
            Sql("INSERT INTO Genres (Name) VALUES ('��T�w��')");
            Sql("INSERT INTO Genres (Name) VALUES ('��Ƭ��')");
        }
        
        public override void Down()
        {
        }
    }
}
