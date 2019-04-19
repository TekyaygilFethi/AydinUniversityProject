using AydinUniversityProject.Data.POCOs;
using AydinUniversityProject.Database.Context;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AydinUniversityProject.Admin.AydinUniversityProjectContextDataModel {

    /// <summary>
    /// A AydinUniversityProjectContextUnitOfWork instance that represents the run-time implementation of the IAydinUniversityProjectContextUnitOfWork interface.
    /// </summary>
    public class AydinUniversityProjectContextUnitOfWork : DbUnitOfWork<AydinUniversityProjectContext>, IAydinUniversityProjectContextUnitOfWork {

        public AydinUniversityProjectContextUnitOfWork(Func<AydinUniversityProjectContext> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Connection, int> IAydinUniversityProjectContextUnitOfWork.Connections {
            get { return GetRepository(x => x.Set<Connection>(), (Connection x) => x.ID); }
        }

        IRepository<ScreenShareRequest, int> IAydinUniversityProjectContextUnitOfWork.ScreenShareRequests {
            get { return GetRepository(x => x.Set<ScreenShareRequest>(), (ScreenShareRequest x) => x.ID); }
        }

        IRepository<User, int> IAydinUniversityProjectContextUnitOfWork.Users {
            get { return GetRepository(x => x.Set<User>(), (User x) => x.ID); }
        }

        IRepository<FavouriteFeeds, int> IAydinUniversityProjectContextUnitOfWork.FavouriteFeeds {
            get { return GetRepository(x => x.Set<FavouriteFeeds>(), (FavouriteFeeds x) => x.ID); }
        }

        IRepository<Post, int> IAydinUniversityProjectContextUnitOfWork.Posts {
            get { return GetRepository(x => x.Set<Post>(), (Post x) => x.ID); }
        }

        IRepository<SentFeeds, int> IAydinUniversityProjectContextUnitOfWork.SentFeeds {
            get { return GetRepository(x => x.Set<SentFeeds>(), (SentFeeds x) => x.ID); }
        }

        IRepository<Topic, int> IAydinUniversityProjectContextUnitOfWork.Topics {
            get { return GetRepository(x => x.Set<Topic>(), (Topic x) => x.ID); }
        }

        IRepository<Lesson, int> IAydinUniversityProjectContextUnitOfWork.Lessons {
            get { return GetRepository(x => x.Set<Lesson>(), (Lesson x) => x.ID); }
        }

        IRepository<Education, int> IAydinUniversityProjectContextUnitOfWork.Educations {
            get { return GetRepository(x => x.Set<Education>(), (Education x) => x.ID); }
        }

        IRepository<Note, int> IAydinUniversityProjectContextUnitOfWork.Notes {
            get { return GetRepository(x => x.Set<Note>(), (Note x) => x.ID); }
        }

        IRepository<Student, int> IAydinUniversityProjectContextUnitOfWork.Students {
            get { return GetRepository(x => x.Set<Student>(), (Student x) => x.ID); }
        }

        IRepository<Period, int> IAydinUniversityProjectContextUnitOfWork.Periods {
            get { return GetRepository(x => x.Set<Period>(), (Period x) => x.ID); }
        }

        IRepository<FriendRelationship, int> IAydinUniversityProjectContextUnitOfWork.FriendRelationships {
            get { return GetRepository(x => x.Set<FriendRelationship>(), (FriendRelationship x) => x.ID); }
        }

        IRepository<FriendRequest, int> IAydinUniversityProjectContextUnitOfWork.FriendRequests {
            get { return GetRepository(x => x.Set<FriendRequest>(), (FriendRequest x) => x.ID); }
        }

        IRepository<Message, int> IAydinUniversityProjectContextUnitOfWork.Messages {
            get { return GetRepository(x => x.Set<Message>(), (Message x) => x.ID); }
        }

        IRepository<Review, int> IAydinUniversityProjectContextUnitOfWork.Reviews {
            get { return GetRepository(x => x.Set<Review>(), (Review x) => x.ID); }
        }

        IRepository<Contact, int> IAydinUniversityProjectContextUnitOfWork.Contacts {
            get { return GetRepository(x => x.Set<Contact>(), (Contact x) => x.ID); }
        }
    }
}
