using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers
{
    public class StudentManager
    {
        IRepository<Student> studentRepository;

        public StudentManager(IRepository<Student> repo)
        {
            studentRepository = repo;
        }

        public void AddStudent(Student student)
        {
            studentRepository.Add(student);
        }

        public Student GetStudent(int studentID)
        {
            return studentRepository.GetByID(studentID);
        }


    }
}
