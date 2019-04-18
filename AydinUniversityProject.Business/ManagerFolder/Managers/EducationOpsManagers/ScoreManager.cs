using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers
{
    public class ScoreManager : BaseManager
    {
        IRepository<Score> scoreRepository;

        public ScoreManager()
        {
            scoreRepository = base.GetRepository<Score>();
        }

        public void DeleteScore(Score score)
        {
            scoreRepository.Delete(score);
        }

        public void AddScore(Score score)
        {
            scoreRepository.Add(score);
        }

        public void EditScore(Score score)
        {
            scoreRepository.Update(score);
        }

        public Score GetScore(int ID)
        {
            return scoreRepository.GetByID(ID);
        }
    }
}
