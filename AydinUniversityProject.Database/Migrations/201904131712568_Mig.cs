namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConnectionTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ConnectionString = c.String(),
                        ConnectionName = c.String(),
                        ViewerIP = c.String(),
                        SharerIP = c.String(),
                        ViewerID = c.Int(),
                        SharerID = c.Int(),
                        IsConnectionEnded = c.Boolean(nullable: false),
                        IsConnectionStarted = c.Boolean(nullable: false),
                        ConnectionDate = c.DateTime(nullable: false),
                        ConnectionDuration = c.Time(nullable: false, precision: 7),
                        LessonID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LessonTable", t => t.LessonID)
                .ForeignKey("dbo.UserTable", t => t.SharerID)
                .ForeignKey("dbo.UserTable", t => t.ViewerID)
                .Index(t => t.ViewerID)
                .Index(t => t.SharerID)
                .Index(t => t.LessonID);
            
            CreateTable(
                "dbo.ScreenShareRequestTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NewConnectionID = c.Int(),
                        IsAccepted = c.Boolean(nullable: false),
                        RequesterID = c.Int(nullable: false),
                        RequestToID = c.Int(nullable: false),
                        RequesterRequestType = c.Int(nullable: false),
                        RequestToRequestType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.RequestToID)
                .ForeignKey("dbo.UserTable", t => t.RequesterID)
                .ForeignKey("dbo.ConnectionTable", t => t.NewConnectionID)
                .Index(t => t.NewConnectionID)
                .Index(t => t.RequesterID)
                .Index(t => t.RequestToID);
            
            CreateTable(
                "dbo.UserTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 30),
                        Password = c.String(),
                        Salt = c.String(),
                        Email = c.String(),
                        ProfilePhoto = c.String(),
                        SentFeedsID = c.Int(),
                        FavouriteFeedsID = c.Int(),
                        IsAdmin = c.Boolean(nullable: false),
                        IsOnline = c.Boolean(nullable: false),
                        IsLoginToDesktop = c.Boolean(nullable: false),
                        PendingStatus = c.String(),
                        SignalRConnectionID = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.ConversationTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MessageTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MessageContent = c.String(),
                        SendTime = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                        ConversationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.ConversationTable", t => t.ConversationID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ConversationID);
            
            CreateTable(
                "dbo.FavouriteFeedsTable",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.PostTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        AttachmentUrl = c.String(),
                        TopicID = c.Int(nullable: false),
                        PostDate = c.DateTime(nullable: false),
                        SentFeedID = c.Int(nullable: false),
                        FavouriteFeedID = c.Int(),
                        FavouritedCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FavouriteFeedsTable", t => t.FavouriteFeedID)
                .ForeignKey("dbo.TopicTable", t => t.TopicID, cascadeDelete: true)
                .ForeignKey("dbo.SentFeedsTable", t => t.SentFeedID)
                .Index(t => t.TopicID)
                .Index(t => t.SentFeedID)
                .Index(t => t.FavouriteFeedID);
            
            CreateTable(
                "dbo.SentFeedsTable",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.TopicTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SentFeedID = c.Int(nullable: false),
                        FavouritedCount = c.Int(nullable: false),
                        LessonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LessonTable", t => t.LessonID)
                .ForeignKey("dbo.SentFeedsTable", t => t.SentFeedID, cascadeDelete: true)
                .Index(t => t.SentFeedID)
                .Index(t => t.LessonID);
            
            CreateTable(
                "dbo.LessonTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EducationTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        LessonID = c.Int(nullable: false),
                        PeriodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LessonTable", t => t.LessonID)
                .ForeignKey("dbo.PeriodTable", t => t.PeriodID, cascadeDelete: true)
                .ForeignKey("dbo.StudentTable", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.LessonID)
                .Index(t => t.PeriodID);
            
            CreateTable(
                "dbo.PeriodTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Semester = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ScoreTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EducationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EducationTable", t => t.EducationID, cascadeDelete: true)
                .Index(t => t.EducationID);
            
            CreateTable(
                "dbo.NoteTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ResultPoint = c.Double(nullable: false),
                        EffectRate = c.Double(nullable: false),
                        ScoreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ScoreTable", t => t.ScoreID, cascadeDelete: true)
                .Index(t => t.ScoreID);
            
            CreateTable(
                "dbo.StudentTable",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.FriendRequestTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RequesterID = c.Int(nullable: false),
                        RequestToID = c.Int(nullable: false),
                        IsAccepted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.RequestToID)
                .ForeignKey("dbo.UserTable", t => t.RequesterID)
                .Index(t => t.RequesterID)
                .Index(t => t.RequestToID);
            
            CreateTable(
                "dbo.ReviewTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        ReviewPoint = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ConnectionID = c.Int(nullable: false),
                        Vote = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.ConnectionTable", t => t.ConnectionID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ConnectionID);
            
            CreateTable(
                "dbo.ContactTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserConversationTable",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        ConversationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.ConversationID })
                .ForeignKey("dbo.UserTable", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.ConversationTable", t => t.ConversationID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.ConversationID);
            
            CreateTable(
                "dbo.TopicFavouriteFeedsTable",
                c => new
                    {
                        TopicID = c.Int(nullable: false),
                        FavouriteFeedID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TopicID, t.FavouriteFeedID })
                .ForeignKey("dbo.TopicTable", t => t.TopicID, cascadeDelete: true)
                .ForeignKey("dbo.FavouriteFeedsTable", t => t.FavouriteFeedID, cascadeDelete: true)
                .Index(t => t.TopicID)
                .Index(t => t.FavouriteFeedID);
            
            CreateTable(
                "dbo.UserFriendTable",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        User_ID1 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.User_ID1 })
                .ForeignKey("dbo.UserTable", t => t.User_ID)
                .ForeignKey("dbo.UserTable", t => t.User_ID1)
                .Index(t => t.User_ID)
                .Index(t => t.User_ID1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConnectionTable", "ViewerID", "dbo.UserTable");
            DropForeignKey("dbo.ConnectionTable", "SharerID", "dbo.UserTable");
            DropForeignKey("dbo.ReviewTable", "ConnectionID", "dbo.ConnectionTable");
            DropForeignKey("dbo.ReviewTable", "UserID", "dbo.UserTable");
            DropForeignKey("dbo.ScreenShareRequestTable", "NewConnectionID", "dbo.ConnectionTable");
            DropForeignKey("dbo.StudentTable", "ID", "dbo.UserTable");
            DropForeignKey("dbo.ScreenShareRequestTable", "RequesterID", "dbo.UserTable");
            DropForeignKey("dbo.FriendRequestTable", "RequesterID", "dbo.UserTable");
            DropForeignKey("dbo.SentFeedsTable", "ID", "dbo.UserTable");
            DropForeignKey("dbo.ScreenShareRequestTable", "RequestToID", "dbo.UserTable");
            DropForeignKey("dbo.FriendRequestTable", "RequestToID", "dbo.UserTable");
            DropForeignKey("dbo.UserFriendTable", "User_ID1", "dbo.UserTable");
            DropForeignKey("dbo.UserFriendTable", "User_ID", "dbo.UserTable");
            DropForeignKey("dbo.FavouriteFeedsTable", "ID", "dbo.UserTable");
            DropForeignKey("dbo.PostTable", "SentFeedID", "dbo.SentFeedsTable");
            DropForeignKey("dbo.TopicTable", "SentFeedID", "dbo.SentFeedsTable");
            DropForeignKey("dbo.PostTable", "TopicID", "dbo.TopicTable");
            DropForeignKey("dbo.TopicTable", "LessonID", "dbo.LessonTable");
            DropForeignKey("dbo.EducationTable", "StudentID", "dbo.StudentTable");
            DropForeignKey("dbo.NoteTable", "ScoreID", "dbo.ScoreTable");
            DropForeignKey("dbo.ScoreTable", "EducationID", "dbo.EducationTable");
            DropForeignKey("dbo.EducationTable", "PeriodID", "dbo.PeriodTable");
            DropForeignKey("dbo.EducationTable", "LessonID", "dbo.LessonTable");
            DropForeignKey("dbo.ConnectionTable", "LessonID", "dbo.LessonTable");
            DropForeignKey("dbo.TopicFavouriteFeedsTable", "FavouriteFeedID", "dbo.FavouriteFeedsTable");
            DropForeignKey("dbo.TopicFavouriteFeedsTable", "TopicID", "dbo.TopicTable");
            DropForeignKey("dbo.PostTable", "FavouriteFeedID", "dbo.FavouriteFeedsTable");
            DropForeignKey("dbo.UserConversationTable", "ConversationID", "dbo.ConversationTable");
            DropForeignKey("dbo.UserConversationTable", "UserID", "dbo.UserTable");
            DropForeignKey("dbo.MessageTable", "ConversationID", "dbo.ConversationTable");
            DropForeignKey("dbo.MessageTable", "UserID", "dbo.UserTable");
            DropIndex("dbo.UserFriendTable", new[] { "User_ID1" });
            DropIndex("dbo.UserFriendTable", new[] { "User_ID" });
            DropIndex("dbo.TopicFavouriteFeedsTable", new[] { "FavouriteFeedID" });
            DropIndex("dbo.TopicFavouriteFeedsTable", new[] { "TopicID" });
            DropIndex("dbo.UserConversationTable", new[] { "ConversationID" });
            DropIndex("dbo.UserConversationTable", new[] { "UserID" });
            DropIndex("dbo.ReviewTable", new[] { "ConnectionID" });
            DropIndex("dbo.ReviewTable", new[] { "UserID" });
            DropIndex("dbo.FriendRequestTable", new[] { "RequestToID" });
            DropIndex("dbo.FriendRequestTable", new[] { "RequesterID" });
            DropIndex("dbo.StudentTable", new[] { "ID" });
            DropIndex("dbo.NoteTable", new[] { "ScoreID" });
            DropIndex("dbo.ScoreTable", new[] { "EducationID" });
            DropIndex("dbo.EducationTable", new[] { "PeriodID" });
            DropIndex("dbo.EducationTable", new[] { "LessonID" });
            DropIndex("dbo.EducationTable", new[] { "StudentID" });
            DropIndex("dbo.TopicTable", new[] { "LessonID" });
            DropIndex("dbo.TopicTable", new[] { "SentFeedID" });
            DropIndex("dbo.SentFeedsTable", new[] { "ID" });
            DropIndex("dbo.PostTable", new[] { "FavouriteFeedID" });
            DropIndex("dbo.PostTable", new[] { "SentFeedID" });
            DropIndex("dbo.PostTable", new[] { "TopicID" });
            DropIndex("dbo.FavouriteFeedsTable", new[] { "ID" });
            DropIndex("dbo.MessageTable", new[] { "ConversationID" });
            DropIndex("dbo.MessageTable", new[] { "UserID" });
            DropIndex("dbo.UserTable", new[] { "Username" });
            DropIndex("dbo.ScreenShareRequestTable", new[] { "RequestToID" });
            DropIndex("dbo.ScreenShareRequestTable", new[] { "RequesterID" });
            DropIndex("dbo.ScreenShareRequestTable", new[] { "NewConnectionID" });
            DropIndex("dbo.ConnectionTable", new[] { "LessonID" });
            DropIndex("dbo.ConnectionTable", new[] { "SharerID" });
            DropIndex("dbo.ConnectionTable", new[] { "ViewerID" });
            DropTable("dbo.UserFriendTable");
            DropTable("dbo.TopicFavouriteFeedsTable");
            DropTable("dbo.UserConversationTable");
            DropTable("dbo.ContactTable");
            DropTable("dbo.ReviewTable");
            DropTable("dbo.FriendRequestTable");
            DropTable("dbo.StudentTable");
            DropTable("dbo.NoteTable");
            DropTable("dbo.ScoreTable");
            DropTable("dbo.PeriodTable");
            DropTable("dbo.EducationTable");
            DropTable("dbo.LessonTable");
            DropTable("dbo.TopicTable");
            DropTable("dbo.SentFeedsTable");
            DropTable("dbo.PostTable");
            DropTable("dbo.FavouriteFeedsTable");
            DropTable("dbo.MessageTable");
            DropTable("dbo.ConversationTable");
            DropTable("dbo.UserTable");
            DropTable("dbo.ScreenShareRequestTable");
            DropTable("dbo.ConnectionTable");
        }
    }
}
