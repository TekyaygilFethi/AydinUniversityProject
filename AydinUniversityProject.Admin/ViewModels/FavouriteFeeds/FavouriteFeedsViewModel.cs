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
    /// Represents the single FavouriteFeeds object view model.
    /// </summary>
    public partial class FavouriteFeedsViewModel : SingleObjectViewModel<FavouriteFeeds, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FavouriteFeedsViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FavouriteFeedsViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FavouriteFeedsViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FavouriteFeedsViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FavouriteFeedsViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FavouriteFeedsViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.FavouriteFeeds, x => x.ID) {
                }


        protected override void RefreshLookUpCollections(bool raisePropertyChanged) {
            base.RefreshLookUpCollections(raisePropertyChanged);
                FavouriteTopicsDetailEntities = CreateAddRemoveDetailEntitiesViewModel(x => x.Topics, x => x.FavouriteTopics);
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FavouriteFeedsViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Posts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Post> LookUpPosts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FavouriteFeedsViewModel x) => x.LookUpPosts,
                    getRepositoryFunc: x => x.Posts);
            }
        }

    public virtual AddRemoveDetailEntitiesViewModel<FavouriteFeeds, Int32, Topic, Int32, IAydinUniversityProjectContextUnitOfWork> FavouriteTopicsDetailEntities { get; protected set; }

        /// <summary>
        /// The view model for the FavouriteFeedsFavouritePosts detail collection.
        /// </summary>
        public CollectionViewModelBase<Post, Post, int, IAydinUniversityProjectContextUnitOfWork> FavouriteFeedsFavouritePostsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (FavouriteFeedsViewModel x) => x.FavouriteFeedsFavouritePostsDetails,
                    getRepositoryFunc: x => x.Posts,
                    foreignKeyExpression: x => x.FavouriteFeedID,
                    navigationExpression: x => x.FavouriteFeed);
            }
        }
    }
}
