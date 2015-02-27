namespace Portfolio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedgithubfieldtoproject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "GitHubRep", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "GitHubRep");
        }
    }
}
