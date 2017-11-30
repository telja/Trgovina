namespace WebTrgovina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateColumsArtikl2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Artikls", "Ocjena");
            DropColumn("dbo.Artikls", "Review");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artikls", "Review", c => c.String());
            AddColumn("dbo.Artikls", "Ocjena", c => c.Int());
        }
    }
}
