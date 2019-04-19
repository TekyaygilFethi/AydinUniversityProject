namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FriendRelationshipTable", "ID", "dbo.UserTable");
            DropIndex("dbo.FriendRelationshipTable", new[] { "ID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.FriendRelationshipTable", "ID");
            AddForeignKey("dbo.FriendRelationshipTable", "ID", "dbo.UserTable", "ID");
        }
    }
}
