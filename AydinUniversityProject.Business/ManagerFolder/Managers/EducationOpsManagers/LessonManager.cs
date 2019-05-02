using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System.Collections.Generic;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers
{
    public class LessonManager
    {
        IRepository<Lesson> lessonRepository;

        public LessonManager(IRepository<Lesson> repo)
        {
            lessonRepository = repo;
        }

        public void AddLesson(Lesson lesson)
        {
            lessonRepository.Add(lesson);
        }

        public void EditLesson(Lesson lesson)
        {
            //lessonRepository.Update(lesson);
        }

        public Lesson GetLesson(int ID)
        {
            return lessonRepository.GetByID(ID);
        }

        public List<Lesson> GetLessonsOfPeriod(int year, int term)
        {
            return lessonRepository.GetBy(w => w.Period.Semester == term && w.Period.Year == year);
        }

        public List<Lesson> GetAllLessons()
        {
            return lessonRepository.GetAll();
        }

        public void DeleteLesson(Lesson lesson)
        {
            lessonRepository.Delete(lesson);
        }

    }
}
