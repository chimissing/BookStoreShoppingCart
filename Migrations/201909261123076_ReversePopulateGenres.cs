namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReversePopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Genres where Name='�{���y��'");
            Sql("DELETE FROM Genres where Name='�e�ݶ}�o'");
            Sql("DELETE FROM Genres where Name='�����}�o'");
            Sql("DELETE FROM Genres where Name='��Ʈw'");
            Sql("DELETE FROM Genres where Name='�n�����'");
            Sql("DELETE FROM Genres where Name='�n��[�c'");
            Sql("DELETE FROM Genres where Name='��T�w��'");
            Sql("DELETE FROM Genres where Name='��Ƭ��'");
        }
        
        public override void Down()
        {
        }
    }
}
