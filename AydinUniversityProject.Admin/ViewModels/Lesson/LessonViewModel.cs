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
    /// Represents the single Lesson object view model.
    /// </summary>
    public partial class LessonViewModel : SingleObjectViewModel<Lesson, int, IAydinUniversityProjectContextUnitOfWork> {

        /// <summary>
        /// Creates a new instance of LessonViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static LessonViewModel Create(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new LessonViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the LessonViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the LessonViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected LessonViewModel(IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Lessons, x => x.Name) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Connections for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Connection> LookUpConnections {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (LessonViewModel x) => x.LookUpConnections,
                    getRepositoryFunc: x => x.Connections);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Topics for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Topic> LookUpTopics {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (LessonViewModel x) => x.LookUpTopics,
                    getRepositoryFunc: x => x.Topics);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Periods for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Period> LookUpPeriods {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (LessonViewModel x) => x.LookUpPeriods,
                    getRepositoryFunc: x => x.Periods);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Educations for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Education> LookUpEducations {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (LessonViewModel x) => x.LookUpEducations,
                    getRepositoryFunc: x => x.Educations);
            }
        }


        /// <summary>
        /// The view model for the LessonConnections detail collection.
        /// </summary>
        public CollectionViewModelBase<Connection, Connection, int, IAydinUniversityProjectContextUnitOfWork> LessonConnectionsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (LessonViewModel x) => x.LessonConnectionsDetails,
                    getRepositoryFunc: x => x.Connections,
                    foreignKeyExpression: x => x.LessonID,
                    navigationExpression: x => x.Lesson);
            }
        }

        /// <summary>
        /// The view model for the LessonTopics detail collection.
        /// </summary>
        public CollectionViewModelBase<Topic, Topic, int, IAydinUniversityProjectContextUnitOfWork> LessonTopicsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (LessonViewModel x) => x.LessonTopicsDetails,
                    getRepositoryFunc: x => x.Topics,
                    foreignKeyExpression: x => x.LessonID,
                    navigationExpression: x => x.Lesson);
            }
        }

        /// <summary>
        /// The view model for the LessonEducations detail collection.
        /// </summary>
        public CollectionViewModelBase<Education, Education, int, IAydinUniversityProjectContextUnitOfWork> LessonEducationsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (LessonViewModel x) => x.LessonEducationsDetails,
                    getRepositoryFunc: x => x.Educations,
                    foreignKeyExpression: x => x.LessonID,
                    navigationExpression: x => x.Lesson);
            }
        }
    }
}
