namespace GarbageCollectProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migtwo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PickUpDay", c => c.DateTime());
            AlterColumn("dbo.Customers", "StartDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "ChangeDay", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "ChangeDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "PickUpDay", c => c.DateTime(nullable: false));
        }
    }
}
