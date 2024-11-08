namespace MvcOnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denemekargo2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KargoDetays", "Tarih", c => c.DateTime(nullable: false));
            DropColumn("dbo.KargoDetays", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KargoDetays", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.KargoDetays", "Tarih");
        }
    }
}
