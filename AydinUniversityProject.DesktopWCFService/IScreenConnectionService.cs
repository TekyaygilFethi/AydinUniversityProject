using AydinUniversityProject.Data.Business.ScreenShareComplexManagerData;
using System.Collections.Generic;
using System.ServiceModel;

namespace AydinUniversityProject.DesktopWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IScreenConnectionService" in both code and config file together.
    [ServiceContract]
    public interface IScreenConnectionService
    {
        [OperationContract]
        string ReturnViewerIP(int ID);

        [OperationContract]
        string ReturnSharerIP(int ID);

        [OperationContract]
        int CheckLoginCreedientals(string username, string password);

        [OperationContract]
        int ControlConnectionForCreation(int userID,  int lessonID);

        [OperationContract]
        bool ControlConnectionForJoin(string pendingStatus, int connectionID);

        [OperationContract]
        int CreateConnection(int ID, string connectionName ,int categoryID);

        [OperationContract]
        int SaveInvitationString(int connectionID, string InvitationString);

        [OperationContract]
        string GetInvitationString(int connectionID);

        [OperationContract]
        string GetTag(int currentUserID, int connectionID);

        [OperationContract]
        void Disconnect(int currentUserID, int connectionID);

        [OperationContract]
        bool HasConnection(int currentUserID);

        [OperationContract]
        Dictionary<int, string> GetAllLessons();

        [OperationContract]
        Dictionary<Dictionary<int, string>, Dictionary<string, string>> GetRequestedConnections(int userID);

        [OperationContract]
        Dictionary<Dictionary<int, string>, Dictionary<string, string>> GetSentRequestedConnections(int userID);

        [OperationContract]
        bool IsRequestExists(int userID);

        [OperationContract]
        void LogOffDesktop(int userID);

        [OperationContract]
        bool CheckPartnerAvailability(string username);

        [OperationContract]
        bool GetOnlineStatus(string username);

        [OperationContract]
        int AcceptScreenShareRequest(int connectionID, int userID);

        [OperationContract]
        void SetConnectionStarted(int connectionID);

        [OperationContract]
        int CheckAcceptedRequest(int userID);

        [OperationContract]
        int CreateScreenShareConnection(int requestID, int userID);

        [OperationContract]
        string[] GetAcceptedRequestInfo(int connID, int userID);
    }
}
