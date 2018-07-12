namespace AppTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Application",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Position = c.String(),
                        DateApplied = c.DateTime(nullable: false),
                        AppliedVia = c.String(),
                        AppSubmitted = c.Boolean(nullable: false),
                        ResSubmitted = c.Boolean(nullable: false),
                        CLSubmitted = c.Boolean(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.CompanyID, cascadeDelete: true)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ContactName = c.String(),
                        ContactTitle = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Website = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Update",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Subject = c.Int(nullable: false),
                        Note = c.String(),
                        ApplicationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Application", t => t.ApplicationID, cascadeDelete: true)
                .Index(t => t.ApplicationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Update", "ApplicationID", "dbo.Application");
            DropForeignKey("dbo.Application", "CompanyID", "dbo.Company");
            DropIndex("dbo.Update", new[] { "ApplicationID" });
            DropIndex("dbo.Application", new[] { "CompanyID" });
            DropTable("dbo.Update");
            DropTable("dbo.Company");
            DropTable("dbo.Application");
        }
    }
}
