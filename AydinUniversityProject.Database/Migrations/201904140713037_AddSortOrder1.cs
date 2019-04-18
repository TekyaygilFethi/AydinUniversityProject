namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSortOrder1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.UserTable", new[] { "Username" });
            AlterColumn("dbo.UserTable", "Username", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.UserTable", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.UserTable", "ProfilePhoto", c => c.String(unicode: false));
            CreateIndex("dbo.UserTable", "Username", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserTable", new[] { "Username" });
            AlterColumn("dbo.UserTable", "ProfilePhoto", c => c.String());
            AlterColumn("dbo.UserTable", "Email", c => c.String());
            AlterColumn("dbo.UserTable", "Username", c => c.String(maxLength: 30));
            CreateIndex("dbo.UserTable", "Username", unique: true);
        }
    }
}
