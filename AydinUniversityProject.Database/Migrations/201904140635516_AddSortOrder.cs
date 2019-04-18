namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSortOrder : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserTable", "Salt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserTable", "Salt", c => c.String());
        }
    }
}
