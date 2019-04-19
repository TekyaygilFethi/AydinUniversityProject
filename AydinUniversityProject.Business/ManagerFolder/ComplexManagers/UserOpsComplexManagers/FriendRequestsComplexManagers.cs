using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases;
using AydinUniversityProject.Business.ManagerFolder.Managers.FriendOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers;
using AydinUniversityProject.Business.UnitOfWorkFolder;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.POCOs;
using System;

namespace AydinUniversityProject.Business.ManagerFolder.ComplexManagers.UserOpsComplexManagers
{
    public class FriendRequestsComplexManagers : BaseComplexManager
    {
        UserManager userManager;
        FriendRequestManager frManager;

        IUnitOfWork uow;
        public FriendRequestsComplexManagers()
        {
            uow = new UnitOfWork(new AydinUniversityProject.Database.Context.AydinUniversityProjectContext());
            userManager = uow.GetManager<UserManager,User>();
            frManager = uow.GetManager<FriendRequestManager,FriendRequest>();
        }

        public TransactionObject SendFriendRequest(int senderUserID, int receiverUserID)
        {
            TransactionObject response = new TransactionObject();

            if (!(frManager.CheckExistence(senderUserID, receiverUserID)))
            {
                try
                {
                    User senderUser = userManager.GetUser(senderUserID);
                    User receiverUser = userManager.GetUser(receiverUserID);
                    FriendRequest fr = new FriendRequest();
                    fr.Requester = senderUser;
                    fr.RequestTo = receiverUser;

                    senderUser.SentFriendRequests.Add(fr);
                    receiverUser.ReceivedFriendRequests.Add(fr);

                    uow.Save();
                }
                catch (Exception ex)
                {
                    response.IsSuccess = false;
                    response.Explanation = base.GetExceptionMessage(ex);
                }
            }
            else
            {
                response.IsSuccess = false;
                response.Explanation = "This friend request has been sent before and waiting to be responsed!";
            }

            return response;
        }
        
        public TransactionObject UnsendFriendRequest(int senderUserID, int receiverUserID)
        {
            TransactionObject response = new TransactionObject();

            if ((frManager.CheckExistence(senderUserID, receiverUserID)))
            {
                try
                {
                    User senderUser = userManager.GetUser(senderUserID);
                    User receiverUser = userManager.GetUser(receiverUserID);
                    FriendRequest fr= frManager.GetFriendRequestByUsernames(senderUserID, receiverUserID); ;

                    senderUser.SentFriendRequests.Remove(fr);
                    receiverUser.ReceivedFriendRequests.Remove(fr);

                    frManager.DeleteRequest(fr);
                    uow.Save();
                }
                catch (Exception ex)
                {
                    response.IsSuccess = false;
                    response.Explanation = base.GetExceptionMessage(ex);
                }
            }
            else
            {
                response.IsSuccess = false;
                response.Explanation = "This friend request has not been sent before!";
            }

            return response;
        }
        
        public TransactionObject AcceptFriendRequest(int senderUserID, int receiverUserID)
        {
            TransactionObject response = new TransactionObject();

            if ((frManager.CheckExistence(senderUserID, receiverUserID)))
            {
                try
                {
                    User senderUser = userManager.GetUser(senderUserID);
                    User receiverUser = userManager.GetUser(receiverUserID);
                    FriendRequest fr = frManager.GetFriendRequestByUsernames(senderUserID,receiverUserID);

                    fr.IsAccepted = true;

                    //senderUser.Friends.Add(receiverUser);
                    //receiverUser.Friends.Add(senderUser);
                    
                    uow.Save();
                }
                catch (Exception ex)
                {
                    response.IsSuccess = false;
                    response.Explanation = base.GetExceptionMessage(ex);
                }
            }
            else
            {
                response.IsSuccess = false;
                response.Explanation = "This friend request has not been sent before!";
            }

            return response;
        }

        public TransactionObject DeleteFriend(int senderUserID,int receiverUserID)
        {
            TransactionObject response = new TransactionObject();

            if ((frManager.CheckExistence(senderUserID, receiverUserID)))
            {
                try
                {
                    User senderUser = userManager.GetUser(senderUserID);
                    User receiverUser = userManager.GetUser(receiverUserID);
                   
                    //senderUser.Friends.Remove(receiverUser);
                    //receiverUser.Friends.Remove(senderUser);

                    uow.Save();
                }
                catch (Exception ex)
                {
                    response.IsSuccess = false;
                    response.Explanation = base.GetExceptionMessage(ex);
                }
            }
            else
            {
                response.IsSuccess = false;
                response.Explanation = "This friend request has not been sent before!";
            }

            return response;
        }
    }
}
