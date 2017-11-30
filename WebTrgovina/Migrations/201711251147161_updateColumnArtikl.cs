namespace WebTrgovina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateColumnArtikl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Artikls", "Naziv", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Artikls", "Opis", c => c.String(nullable: false));
            AlterColumn("dbo.Artikls", "Ocjena", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Artikls", "Ocjena", c => c.Int(nullable: false));
            AlterColumn("dbo.Artikls", "Opis", c => c.String());
            AlterColumn("dbo.Artikls", "Naziv", c => c.String());
        }
    }
}
