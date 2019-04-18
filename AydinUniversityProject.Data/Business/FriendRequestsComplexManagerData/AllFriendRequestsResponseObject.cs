using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.FriendRequestsComplexManagerData
{
    public class AllFriendRequestsResponseObject
    {
        public List<FriendRequest> SentFriendRequests { get; set; }

        public List<FriendRequest> ReceivedFriendRequests { get; set; }
    }
}
