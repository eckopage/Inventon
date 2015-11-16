namespace Inventon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KategoriaTables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        KategoriaNazwa = c.String(),
                        KategoriaOpis = c.String(),
                        KategoriaDataDodania = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProduktTables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ProduktNazwa = c.String(),
                        ProduktOpis = c.String(),
                        ProduktCena = c.String(),
                        ProduktDataDodania = c.DateTime(),
                        ProduktProducentId = c.Int(),
                        KategoriaId = c.Int(nullable: false),
                        KategoriaTable_id = c.Int(),
                        ProducentTable_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.KategoriaTables", t => t.KategoriaTable_id)
                .ForeignKey("dbo.ProducentTables", t => t.ProducentTable_id)
                .Index(t => t.KategoriaTable_id)
                .Index(t => t.ProducentTable_id);
            
            CreateTable(
                "dbo.ProducentTables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ProducentNazwa = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProduktZamowienieTables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ZamowienieId = c.Int(nullable: false),
                        ProduktId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaSuma = c.String(),
                        ProduktTable_id = c.Int(),
                        ZamowienieTable_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ProduktTables", t => t.ProduktTable_id)
                .ForeignKey("dbo.ZamowienieTables", t => t.ZamowienieTable_id)
                .Index(t => t.ProduktTable_id)
                .Index(t => t.ZamowienieTable_id);
            
            CreateTable(
                "dbo.ZamowienieTables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        KodPocztowy = c.String(),
                        Miejscowosc = c.String(),
                        Adres = c.String(),
                        Telefon = c.String(),
                        Email = c.String(),
                        StatusZamowieniaId = c.Int(nullable: false),
                        DataPrzyjecia = c.DateTime(nullable: false),
                        StatusZamowieniaTable_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.StatusZamowieniaTables", t => t.StatusZamowieniaTable_id)
                .Index(t => t.StatusZamowieniaTable_id);
            
            CreateTable(
                "dbo.StatusZamowieniaTables",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StatusNazwa = c.String(),
                        StatusOpis = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ZamowienieTables", new[] { "StatusZamowieniaTable_id" });
            DropIndex("dbo.ProduktZamowienieTables", new[] { "ZamowienieTable_id" });
            DropIndex("dbo.ProduktZamowienieTables", new[] { "ProduktTable_id" });
            DropIndex("dbo.ProduktTables", new[] { "ProducentTable_id" });
            DropIndex("dbo.ProduktTables", new[] { "KategoriaTable_id" });
            DropForeignKey("dbo.ZamowienieTables", "StatusZamowieniaTable_id", "dbo.StatusZamowieniaTables");
            DropForeignKey("dbo.ProduktZamowienieTables", "ZamowienieTable_id", "dbo.ZamowienieTables");
            DropForeignKey("dbo.ProduktZamowienieTables", "ProduktTable_id", "dbo.ProduktTables");
            DropForeignKey("dbo.ProduktTables", "ProducentTable_id", "dbo.ProducentTables");
            DropForeignKey("dbo.ProduktTables", "KategoriaTable_id", "dbo.KategoriaTables");
            DropTable("dbo.StatusZamowieniaTables");
            DropTable("dbo.ZamowienieTables");
            DropTable("dbo.ProduktZamowienieTables");
            DropTable("dbo.ProducentTables");
            DropTable("dbo.ProduktTables");
            DropTable("dbo.KategoriaTables");
        }
    }
}
