using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.FriendRequestsComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Linq;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.FriendOpsManagers
{
    public class FriendRequestManager
    {
        readonly IRepository<FriendRequest> friendRequestRepository;

        public FriendRequestManager(IRepository<FriendRequest> repo)
        {
            friendRequestRepository = repo;
        }

        public FriendRequest GetFriendRequest(int ID)
        {
            return friendRequestRepository.GetByID(ID);
        }

        public void AddRequest(FriendRequest fr)
        {
            friendRequestRepository.Add(fr);
        }

        public void DeleteRequest(FriendRequest fr)
        {
            friendRequestRepository.Delete(fr);
        }

        public void UpdateRequest(FriendRequest fr)
        {
            friendRequestRepository.Update(fr);
        }

        public bool CheckExistence(int senderID, int receiverID)
        {
            return friendRequestRepository.GetBy(w => w.RequesterID == senderID && w.RequestToID == receiverID && w.IsAccepted == true).Any();
        }

        public FriendRequest GetFriendRequestByUsernames(int senderID, int receiverID)
        {
            return friendRequestRepository.SingleGetBy(w => w.RequesterID == senderID && w.RequestToID == receiverID && w.IsAccepted == false);
        }

        public AllFriendRequestsResponseObject GetAllFriendRequestsOfUser(int userID)
        {
            AllFriendRequestsResponseObject allFr = new AllFriendRequestsResponseObject();

            allFr.SentFriendRequests = friendRequestRepository.GetBy(w => w.RequesterID == userID);
            allFr.ReceivedFriendRequests = friendRequestRepository.GetBy(w => w.RequestToID == userID);

            return allFr;
        }

    }
}
