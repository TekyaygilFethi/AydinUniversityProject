using AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers;
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using AydinUniversityProject.Data.Business.ScreenShareComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using System.Collections.Generic;

namespace AydinUniversityProject.DesktopWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ScreenConnectionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ScreenConnectionService.svc or ScreenConnectionService.svc.cs at the Solution Explorer and start debugging.
    public class ScreenConnectionService : IScreenConnectionService
    {
        ScreenShareOpsComplexManager screenShareComplexManager;
        AccountComplexManager accountManager;

        public ScreenConnectionService()
        {
            screenShareComplexManager = new ScreenShareOpsComplexManager();
            accountManager = new AccountComplexManager();
        }

        public string ReturnViewerIP(int ID)
        {
            return screenShareComplexManager.GetParticipantIP(ID, Data.POCOs.IPType.Viewer);
        }

        public string ReturnSharerIP(int ID)
        {
            return screenShareComplexManager.GetParticipantIP(ID, Data.POCOs.IPType.Sharer);
        }

        int DesktopToWeb(ConnectionEditFormData conn)
        {
            var response = screenShareComplexManager.TransferConnectionToWeb(conn);

            if (response.IsSuccess)
                return conn.ID;
            else
                return -1;
        }

        int WebToDesktop(int ID)
        {
            return ID;
        }

        public int ControlConnectionForCreation(int userID, int lessonID) //random bir connection bul ve kullanıcıyı ona ekle
        {
            return screenShareComplexManager.ControlConnectionForCreation(userID, lessonID);

        }

        public int CreateConnection(int ID, string connectionName, int lessonID)
        {
            return screenShareComplexManager.CreateConnection(ID, connectionName, lessonID);

        }

        public bool ControlConnectionForJoin(string pendingStatus, int connectionID)
        {
            return screenShareComplexManager.ControlConnectionForJoin(pendingStatus, connectionID);
        }

        public int SaveInvitationString(int connectionID, string InvitationString)
        {
            var response = screenShareComplexManager.SaveInvitationString(connectionID, InvitationString);
            if (response.IsSuccess)
                return connectionID;
            else
                return -1;
        }

        public string GetInvitationString(int connectionID)
        {
            var response = screenShareComplexManager.GetInvitationString(connectionID);
            if (response.IsSuccess)
                return response.Explanation;
            else
                throw new System.Exception(response.Explanation);
        }

        public int CheckLoginCreedientals(string username, string password)
        {
            var response = accountManager.CheckCreedientals(new Data.Business.AccountComplexManagerData.LoginFormData { Username = username, Password = password });

            if (response.IsSuccess)
                return int.Parse(response.Explanation);
            else
                return -1;
        }

        public string GetTag(int currentUserID, int connectionID)
        {
            return screenShareComplexManager.GetTag(currentUserID, connectionID);
        }

        public void Disconnect(int currentUserID, int connectionID)
        {
            screenShareComplexManager.Disconnect(currentUserID, connectionID);
        }

        public bool HasConnection(int currentUserID)
        {
            return screenShareComplexManager.HasConnection(currentUserID);
        }

        public Dictionary<int, string> GetAllLessons()
        {
            return screenShareComplexManager.GetAllLessons();

        }

        public Dictionary<Dictionary<int, string>, Dictionary<string, string>> GetRequestedConnections(int userID)
        {
            return screenShareComplexManager.GetRequestedConnections(userID);
        }

        public bool IsRequestExists(int userID)
        {
            return screenShareComplexManager.IsRequestExists(userID);

        }

        public void LogOffDesktop(int userID)
        {
            screenShareComplexManager.LogOff(userID);

        }

        public bool CheckPartnerAvailability(string username)
        {
            return screenShareComplexManager.CheckPartnerAvailability(username);

        }

        public Dictionary<Dictionary<int, string>, Dictionary<string, string>> GetSentRequestedConnections(int userID)
        {
            return screenShareComplexManager.GetSentRequestedConnections(userID);

        }

        public bool GetOnlineStatus(string username)
        {
            return screenShareComplexManager.GetOnlineStatus(username);
        }

        public int AcceptScreenShareRequest(int screenShareID, int userID)
        {
            return screenShareComplexManager.AcceptScreenShareRequest(screenShareID, userID);

        }

        public void SetConnectionStarted(int connectionID)
        {
            screenShareComplexManager.SetConnectionStarted(connectionID);


        }

        public int CheckAcceptedRequest(int userID)
        {
            return screenShareComplexManager.CheckAcceptedRequest(userID);

        }

        public int CreateScreenShareConnection(int requestID, int userID)
        {
            return screenShareComplexManager.CreateScreenShareConnection(requestID, userID);
        }

        public string[] GetAcceptedRequestInfo(int connID, int userID)
        {
            return screenShareComplexManager.GetAcceptedRequestInfo(connID,userID);
            
        }
    }
}



