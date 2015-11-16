namespace Inventon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nowe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProduktTables", "ProduktNazwa", c => c.String());
            AlterColumn("dbo.ProduktTables", "ProduktCena", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProduktTables", "ProduktCena", c => c.String(nullable: false));
            AlterColumn("dbo.ProduktTables", "ProduktNazwa", c => c.String(nullable: false, maxLength: 150));
        }
    }
}
