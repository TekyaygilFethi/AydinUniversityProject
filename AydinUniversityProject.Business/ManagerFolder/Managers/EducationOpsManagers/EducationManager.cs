using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System.Linq;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers
{
    public class EducationManager : BaseManager
    {
        IRepository<Education> educationRepository;

        public EducationManager()
        {
            educationRepository = base.GetRepository<Education>();
        }

        public void AddEducation(Education edu)
        {
            educationRepository.Add(edu);
        }

        public void EditEducation(Education edu)
        {
            educationRepository.Update(edu);
        }

        public Education GetEducation(int ID)
        {
            return educationRepository.GetByID(ID);
        }

        public void DeleteEducation(Education edu)
        {
            educationRepository.Delete(edu);
        }

        public bool IsEducationExists(int periodID,string lessonName)
        {
            return educationRepository.GetBy(w => w.PeriodID == periodID && w.Lesson.Name == lessonName).Any();
        }
    }
}
