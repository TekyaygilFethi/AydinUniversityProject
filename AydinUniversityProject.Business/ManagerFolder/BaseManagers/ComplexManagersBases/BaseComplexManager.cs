using AydinUniversityProject.Business.ExceptionFolder;
using AydinUniversityProject.Business.UnitOfWorkFolder;
using AydinUniversityProject.Data.Business;
using System;

namespace AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases
{
    public class BaseComplexManager : IBaseComplexManager
    {

        //public T GetManager<T>(UnitOfWork uow) where T : class where TType : class
        //{
        //    return uow.GetManager<T>(uow.GetRepository<TType>());
        //}

        //public TransactionObject Save()
        //{
        //    return base.Context.Save();
        //}

        public string GetExceptionMessage(Exception ex)
        {
            return ExceptionOps.GetExceptionMessage(ex);
        }
    }
}
