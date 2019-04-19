using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using AydinUniversityProject.Admin.AydinUniversityProjectContextDataModel;
using AydinUniversityProject.Admin.Common;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Admin.ViewModels {

    /// <summary>
    /// Represents the Notes collection view model.
    /// </summary>
    public partial class NoteCollectionViewModel : CollectionViewModel<Note, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of NoteCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static NoteCollectionViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new NoteCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the NoteCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the NoteCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected NoteCollectionViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Notes) {
        }
    }
}