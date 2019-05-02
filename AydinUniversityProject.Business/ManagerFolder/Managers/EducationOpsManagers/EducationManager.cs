using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System.Linq;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers
{
    public class EducationManager
    {
        IRepository<Education> educationRepository;

        public EducationManager(IRepository<Education> repo)
        {
            educationRepository = repo;
        }

        public void AddEducation(Education edu)
        {
            educationRepository.Add(edu);
        }

        public void EditEducation(Education edu)
        {
            //educationRepository.Update(edu);
        }

        public Education GetEducation(int ID)
        {
            return educationRepository.GetByID(ID);
        }

        public Education GetEducation(int StudentID,int LessonID)
        {
            return educationRepository.SingleGetBy(w=>w.StudentID==StudentID && w.LessonID==LessonID);
        }

        public void DeleteEducation(Education edu)
        {
            educationRepository.Delete(edu);
        }


        public void DeleteEducation(int ID)
        {
            educationRepository.Delete(GetEducation(ID));
        }

        public bool IsEducationExists(int studentID, int lessonID)
        {
            return educationRepository.GetBy(w => w.Lesson.ID == lessonID && w.StudentID==studentID).Any();
        }
    }
}
