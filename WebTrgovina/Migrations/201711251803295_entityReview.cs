namespace WebTrgovina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entityReview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ocjena = c.Int(nullable: false),
                        Opis = c.String(maxLength: 255),
                        ArtiklId = c.Int(nullable: false),
                        ApplicationUserId = c.Int(nullable: false),
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
            DropForeignKey("dbo.Reviews", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reviews", "ArtiklId", "dbo.Artikls");
            DropIndex("dbo.Reviews", new[] { "User_Id" });
            DropIndex("dbo.Reviews", new[] { "ArtiklId" });
            DropTable("dbo.Reviews");
        }
    }
}
