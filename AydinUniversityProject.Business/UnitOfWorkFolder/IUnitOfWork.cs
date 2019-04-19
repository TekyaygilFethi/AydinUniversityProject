using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.UnitOfWorkFolder
{
    public interface IUnitOfWork:IDisposable
    {
        ManagerType GetManager<ManagerType,RepositoryType>() where ManagerType : class where RepositoryType:class;
        TransactionObject Save();
        IRepository<T> GetRepository<T>() where T : class;
    }
}
