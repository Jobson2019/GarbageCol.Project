namespace GarbageCollectProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migthree : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "UserName");
        }
    }
}
