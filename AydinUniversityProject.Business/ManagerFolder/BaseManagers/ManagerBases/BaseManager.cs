using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinUniversityProject.Business.ManagerFolder.BaseManagers.MotherBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Business.UnitOfWorkFolder;
using AydinUniversityProject.Data.Business;

namespace AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases
{
    public class BaseManager : IBaseManager
    {
        public IUnitOfWork uow;

        public BaseManager(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return uow.GetRepository<T>();
        } 
    }
}
