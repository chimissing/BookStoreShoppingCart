namespace BookStoreShoppingCart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReversePopulatePublishers : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Publishers where Name='�ڵ�§'");
            Sql("DELETE FROM Publishers where Name='�֮p'");
            Sql("DELETE FROM Publishers where Name='�X��'");
            Sql("DELETE FROM Publishers where Name='�պ�'");
            Sql("DELETE FROM Publishers where Name='�λ�'");
            Sql("DELETE FROM Publishers where Name='�W�_'");
            Sql("DELETE FROM Publishers where Name='�q�l�u�~'");
            Sql("DELETE FROM Publishers where Name='����'");
            Sql("DELETE FROM Publishers where Name='�M�ؤj��'");
        }
        
        public override void Down()
        {
        }
    }
}
