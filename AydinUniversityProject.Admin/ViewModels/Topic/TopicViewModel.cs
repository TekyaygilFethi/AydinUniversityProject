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
    /// Represents the single Topic object view model.
    /// </summary>
    public partial class TopicViewModel : SingleObjectViewModel<Topic, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of TopicViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static TopicViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new TopicViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the TopicViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the TopicViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected TopicViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Topics, x => x.Name) {
                }


        protected override void RefreshLookUpCollections(bool raisePropertyChanged) {
            base.RefreshLookUpCollections(raisePropertyChanged);
                FavouriteFeedsDetailEntities = CreateAddRemoveDetailEntitiesViewModel(x => x.FavouriteFeeds, x => x.FavouriteFeeds);
        }
        /// <summary>
        /// The view model that contains a look-up collection of Posts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Post> LookUpPosts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TopicViewModel x) => x.LookUpPosts,
                    getRepositoryFunc: x => x.Posts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Lessons for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Lesson> LookUpLessons {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TopicViewModel x) => x.LookUpLessons,
                    getRepositoryFunc: x => x.Lessons);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of SentFeeds for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SentFeeds> LookUpSentFeeds {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (TopicViewModel x) => x.LookUpSentFeeds,
                    getRepositoryFunc: x => x.SentFeeds);
            }
        }

    public virtual AddRemoveDetailEntitiesViewModel<Topic, Int32, FavouriteFeeds, Int32, IAydinUniversityProjectContextUnitOfWork> FavouriteFeedsDetailEntities { get; protected set; }

        /// <summary>
        /// The view model for the TopicPosts detail collection.
        /// </summary>
        public CollectionViewModelBase<Post, Post, int, IAydinUniversityProjectContextUnitOfWork> TopicPostsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (TopicViewModel x) => x.TopicPostsDetails,
                    getRepositoryFunc: x => x.Posts,
                    foreignKeyExpression: x => x.TopicID,
                    navigationExpression: x => x.Topic);
            }
        }
    }
}
