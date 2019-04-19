using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using AydinUniversityProject.Admin.AydinUniversityProjectContextDataModel;
using AydinUniversityProject.Admin.Common;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Admin.ViewModels {

    /// <summary>
    /// Represents the single User object view model.
    /// </summary>
    public partial class UserViewModel : SingleObjectViewModel<User, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of UserViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static UserViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new UserViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the UserViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the UserViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected UserViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Users, x => x.Username) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Connections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Connection> LookUpConnections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpConnections,
                    getRepositoryFunc: x => x.Connections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ScreenShareRequests for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ScreenShareRequest> LookUpScreenShareRequests {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpScreenShareRequests,
                    getRepositoryFunc: x => x.ScreenShareRequests);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of FriendRelationships for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<FriendRelationship> LookUpFriendRelationships {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpFriendRelationships,
                    getRepositoryFunc: x => x.FriendRelationships);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of FavouriteFeeds for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<FavouriteFeeds> LookUpFavouriteFeeds {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpFavouriteFeeds,
                    getRepositoryFunc: x => x.FavouriteFeeds);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of SentFeeds for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SentFeeds> LookUpSentFeeds {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpSentFeeds,
                    getRepositoryFunc: x => x.SentFeeds);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Students for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Student> LookUpStudents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpStudents,
                    getRepositoryFunc: x => x.Students);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of FriendRequests for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<FriendRequest> LookUpFriendRequests {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpFriendRequests,
                    getRepositoryFunc: x => x.FriendRequests);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Messages for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Message> LookUpMessages {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpMessages,
                    getRepositoryFunc: x => x.Messages);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Reviews for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Review> LookUpReviews {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (UserViewModel x) => x.LookUpReviews,
                    getRepositoryFunc: x => x.Reviews);
            }
        }


        /// <summary>
        /// The view model for the UserConnectionsAsSharer detail collection.
        /// </summary>
        public CollectionViewModelBase<Connection, Connection, int, IAydinUniversityProjectContextUnitOfWork> UserConnectionsAsSharerDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserConnectionsAsSharerDetails,
                    getRepositoryFunc: x => x.Connections,
                    foreignKeyExpression: x => x.SharerID,
                    navigationExpression: x => x.Sharer);
            }
        }

        /// <summary>
        /// The view model for the UserConnectionsAsViewer detail collection.
        /// </summary>
        public CollectionViewModelBase<Connection, Connection, int, IAydinUniversityProjectContextUnitOfWork> UserConnectionsAsViewerDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserConnectionsAsViewerDetails,
                    getRepositoryFunc: x => x.Connections,
                    foreignKeyExpression: x => x.ViewerID,
                    navigationExpression: x => x.Viewer);
            }
        }

        /// <summary>
        /// The view model for the UserSentScreenShareRequests detail collection.
        /// </summary>
        public CollectionViewModelBase<ScreenShareRequest, ScreenShareRequest, int, IAydinUniversityProjectContextUnitOfWork> UserSentScreenShareRequestsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserSentScreenShareRequestsDetails,
                    getRepositoryFunc: x => x.ScreenShareRequests,
                    foreignKeyExpression: x => x.RequesterID,
                    navigationExpression: x => x.Requester);
            }
        }

        /// <summary>
        /// The view model for the UserReceivedScreenShareRequests detail collection.
        /// </summary>
        public CollectionViewModelBase<ScreenShareRequest, ScreenShareRequest, int, IAydinUniversityProjectContextUnitOfWork> UserReceivedScreenShareRequestsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserReceivedScreenShareRequestsDetails,
                    getRepositoryFunc: x => x.ScreenShareRequests,
                    foreignKeyExpression: x => x.RequestToID,
                    navigationExpression: x => x.RequestTo);
            }
        }

        /// <summary>
        /// The view model for the UserSentFriendRequests detail collection.
        /// </summary>
        public CollectionViewModelBase<FriendRequest, FriendRequest, int, IAydinUniversityProjectContextUnitOfWork> UserSentFriendRequestsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserSentFriendRequestsDetails,
                    getRepositoryFunc: x => x.FriendRequests,
                    foreignKeyExpression: x => x.RequesterID,
                    navigationExpression: x => x.Requester);
            }
        }

        /// <summary>
        /// The view model for the UserReceivedFriendRequests detail collection.
        /// </summary>
        public CollectionViewModelBase<FriendRequest, FriendRequest, int, IAydinUniversityProjectContextUnitOfWork> UserReceivedFriendRequestsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserReceivedFriendRequestsDetails,
                    getRepositoryFunc: x => x.FriendRequests,
                    foreignKeyExpression: x => x.RequestToID,
                    navigationExpression: x => x.RequestTo);
            }
        }

        /// <summary>
        /// The view model for the UserReceivedMessages detail collection.
        /// </summary>
        public CollectionViewModelBase<Message, Message, int, IAydinUniversityProjectContextUnitOfWork> UserReceivedMessagesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserReceivedMessagesDetails,
                    getRepositoryFunc: x => x.Messages,
                    foreignKeyExpression: x => x.ReceiverUserID,
                    navigationExpression: x => x.ReceiverUser);
            }
        }

        /// <summary>
        /// The view model for the UserSentMessages detail collection.
        /// </summary>
        public CollectionViewModelBase<Message, Message, int, IAydinUniversityProjectContextUnitOfWork> UserSentMessagesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserSentMessagesDetails,
                    getRepositoryFunc: x => x.Messages,
                    foreignKeyExpression: x => x.SenderUserID,
                    navigationExpression: x => x.SenderUser);
            }
        }

        /// <summary>
        /// The view model for the UserReviews detail collection.
        /// </summary>
        public CollectionViewModelBase<Review, Review, int, IAydinUniversityProjectContextUnitOfWork> UserReviewsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (UserViewModel x) => x.UserReviewsDetails,
                    getRepositoryFunc: x => x.Reviews,
                    foreignKeyExpression: x => x.SenderID,
                    navigationExpression: x => x.Sender);
            }
        }
    }
}
