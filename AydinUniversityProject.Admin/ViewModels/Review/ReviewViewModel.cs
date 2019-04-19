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
    /// Represents the single Review object view model.
    /// </summary>
    public partial class ReviewViewModel : SingleObjectViewModel<Review, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ReviewViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ReviewViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ReviewViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ReviewViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ReviewViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ReviewViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Reviews, x => x.Message) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Connections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Connection> LookUpConnections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ReviewViewModel x) => x.LookUpConnections,
                    getRepositoryFunc: x => x.Connections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ReviewViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }

    }
}
