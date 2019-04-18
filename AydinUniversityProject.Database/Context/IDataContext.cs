using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Database.Context
{
    public interface IDataContext:IDisposable
    {        
            DbChangeTracker ChangeTracker { get; }
            int SaveChanges();
            DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
            DbSet<TEntity> Set<TEntity>() where TEntity : class;
            DbSet Set(Type entityType);
            int>SaveChanges();
            public IDbSet<User> Users { get; set; }
            public IDbSet<Student> Students { get; set; }
            public IDbSet<Education> Educations { get; set; }
            public IDbSet<Score> Scores { get; set; }
            public IDbSet<Note> Notes { get; set; }
            public IDbSet<Lesson> Lessons { get; set; }
            public IDbSet<Period> Periods { get; set; }
            public IDbSet<Review> Reviews { get; set; }
            public IDbSet<Topic> Topics { get; set; }
            public IDbSet<Post> Posts { get; set; }
            public IDbSet<Conversation> Conversations { get; set; }
            public IDbSet<Message> Messages { get; set; }
            public IDbSet<Connection> Connections { get; set; }
            public IDbSet<SentFeeds> SentFeeds { get; set; }
            public IDbSet<FavouriteFeeds> FavouriteFeeds { get; set; }
            public IDbSet<ScreenShareRequest> ScreenShareRequests { get; set; }
            public IDbSet<Contact> Contacts { get; set; }
            public IDbSet<FriendRequest> FriendRequests { get; set; }
        
    }
}
