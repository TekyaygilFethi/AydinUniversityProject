using AydinUniversityProject.Business.ManagerFolder.BaseManagers.MotherBases;
using AydinUniversityProject.Business.RepositoryFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases
{
    public interface IBaseManager
    {
        IRepository<T> GetRepository<T>() where T : class;
    }
}
