namespace AydinUniversityProject.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
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
                        Username = c.String(nullable: false, maxLength: 30),
                        Password = c.String(),
                        Email = c.String(nullable: false),
                        ProfilePhoto = c.String(unicode: false),
                        SentFeedsID = c.Int(),
                        FavouriteFeedsID = c.Int(),
                        IsAdmin = c.Boolean(nullable: false),
                        IsOnline = c.Boolean(nullable: false),
                        IsLoginToDesktop = c.Boolean(nullable: false),
                        PendingStatus = c.String(),
                        SignalRConnectionID = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        FriendRelationshipID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FriendRelationshipTable", t => t.FriendRelationshipID)
                .Index(t => t.Username, unique: true)
                .Index(t => t.FriendRelationshipID);
            
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
                        PeriodID = c.Int(nullable: false),
                        Credit = c.Double(nullable: false),
                        ECTSCredit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PeriodTable", t => t.PeriodID, cascadeDelete: true)
                .Index(t => t.PeriodID);
            
            CreateTable(
                "dbo.EducationTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        LessonID = c.Int(nullable: false),
                        Average = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LessonTable", t => t.LessonID)
                .ForeignKey("dbo.StudentTable", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.LessonID);
            
            CreateTable(
                "dbo.NoteTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ResultPoint = c.Double(nullable: false),
                        EffectRate = c.Double(nullable: false),
                        EducationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EducationTable", t => t.EducationID, cascadeDelete: true)
                .Index(t => t.EducationID);
            
            CreateTable(
                "dbo.StudentTable",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        PeriodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PeriodTable", t => t.PeriodID)
                .ForeignKey("dbo.UserTable", t => t.ID, cascadeDelete: true)
                .Index(t => t.ID)
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
                "dbo.FriendRelationshipTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
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
                "dbo.MessageTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MessageContent = c.String(),
                        SendTime = c.DateTime(nullable: false),
                        SenderUserID = c.Int(nullable: false),
                        ReceiverUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.ReceiverUserID)
                .ForeignKey("dbo.UserTable", t => t.SenderUserID)
                .Index(t => t.SenderUserID)
                .Index(t => t.ReceiverUserID);
            
            CreateTable(
                "dbo.ReviewTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        ReviewPoint = c.Int(nullable: false),
                        SenderID = c.Int(nullable: false),
                        ConnectionID = c.Int(nullable: false),
                        Vote = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UserTable", t => t.SenderID)
                .ForeignKey("dbo.ConnectionTable", t => t.ConnectionID, cascadeDelete: true)
                .Index(t => t.SenderID)
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConnectionTable", "ViewerID", "dbo.UserTable");
            DropForeignKey("dbo.ConnectionTable", "SharerID", "dbo.UserTable");
            DropForeignKey("dbo.ReviewTable", "ConnectionID", "dbo.ConnectionTable");
            DropForeignKey("dbo.ScreenShareRequestTable", "NewConnectionID", "dbo.ConnectionTable");
            DropForeignKey("dbo.StudentTable", "ID", "dbo.UserTable");
            DropForeignKey("dbo.ScreenShareRequestTable", "RequesterID", "dbo.UserTable");
            DropForeignKey("dbo.MessageTable", "SenderUserID", "dbo.UserTable");
            DropForeignKey("dbo.FriendRequestTable", "RequesterID", "dbo.UserTable");
            DropForeignKey("dbo.SentFeedsTable", "ID", "dbo.UserTable");
            DropForeignKey("dbo.ReviewTable", "SenderID", "dbo.UserTable");
            DropForeignKey("dbo.ScreenShareRequestTable", "RequestToID", "dbo.UserTable");
            DropForeignKey("dbo.MessageTable", "ReceiverUserID", "dbo.UserTable");
            DropForeignKey("dbo.FriendRequestTable", "RequestToID", "dbo.UserTable");
            DropForeignKey("dbo.UserTable", "FriendRelationshipID", "dbo.FriendRelationshipTable");
            DropForeignKey("dbo.FavouriteFeedsTable", "ID", "dbo.UserTable");
            DropForeignKey("dbo.PostTable", "SentFeedID", "dbo.SentFeedsTable");
            DropForeignKey("dbo.TopicTable", "SentFeedID", "dbo.SentFeedsTable");
            DropForeignKey("dbo.PostTable", "TopicID", "dbo.TopicTable");
            DropForeignKey("dbo.TopicTable", "LessonID", "dbo.LessonTable");
            DropForeignKey("dbo.LessonTable", "PeriodID", "dbo.PeriodTable");
            DropForeignKey("dbo.StudentTable", "PeriodID", "dbo.PeriodTable");
            DropForeignKey("dbo.EducationTable", "StudentID", "dbo.StudentTable");
            DropForeignKey("dbo.NoteTable", "EducationID", "dbo.EducationTable");
            DropForeignKey("dbo.EducationTable", "LessonID", "dbo.LessonTable");
            DropForeignKey("dbo.ConnectionTable", "LessonID", "dbo.LessonTable");
            DropForeignKey("dbo.TopicFavouriteFeedsTable", "FavouriteFeedID", "dbo.FavouriteFeedsTable");
            DropForeignKey("dbo.TopicFavouriteFeedsTable", "TopicID", "dbo.TopicTable");
            DropForeignKey("dbo.PostTable", "FavouriteFeedID", "dbo.FavouriteFeedsTable");
            DropIndex("dbo.TopicFavouriteFeedsTable", new[] { "FavouriteFeedID" });
            DropIndex("dbo.TopicFavouriteFeedsTable", new[] { "TopicID" });
            DropIndex("dbo.ReviewTable", new[] { "ConnectionID" });
            DropIndex("dbo.ReviewTable", new[] { "SenderID" });
            DropIndex("dbo.MessageTable", new[] { "ReceiverUserID" });
            DropIndex("dbo.MessageTable", new[] { "SenderUserID" });
            DropIndex("dbo.FriendRequestTable", new[] { "RequestToID" });
            DropIndex("dbo.FriendRequestTable", new[] { "RequesterID" });
            DropIndex("dbo.StudentTable", new[] { "PeriodID" });
            DropIndex("dbo.StudentTable", new[] { "ID" });
            DropIndex("dbo.NoteTable", new[] { "EducationID" });
            DropIndex("dbo.EducationTable", new[] { "LessonID" });
            DropIndex("dbo.EducationTable", new[] { "StudentID" });
            DropIndex("dbo.LessonTable", new[] { "PeriodID" });
            DropIndex("dbo.TopicTable", new[] { "LessonID" });
            DropIndex("dbo.TopicTable", new[] { "SentFeedID" });
            DropIndex("dbo.SentFeedsTable", new[] { "ID" });
            DropIndex("dbo.PostTable", new[] { "FavouriteFeedID" });
            DropIndex("dbo.PostTable", new[] { "SentFeedID" });
            DropIndex("dbo.PostTable", new[] { "TopicID" });
            DropIndex("dbo.FavouriteFeedsTable", new[] { "ID" });
            DropIndex("dbo.UserTable", new[] { "FriendRelationshipID" });
            DropIndex("dbo.UserTable", new[] { "Username" });
            DropIndex("dbo.ScreenShareRequestTable", new[] { "RequestToID" });
            DropIndex("dbo.ScreenShareRequestTable", new[] { "RequesterID" });
            DropIndex("dbo.ScreenShareRequestTable", new[] { "NewConnectionID" });
            DropIndex("dbo.ConnectionTable", new[] { "LessonID" });
            DropIndex("dbo.ConnectionTable", new[] { "SharerID" });
            DropIndex("dbo.ConnectionTable", new[] { "ViewerID" });
            DropTable("dbo.TopicFavouriteFeedsTable");
            DropTable("dbo.ContactTable");
            DropTable("dbo.ReviewTable");
            DropTable("dbo.MessageTable");
            DropTable("dbo.FriendRequestTable");
            DropTable("dbo.FriendRelationshipTable");
            DropTable("dbo.PeriodTable");
            DropTable("dbo.StudentTable");
            DropTable("dbo.NoteTable");
            DropTable("dbo.EducationTable");
            DropTable("dbo.LessonTable");
            DropTable("dbo.TopicTable");
            DropTable("dbo.SentFeedsTable");
            DropTable("dbo.PostTable");
            DropTable("dbo.FavouriteFeedsTable");
            DropTable("dbo.UserTable");
            DropTable("dbo.ScreenShareRequestTable");
            DropTable("dbo.ConnectionTable");
        }
    }
}
