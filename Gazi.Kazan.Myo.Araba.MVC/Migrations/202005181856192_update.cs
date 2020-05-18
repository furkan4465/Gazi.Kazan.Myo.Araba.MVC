namespace Gazi.Kazan.Myo.Araba.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblOzellikler", "detay", c => c.String(maxLength: 50, unicode: false));
            DropTable("dbo.tblDetay");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblDetay",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AracId = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.tblOzellikler", "detay");
        }
    }
}
