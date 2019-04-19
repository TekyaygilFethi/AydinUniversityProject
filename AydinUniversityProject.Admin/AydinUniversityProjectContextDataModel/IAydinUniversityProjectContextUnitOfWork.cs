using AydinUniversityProject.Data.POCOs;
using AydinUniversityProject.Database.Context;
using DevExpress.Mvvm.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AydinUniversityProject.Admin.AydinUniversityProjectContextDataModel {

    /// <summary>
    /// IAydinUniversityProjectContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IAydinUniversityProjectContextUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Connection entities repository.
        /// </summary>
		IRepository<Connection, int> Connections { get; }
        
        /// <summary>
        /// The ScreenShareRequest entities repository.
        /// </summary>
		IRepository<ScreenShareRequest, int> ScreenShareRequests { get; }
        
        /// <summary>
        /// The User entities repository.
        /// </summary>
		IRepository<User, int> Users { get; }
        
        /// <summary>
        /// The FavouriteFeeds entities repository.
        /// </summary>
		IRepository<FavouriteFeeds, int> FavouriteFeeds { get; }
        
        /// <summary>
        /// The Post entities repository.
        /// </summary>
		IRepository<Post, int> Posts { get; }
        
        /// <summary>
        /// The SentFeeds entities repository.
        /// </summary>
		IRepository<SentFeeds, int> SentFeeds { get; }
        
        /// <summary>
        /// The Topic entities repository.
        /// </summary>
		IRepository<Topic, int> Topics { get; }
        
        /// <summary>
        /// The Lesson entities repository.
        /// </summary>
		IRepository<Lesson, int> Lessons { get; }
        
        /// <summary>
        /// The Education entities repository.
        /// </summary>
		IRepository<Education, int> Educations { get; }
        
        /// <summary>
        /// The Note entities repository.
        /// </summary>
		IRepository<Note, int> Notes { get; }
        
        /// <summary>
        /// The Student entities repository.
        /// </summary>
		IRepository<Student, int> Students { get; }
        
        /// <summary>
        /// The Period entities repository.
        /// </summary>
		IRepository<Period, int> Periods { get; }
        
        /// <summary>
        /// The FriendRelationship entities repository.
        /// </summary>
		IRepository<FriendRelationship, int> FriendRelationships { get; }
        
        /// <summary>
        /// The FriendRequest entities repository.
        /// </summary>
		IRepository<FriendRequest, int> FriendRequests { get; }
        
        /// <summary>
        /// The Message entities repository.
        /// </summary>
		IRepository<Message, int> Messages { get; }
        
        /// <summary>
        /// The Review entities repository.
        /// </summary>
		IRepository<Review, int> Reviews { get; }
        
        /// <summary>
        /// The Contact entities repository.
        /// </summary>
		IRepository<Contact, int> Contacts { get; }
    }
}
