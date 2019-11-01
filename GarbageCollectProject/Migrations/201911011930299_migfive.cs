namespace GarbageCollectProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migfive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "WeeklyCharge", c => c.Double(nullable: false));
            AddColumn("dbo.Customers", "OneTimePickupDate", c => c.DateTime());
            AddColumn("dbo.Customers", "OneTimePickupDay", c => c.DateTime());
            AddColumn("dbo.Customers", "WeeklyPickupDay", c => c.DateTime());
            AddColumn("dbo.Customers", "HoldPickupStart", c => c.DateTime());
            AddColumn("dbo.Customers", "HoldPickupEnd", c => c.DateTime());
            DropColumn("dbo.Customers", "MonthlyCharge");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MonthlyCharge", c => c.Double(nullable: false));
            DropColumn("dbo.Customers", "HoldPickupEnd");
            DropColumn("dbo.Customers", "HoldPickupStart");
            DropColumn("dbo.Customers", "WeeklyPickupDay");
            DropColumn("dbo.Customers", "OneTimePickupDay");
            DropColumn("dbo.Customers", "OneTimePickupDate");
            DropColumn("dbo.Customers", "WeeklyCharge");
        }
    }
}
