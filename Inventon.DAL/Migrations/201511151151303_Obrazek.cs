namespace Inventon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Obrazek : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProduktTables", "Obrazek", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProduktTables", "Obrazek");
        }
    }
}
