namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReversePopulatePublishers : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Publishers where Name='歐萊禮'");
            Sql("DELETE FROM Publishers where Name='碁峰'");
            Sql("DELETE FROM Publishers where Name='旗標'");
            Sql("DELETE FROM Publishers where Name='博碩'");
            Sql("DELETE FROM Publishers where Name='佳魁'");
            Sql("DELETE FROM Publishers where Name='上奇'");
            Sql("DELETE FROM Publishers where Name='電子工業'");
            Sql("DELETE FROM Publishers where Name='悅知'");
            Sql("DELETE FROM Publishers where Name='清華大學'");
        }
        
        public override void Down()
        {
        }
    }
}
