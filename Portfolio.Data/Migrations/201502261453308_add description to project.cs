namespace Portfolio.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddescriptiontoproject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Description");
        }
    }
}
