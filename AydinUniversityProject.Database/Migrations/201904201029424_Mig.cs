namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EducationTable", "Average");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EducationTable", "Average", c => c.Double(nullable: false));
        }
    }
}
