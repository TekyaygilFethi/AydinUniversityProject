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
    /// Represents the single Student object view model.
    /// </summary>
    public partial class StudentViewModel : SingleObjectViewModel<Student, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of StudentViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static StudentViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new StudentViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the StudentViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the StudentViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected StudentViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Students, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Educations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Education> LookUpEducations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StudentViewModel x) => x.LookUpEducations,
                    getRepositoryFunc: x => x.Educations);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Periods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Period> LookUpPeriods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StudentViewModel x) => x.LookUpPeriods,
                    getRepositoryFunc: x => x.Periods);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Users for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<User> LookUpUsers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (StudentViewModel x) => x.LookUpUsers,
                    getRepositoryFunc: x => x.Users);
            }
        }


        /// <summary>
        /// The view model for the StudentEducations detail collection.
        /// </summary>
        public CollectionViewModelBase<Education, Education, int, IAydinUniversityProjectContextUnitOfWork> StudentEducationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (StudentViewModel x) => x.StudentEducationsDetails,
                    getRepositoryFunc: x => x.Educations,
                    foreignKeyExpression: x => x.StudentID,
                    navigationExpression: x => x.Student);
            }
        }
    }
}
