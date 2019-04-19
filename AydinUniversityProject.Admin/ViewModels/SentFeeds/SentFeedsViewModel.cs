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
    /// Represents the single SentFeeds object view model.
    /// </summary>
    public partial class SentFeedsViewModel : SingleObjectViewModel<SentFeeds, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SentFeedsViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SentFeedsViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SentFeedsViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SentFeedsViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SentFeedsViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SentFeedsViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SentFeeds, x => x.ID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Posts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Post> LookUpPosts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SentFeedsViewModel x) => x.LookUpPosts,
                    getRepositoryFunc: x => x.Posts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SentFeedsViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Topics for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Topic> LookUpTopics {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SentFeedsViewModel x) => x.LookUpTopics,
                    getRepositoryFunc: x => x.Topics);
            }
        }


        /// <summary>
        /// The view model for the SentFeedsSentPosts detail collection.
        /// </summary>
        public CollectionViewModelBase<Post, Post, int, IAydinUniversityProjectContextUnitOfWork> SentFeedsSentPostsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SentFeedsViewModel x) => x.SentFeedsSentPostsDetails,
                    getRepositoryFunc: x => x.Posts,
                    foreignKeyExpression: x => x.SentFeedID,
                    navigationExpression: x => x.SentFeed);
            }
        }

        /// <summary>
        /// The view model for the SentFeedsSentTopics detail collection.
        /// </summary>
        public CollectionViewModelBase<Topic, Topic, int, IAydinUniversityProjectContextUnitOfWork> SentFeedsSentTopicsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (SentFeedsViewModel x) => x.SentFeedsSentTopicsDetails,
                    getRepositoryFunc: x => x.Topics,
                    foreignKeyExpression: x => x.SentFeedID,
                    navigationExpression: x => x.SentFeed);
            }
        }
    }
}
