namespace EFDemo.DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migSiparis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MUSTERIL",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Ad = c.String(),
                        SOYAD = c.String(nullable: false, maxLength: 50),
                        YAS = c.Int(nullable: false),
                        MAIL = c.String(nullable: false, maxLength: 50),
                        ADMIN = c.Int(),
                        KULLANICIADI = c.String(nullable: false, maxLength: 20),
                        PASSWORD = c.String(nullable: false, maxLength: 50),
                        BAKIYE = c.Double(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SIPARISs",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        MUSTERI_ID = c.Long(nullable: false),
                        URUN_ID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MUSTERI", t => t.MUSTERI_ID, cascadeDelete: true)
                .ForeignKey("dbo.URUN", t => t.URUN_ID, cascadeDelete: true)
                .Index(t => t.MUSTERI_ID)
                .Index(t => t.URUN_ID);
            
            CreateTable(
                "dbo.URUdN",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        URUNAD = c.String(nullable: false, maxLength: 50),
                        FIYAT = c.Double(nullable: false),
                        STOK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SIPARIS", "URUN_ID", "dbo.URUN");
            DropForeignKey("dbo.SIPARIS", "MUSTERI_ID", "dbo.MUSTERI");
            DropIndex("dbo.SIPARIS", new[] { "URUN_ID" });
            DropIndex("dbo.SIPARIS", new[] { "MUSTERI_ID" });
            DropTable("dbo.URUN");
            DropTable("dbo.SIPARIS");
            DropTable("dbo.MUSTERI");
        }
    }
}
