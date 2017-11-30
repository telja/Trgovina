namespace WebTrgovina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addKosare : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kosaras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.Int(nullable: false),
                        ArtiklId = c.Int(nullable: false),
                        DatumNarudzbe = c.DateTime(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artikls", t => t.ArtiklId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.ArtiklId)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kosaras", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Kosaras", "ArtiklId", "dbo.Artikls");
            DropIndex("dbo.Kosaras", new[] { "User_Id" });
            DropIndex("dbo.Kosaras", new[] { "ArtiklId" });
            DropTable("dbo.Kosaras");
        }
    }
}
