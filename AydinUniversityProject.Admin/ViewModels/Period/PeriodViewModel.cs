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
    /// Represents the single Period object view model.
    /// </summary>
    public partial class PeriodViewModel : SingleObjectViewModel<Period, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of PeriodViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PeriodViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new PeriodViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PeriodViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PeriodViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PeriodViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Periods, x => x.ID) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Lessons for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Lesson> LookUpLessons {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PeriodViewModel x) => x.LookUpLessons,
                    getRepositoryFunc: x => x.Lessons);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Students for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Student> LookUpStudents {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (PeriodViewModel x) => x.LookUpStudents,
                    getRepositoryFunc: x => x.Students);
            }
        }


        /// <summary>
        /// The view model for the PeriodLessons detail collection.
        /// </summary>
        public CollectionViewModelBase<Lesson, Lesson, int, IAydinUniversityProjectContextUnitOfWork> PeriodLessonsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PeriodViewModel x) => x.PeriodLessonsDetails,
                    getRepositoryFunc: x => x.Lessons,
                    foreignKeyExpression: x => x.PeriodID,
                    navigationExpression: x => x.Period);
            }
        }

        /// <summary>
        /// The view model for the PeriodStudents detail collection.
        /// </summary>
        public CollectionViewModelBase<Student, Student, int, IAydinUniversityProjectContextUnitOfWork> PeriodStudentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (PeriodViewModel x) => x.PeriodStudentsDetails,
                    getRepositoryFunc: x => x.Students,
                    foreignKeyExpression: x => x.PeriodID,
                    navigationExpression: x => x.Period);
            }
        }
    }
}
