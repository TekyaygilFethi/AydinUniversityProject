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
    /// Represents the single Connection object view model.
    /// </summary>
    public partial class ConnectionViewModel : SingleObjectViewModel<Connection, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ConnectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ConnectionViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ConnectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ConnectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ConnectionViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Connections, x => x.ConnectionName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Lessons for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Lesson> LookUpLessons {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ConnectionViewModel x) => x.LookUpLessons,
                    getRepositoryFunc: x => x.Lessons);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ConnectionViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ScreenShareRequests for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ScreenShareRequest> LookUpScreenShareRequests {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ConnectionViewModel x) => x.LookUpScreenShareRequests,
                    getRepositoryFunc: x => x.ScreenShareRequests);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Reviews for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Review> LookUpReviews {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ConnectionViewModel x) => x.LookUpReviews,
                    getRepositoryFunc: x => x.Reviews);
            }
        }


        /// <summary>
        /// The view model for the ConnectionBaseRequests detail collection.
        /// </summary>
        public CollectionViewModelBase<ScreenShareRequest, ScreenShareRequest, int, IAydinUniversityProjectContextUnitOfWork> ConnectionBaseRequestsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ConnectionViewModel x) => x.ConnectionBaseRequestsDetails,
                    getRepositoryFunc: x => x.ScreenShareRequests,
                    foreignKeyExpression: x => x.NewConnectionID,
                    navigationExpression: x => x.NewConnection);
            }
        }

        /// <summary>
        /// The view model for the ConnectionReviews detail collection.
        /// </summary>
        public CollectionViewModelBase<Review, Review, int, IAydinUniversityProjectContextUnitOfWork> ConnectionReviewsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ConnectionViewModel x) => x.ConnectionReviewsDetails,
                    getRepositoryFunc: x => x.Reviews,
                    foreignKeyExpression: x => x.ConnectionID,
                    navigationExpression: x => x.Connection);
            }
        }
    }
}
