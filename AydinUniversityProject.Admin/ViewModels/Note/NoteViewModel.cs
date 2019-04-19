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
    /// Represents the single Note object view model.
    /// </summary>
    public partial class NoteViewModel : SingleObjectViewModel<Note, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of NoteViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static NoteViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new NoteViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the NoteViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the NoteViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected NoteViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Notes, x => x.Description) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Educations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Education> LookUpEducations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (NoteViewModel x) => x.LookUpEducations,
                    getRepositoryFunc: x => x.Educations);
            }
        }

    }
}
