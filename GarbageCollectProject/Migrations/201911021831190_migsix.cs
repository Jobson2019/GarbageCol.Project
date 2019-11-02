namespace GarbageCollectProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migsix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "NextPickup", c => c.DateTime());
            AddColumn("dbo.Customers", "LastPickup", c => c.DateTime());
            AlterColumn("dbo.Customers", "ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "LastPickup");
            DropColumn("dbo.Customers", "NextPickup");
        }
    }
}
