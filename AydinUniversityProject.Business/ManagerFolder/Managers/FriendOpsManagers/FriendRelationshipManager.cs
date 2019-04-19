using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.FriendOpsManagers
{
    public class FriendRelationshipManager
    {
        readonly IRepository<FriendRelationship> friendRequestRepository;

        public FriendRelationshipManager(IRepository<FriendRelationship> repo)
        {
            friendRequestRepository = repo;
        }
        

        public void AddFriendRelationship(FriendRelationship fr)
        {
            friendRequestRepository.Add(fr);
        }

    }
}
