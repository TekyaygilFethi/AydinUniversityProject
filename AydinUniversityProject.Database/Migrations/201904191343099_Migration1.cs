namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.FriendRelationshipTable", "ID");
            AddForeignKey("dbo.FriendRelationshipTable", "ID", "dbo.UserTable", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FriendRelationshipTable", "ID", "dbo.UserTable");
            DropIndex("dbo.FriendRelationshipTable", new[] { "ID" });
        }
    }
}
