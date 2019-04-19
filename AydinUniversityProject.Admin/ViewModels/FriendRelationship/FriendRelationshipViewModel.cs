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
    /// Represents the single FriendRelationship object view model.
    /// </summary>
    public partial class FriendRelationshipViewModel : SingleObjectViewModel<FriendRelationship, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of FriendRelationshipViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static FriendRelationshipViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new FriendRelationshipViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the FriendRelationshipViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the FriendRelationshipViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected FriendRelationshipViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.FriendRelationships, x => x.ID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (FriendRelationshipViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the FriendRelationshipFriends detail collection.
        /// </summary>
        public CollectionViewModelBase<User, User, int, IAydinUniversityProjectContextUnitOfWork> FriendRelationshipFriendsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (FriendRelationshipViewModel x) => x.FriendRelationshipFriendsDetails,
                    getRepositoryFunc: x => x.Users,
                    foreignKeyExpression: x => x.FriendRelationshipID,
                    navigationExpression: x => x.FriendRelationship);
            }
        }
    }
}
