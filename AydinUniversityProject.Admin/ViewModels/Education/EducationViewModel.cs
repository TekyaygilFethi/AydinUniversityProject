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
    /// Represents the single Education object view model.
    /// </summary>
    public partial class EducationViewModel : SingleObjectViewModel<Education, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of EducationViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static EducationViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new EducationViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the EducationViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the EducationViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected EducationViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Educations, x => x.ID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Lessons for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Lesson> LookUpLessons {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EducationViewModel x) => x.LookUpLessons,
                    getRepositoryFunc: x => x.Lessons);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Students for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Student> LookUpStudents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EducationViewModel x) => x.LookUpStudents,
                    getRepositoryFunc: x => x.Students);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Notes for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Note> LookUpNotes {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (EducationViewModel x) => x.LookUpNotes,
                    getRepositoryFunc: x => x.Notes);
            }
        }


        /// <summary>
        /// The view model for the EducationNotes detail collection.
        /// </summary>
        public CollectionViewModelBase<Note, Note, int, IAydinUniversityProjectContextUnitOfWork> EducationNotesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (EducationViewModel x) => x.EducationNotesDetails,
                    getRepositoryFunc: x => x.Notes,
                    foreignKeyExpression: x => x.EducationID,
                    navigationExpression: x => x.Education);
            }
        }
    }
}
