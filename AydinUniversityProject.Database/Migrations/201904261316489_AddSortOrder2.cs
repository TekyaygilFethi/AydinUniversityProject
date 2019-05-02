namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSortOrder2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PostTable", "FavouriteFeedID", "dbo.FavouriteFeedsTable");
            DropIndex("dbo.PostTable", new[] { "FavouriteFeedID" });
            CreateTable(
                "dbo.PostFavouriteFeedsTable",
                c => new
                    {
                        PostID = c.Int(nullable: false),
                        FavouriteFeedID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PostID, t.FavouriteFeedID })
                .ForeignKey("dbo.PostTable", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.FavouriteFeedsTable", t => t.FavouriteFeedID, cascadeDelete: true)
                .Index(t => t.PostID)
                .Index(t => t.FavouriteFeedID);
            
            DropColumn("dbo.PostTable", "FavouriteFeedID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostTable", "FavouriteFeedID", c => c.Int());
            DropForeignKey("dbo.PostFavouriteFeedsTable", "FavouriteFeedID", "dbo.FavouriteFeedsTable");
            DropForeignKey("dbo.PostFavouriteFeedsTable", "PostID", "dbo.PostTable");
            DropIndex("dbo.PostFavouriteFeedsTable", new[] { "FavouriteFeedID" });
            DropIndex("dbo.PostFavouriteFeedsTable", new[] { "PostID" });
            DropTable("dbo.PostFavouriteFeedsTable");
            CreateIndex("dbo.PostTable", "FavouriteFeedID");
            AddForeignKey("dbo.PostTable", "FavouriteFeedID", "dbo.FavouriteFeedsTable", "ID");
        }
    }
}
