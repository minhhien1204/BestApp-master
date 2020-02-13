namespace BestApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cats", "keu", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cats", "keu");
        }
    }
}
