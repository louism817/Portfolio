namespace Portfolio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddbtablestodbcontext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.FeatureId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.ProjFeatures",
                c => new
                    {
                        ProjFeatureId = c.Int(nullable: false, identity: true),
                        FeatureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjFeatureId)
                .ForeignKey("dbo.Features", t => t.FeatureId, cascadeDelete: true)
                .Index(t => t.FeatureId);
            
            CreateTable(
                "dbo.ProjTeches",
                c => new
                    {
                        ProjTechId = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjTechId)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Teches",
                c => new
                    {
                        TechId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TechId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjTeches", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ProjFeatures", "FeatureId", "dbo.Features");
            DropIndex("dbo.ProjTeches", new[] { "ProjectId" });
            DropIndex("dbo.ProjFeatures", new[] { "FeatureId" });
            DropTable("dbo.Teches");
            DropTable("dbo.ProjTeches");
            DropTable("dbo.ProjFeatures");
            DropTable("dbo.Projects");
            DropTable("dbo.Features");
        }
    }
}
