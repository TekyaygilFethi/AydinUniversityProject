using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System.Collections.Generic;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ForumOpsManagers
{
    public class TopicManager
    {
        readonly IRepository<Topic> topicRepository;

        public TopicManager(IRepository<Topic> repo)
        {
            topicRepository = repo;
        }

        public Topic GetTopic(int ID)
        {
            return topicRepository.GetByID(ID);
        }

        public List<Topic> GetAllTopics()
        {
            return topicRepository.GetAll();
        }

        public List<Topic> GetAllTopicsOfStudent(int ID)
        {
            return topicRepository.GetBy(w => w.SentFeed.User.ID == ID);
        }

        public void AddTopic(Topic topic)
        {
            topicRepository.Add(topic);
        }

        public void DeleteTopic(int ID)
        {
            topicRepository.Delete(GetTopic(ID));
        }

        public void UpdateTopic(Topic topic)
        {
            //topicRepository.Update(topic);
        }
    }
}
