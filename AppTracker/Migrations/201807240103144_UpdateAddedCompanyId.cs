namespace AppTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAddedCompanyId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Update", "CompanyID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Update", "CompanyID");
        }
    }
}
