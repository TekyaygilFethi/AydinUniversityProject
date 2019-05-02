namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSortOrder1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PostTable", "LessonID", c => c.Int(nullable: false));
            CreateIndex("dbo.PostTable", "LessonID");
            AddForeignKey("dbo.PostTable", "LessonID", "dbo.LessonTable", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostTable", "LessonID", "dbo.LessonTable");
            DropIndex("dbo.PostTable", new[] { "LessonID" });
            DropColumn("dbo.PostTable", "LessonID");
        }
    }
}
