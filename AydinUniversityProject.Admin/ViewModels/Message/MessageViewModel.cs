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
    /// Represents the single Message object view model.
    /// </summary>
    public partial class MessageViewModel : SingleObjectViewModel<Message, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of MessageViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static MessageViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new MessageViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the MessageViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the MessageViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected MessageViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Messages, x => x.MessageContent) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (MessageViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }

    }
}
