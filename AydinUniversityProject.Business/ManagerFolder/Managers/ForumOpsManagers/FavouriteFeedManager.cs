﻿using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System.Collections.Generic;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ForumOpsManagers
{
    public class FavouriteFeedManager 
    {
        IRepository<FavouriteFeeds> favFeedRepository;

        public FavouriteFeedManager(IRepository<FavouriteFeeds> repo)
        {
            favFeedRepository = repo;
        }

        public void AddFavouriteFeed(FavouriteFeeds favFeed)
        {
            favFeedRepository.Add(favFeed);
        }

        public void EditFavouriteFeed(FavouriteFeeds favFeed)
        {
            //favFeedRepository.Update(favFeed);
        }

        public FavouriteFeeds GetFavouriteFeed(int ID)
        {
            return favFeedRepository.GetByID(ID);
        }

        public void DeleteFavouriteFeed(FavouriteFeeds favFeed)
        {
            favFeedRepository.Delete(favFeed);
        }

        public List<FavouriteFeeds> GetFavouriteFeedsOfStudent(int studentID)
        {
           return favFeedRepository.GetBy(w => w.ID == studentID);
        }

    }
}
