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
    /// Represents the single Post object view model.
    /// </summary>
    public partial class PostViewModel : SingleObjectViewModel<Post, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PostViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PostViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PostViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PostViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PostViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PostViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Posts, x => x.Content) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of FavouriteFeeds for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<FavouriteFeeds> LookUpFavouriteFeeds {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PostViewModel x) => x.LookUpFavouriteFeeds,
                    getRepositoryFunc: x => x.FavouriteFeeds);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of SentFeeds for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SentFeeds> LookUpSentFeeds {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PostViewModel x) => x.LookUpSentFeeds,
                    getRepositoryFunc: x => x.SentFeeds);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Topics for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Topic> LookUpTopics {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PostViewModel x) => x.LookUpTopics,
                    getRepositoryFunc: x => x.Topics);
            }
        }

    }
}
