using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinUniversityProject.Business.ExceptionFolder;
using AydinUniversityProject.Data.Business;

namespace AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases
{
    public class BaseComplexManager :MotherBases.MotherBaseManager,IBaseComplexManager
    {
        public T GetManager<T>() where T : class
        {
            return base.Context.GetManager<T>();
        }

        public TransactionObject Save()
        {
            return base.Context.Save();
        }

        public string GetExceptionMessage(Exception ex)
        {
            return ExceptionOps.GetExceptionMessage(ex);
        }
    }
}
