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
    /// Represents the single ScreenShareRequest object view model.
    /// </summary>
    public partial class ScreenShareRequestViewModel : SingleObjectViewModel<ScreenShareRequest, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ScreenShareRequestViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ScreenShareRequestViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ScreenShareRequestViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ScreenShareRequestViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ScreenShareRequestViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ScreenShareRequestViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ScreenShareRequests, x => x.ID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Connections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Connection> LookUpConnections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ScreenShareRequestViewModel x) => x.LookUpConnections,
                    getRepositoryFunc: x => x.Connections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ScreenShareRequestViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }

    }
}
