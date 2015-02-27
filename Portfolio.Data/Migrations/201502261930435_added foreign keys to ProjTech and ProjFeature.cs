namespace Portfolio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedforeignkeystoProjTechandProjFeature : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjFeatures", "ProjectId", c => c.Int(nullable: false));
            AddColumn("dbo.ProjTeches", "TechId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProjFeatures", "ProjectId");
            CreateIndex("dbo.ProjTeches", "TechId");
            AddForeignKey("dbo.ProjFeatures", "ProjectId", "dbo.Projects", "ProjectId", cascadeDelete: true);
            AddForeignKey("dbo.ProjTeches", "TechId", "dbo.Teches", "TechId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjTeches", "TechId", "dbo.Teches");
            DropForeignKey("dbo.ProjFeatures", "ProjectId", "dbo.Projects");
            DropIndex("dbo.ProjTeches", new[] { "TechId" });
            DropIndex("dbo.ProjFeatures", new[] { "ProjectId" });
            DropColumn("dbo.ProjTeches", "TechId");
            DropColumn("dbo.ProjFeatures", "ProjectId");
        }
    }
}
