using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ForumOpsManagers
{
    public class SentFeedManager
    {
        IRepository<SentFeeds> sentFeedRepository;

        public SentFeedManager(IRepository<SentFeeds> repo)
        {
            sentFeedRepository = repo;
        }

        public void AddSentFeed(SentFeeds sentFeed)
        {
            sentFeedRepository.Add(sentFeed);
        }

        public void EditFavouriteFeed(SentFeeds favFeed)
        {
            //favFeedRepository.Update(favFeed);
        }

        public SentFeeds GetFavouriteFeed(int ID)
        {
            return sentFeedRepository.GetByID(ID);
        }

        public void DeleteFavouriteFeed(SentFeeds sentFeed)
        {
            sentFeedRepository.Delete(sentFeed);
        }
    }
}
