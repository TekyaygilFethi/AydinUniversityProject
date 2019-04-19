using AydinUniversityProject.Data.POCOs;
using System;
using System.Data.Entity;

namespace AydinUniversityProject.Database.Context
{
    public class AydinUniversityProjectContext : DbContext, IDisposable
    {
        public AydinUniversityProjectContext() : base("AydinUniversityProjectDb") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<SentFeeds> SentFeeds { get; set; }
        public DbSet<FavouriteFeeds> FavouriteFeeds { get; set; }
        public DbSet<ScreenShareRequest> ScreenShareRequests { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FriendRequest> FriendRequests { get; set; }
        public DbSet<FriendRelationship> FriendRelationships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region User FLUENT API
            modelBuilder.Entity<User>()
                .HasOptional(o => o.FavouriteFeeds)
                .WithRequired(r => r.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(o => o.SentFeeds)
                .WithRequired(r => r.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(r => r.Student)
                .WithRequiredPrincipal(r => r.User)
                .WillCascadeOnDelete(true);
                            
            modelBuilder.Entity<User>()
                .HasMany(m => m.SentFriendRequests)
                .WithRequired(r => r.Requester)
                .HasForeignKey(fk => fk.RequesterID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(m => m.ReceivedFriendRequests)
                .WithRequired(r => r.RequestTo)
                .HasForeignKey(fk => fk.RequestToID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(u => u.FriendRelationship)
                .WithMany(m => m.Friends)
                .HasForeignKey(fk => fk.FriendRelationshipID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithRequired(m => m.Sender)
                .HasForeignKey(fk => fk.SenderID)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.Friends)
            //    .WithMany()
            //    .Map(m => m.ToTable("UserFriendTable"));

            modelBuilder.Entity<User>()
                .HasMany(m => m.SentScreenShareRequests)
                .WithRequired(r => r.Requester)
                .HasForeignKey(fk => fk.RequesterID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(m => m.ReceivedScreenShareRequests)
                .WithRequired(r => r.RequestTo)
                .HasForeignKey(fk => fk.RequestToID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(m => m.SentMessages)
                .WithRequired(r => r.SenderUser)
                .HasForeignKey(fk => fk.SenderUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(m => m.ReceivedMessages)
                .WithRequired(r => r.ReceiverUser)
                .HasForeignKey(fk => fk.ReceiverUserID)
                .WillCascadeOnDelete(false);

            #endregion

            #region Student FLUENT API
            modelBuilder.Entity<Student>()
                .HasMany(m => m.Educations)
                .WithRequired(r => r.Student)
                .HasForeignKey(fk => fk.StudentID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Student>()
                .HasRequired(r => r.Period)
                .WithMany(m => m.Students)
                .HasForeignKey(fk => fk.PeriodID)
                .WillCascadeOnDelete(false);

            #endregion

            #region Education FLUENT API
            modelBuilder.Entity<Education>()
                .HasRequired(m => m.Lesson)
                .WithMany(mm => mm.Educations)
                .HasForeignKey(fk => fk.LessonID)
                .WillCascadeOnDelete(false);


            #endregion

            #region Lesson FLUENT API
            modelBuilder.Entity<Lesson>()
                .HasRequired(r => r.Period)
                .WithMany(m => m.Lessons)
                .HasForeignKey(fk => fk.PeriodID)
                .WillCascadeOnDelete(true);
            #endregion

            #region Topic FLUENT API

            modelBuilder.Entity<Topic>()
                .HasMany(m => m.Posts)
                .WithRequired(r => r.Topic)
                .HasForeignKey(fk => fk.TopicID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Topic>()
                .HasMany(m => m.FavouriteFeeds)
                .WithMany(o => o.FavouriteTopics)
                .Map(map => map.MapLeftKey("TopicID").MapRightKey("FavouriteFeedID").ToTable("TopicFavouriteFeedsTable"));

            modelBuilder.Entity<Topic>()
                .HasRequired(r => r.SentFeed)
                .WithMany(m => m.SentTopics)
                .HasForeignKey(fk => fk.SentFeedID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Topic>()
                .HasRequired(r => r.Lesson)
                .WithMany(m => m.Topics)
                .HasForeignKey(fk => fk.LessonID)
                .WillCascadeOnDelete(false);

            #endregion

            #region Note FLUENT API
            modelBuilder.Entity<Note>()
                .HasRequired(r => r.Education)
                .WithMany(m => m.Notes)
                .HasForeignKey(fk => fk.EducationID)
                .WillCascadeOnDelete(true);
            #endregion

            #region Post Fluent API

            modelBuilder.Entity<Post>()
                .HasRequired(r => r.SentFeed)
                .WithMany(m => m.SentPosts)
                .HasForeignKey(fk => fk.SentFeedID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .HasOptional(r => r.FavouriteFeed)
                .WithMany(m => m.FavouritePosts)
                .HasForeignKey(fk => fk.FavouriteFeedID)
                .WillCascadeOnDelete(false);


            #endregion

            #region Connection Fluent API
            modelBuilder.Entity<Connection>()
                .HasMany(m => m.Reviews)
                .WithRequired(r => r.Connection)
                .HasForeignKey(fk => fk.ConnectionID)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Connection>()
                .HasOptional(o => o.Viewer)
                .WithMany(m => m.ConnectionsAsViewer)
                .HasForeignKey(fk => fk.ViewerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Connection>()
               .HasOptional(o => o.Sharer)
               .WithMany(m => m.ConnectionsAsSharer)
               .HasForeignKey(fk => fk.SharerID)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Connection>()
                .HasMany(m => m.BaseRequests)
                .WithOptional(m => m.NewConnection)
                .HasForeignKey(fk => fk.NewConnectionID)
                .WillCascadeOnDelete(false);

            #endregion

            #region Screen Share Request Fluent API
            modelBuilder.Entity<ScreenShareRequest>()
                .HasRequired(r => r.Requester)
                .WithMany()
                .HasForeignKey(fk => fk.RequesterID)
                .WillCascadeOnDelete(false);
            #endregion
        }
    }
}
