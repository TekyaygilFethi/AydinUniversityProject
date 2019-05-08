using AydinUniversityProject.Business.ExceptionFolder;
using AydinUniversityProject.Business.UnitOfWorkFolder;
using AydinUniversityProject.Data.Business;
using System;

namespace AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases
{
    public class BaseComplexManager : IBaseComplexManager
    {
        public string GetExceptionMessage(Exception ex)
        {
            return ExceptionOps.GetExceptionMessage(ex);
        }
    }
}
