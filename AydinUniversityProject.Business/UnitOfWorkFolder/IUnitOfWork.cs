using AydinUniversityProject.Data.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.UnitOfWorkFolder
{
    public interface IUnitOfWork
    {
        //T GetManager<T>() where T : class;
        TransactionObject Save();
    }
}
