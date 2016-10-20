namespace ZenithWebsite.Migrations.Zenith
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 75),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                        UserName = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        ActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: true)
                .Index(t => t.ActivityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "ActivityId", "dbo.Activities");
            DropIndex("dbo.Events", new[] { "ActivityId" });
            DropTable("dbo.Events");
            DropTable("dbo.Activities");
        }
    }
}
