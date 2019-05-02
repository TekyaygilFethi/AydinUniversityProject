namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSortOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EducationTable", "Average", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EducationTable", "Average");
        }
    }
}
