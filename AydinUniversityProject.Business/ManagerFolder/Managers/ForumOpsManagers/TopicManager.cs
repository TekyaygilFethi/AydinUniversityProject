using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
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

        public void AddTopic(Topic topic)
        {
            topicRepository.Add(topic);
        }

        public void DeleteTopic(Topic topic)
        {
            topicRepository.Delete(topic);
        }

        public void UpdateTopic(Topic topic)
        {
            topicRepository.Update(topic);
        }
    }
}
