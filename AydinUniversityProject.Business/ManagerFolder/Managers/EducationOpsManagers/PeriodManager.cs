using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers
{
    public class PeriodManager
    {
        IRepository<Period> periodRepository;

        public PeriodManager(IRepository<Period> repo)
        {
            periodRepository = repo;
        }

        public void Deleteperiod(Period period)
        {
            periodRepository.Delete(period);
        }

        public void AddPeriod(Period period)
        {
            periodRepository.Add(period);
        }

        public void Editperiod(Period period)
        {
            periodRepository.Update(period);
        }

        public Period GetPeriod(int ID)
        {
            return periodRepository.GetByID(ID);
        }

        public Period GetPeriod(int year,int semester)
        {
            return periodRepository.SingleGetBy(w => w.Year == year && w.Semester == semester);
        }

        public List<Period> GetAllPeriods()
        {
            return periodRepository.GetAll();
        }

    }
}
