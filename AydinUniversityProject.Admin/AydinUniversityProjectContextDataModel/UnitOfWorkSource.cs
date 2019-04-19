using AydinUniversityProject.Database.Context;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using System;
using System.Collections;
using System.Linq;

namespace AydinUniversityProject.Admin.AydinUniversityProjectContextDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IAydinUniversityProjectContextUnitOfWork>(() => new AydinUniversityProjectContextUnitOfWork(() => new AydinUniversityProjectContext()));
        }
    }
}