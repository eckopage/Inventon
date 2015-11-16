namespace Inventon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PoprawionePola : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProduktTables", "ProduktProducentId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProduktTables", "ProduktProducentId", c => c.Int(nullable: false));
        }
    }
}
