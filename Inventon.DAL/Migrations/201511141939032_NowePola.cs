namespace Inventon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NowePola : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProduktTables", "ProduktNazwa", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.ProduktTables", "ProduktCena", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProduktTables", "ProduktCena", c => c.String());
            AlterColumn("dbo.ProduktTables", "ProduktNazwa", c => c.String());
        }
    }
}
