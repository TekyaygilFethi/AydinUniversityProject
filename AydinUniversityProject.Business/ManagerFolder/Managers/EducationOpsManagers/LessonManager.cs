using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers
{
    public class LessonManager : BaseManager
    {
        IRepository<Lesson> lessonRepository;

        public LessonManager()
        {
            lessonRepository = base.GetRepository<Lesson>();
        }

        public void AddLesson(Lesson lesson)
        {
            lessonRepository.Add(lesson);
        }

        public void EditLesson(Lesson lesson)
        {
            lessonRepository.Update(lesson);
        }

        public Lesson GetLesson(int ID)
        {
            return lessonRepository.GetByID(ID);
        }

        public void DeleteLesson(Lesson lesson)
        {
            lessonRepository.Delete(lesson);
        }

    }
}
