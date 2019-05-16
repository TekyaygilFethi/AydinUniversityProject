using AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers;
using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases;
using AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.ScreenShareOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers;
using AydinUniversityProject.Business.UnitOfWorkFolder;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.AccountComplexManagerData;
using AydinUniversityProject.Data.Business.ScreenShareComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers
{
    public class ScreenShareOpsComplexManager : BaseComplexManager
    {
        ConnectionManager connectionManager;
        UserManager userManager;
        EducationManager eduManager;
        LessonManager lessonManager;
        ScreenShareManager screenShareManager;
        ReviewManager reviewManager;

        IUnitOfWork uow;

        public ScreenShareOpsComplexManager()
        {
            uow = new UnitOfWork(new Database.Context.AydinUniversityProjectContext());

            connectionManager = uow.GetManager<ConnectionManager, Connection>();
            userManager = uow.GetManager<UserManager, User>();
            eduManager = uow.GetManager<EducationManager, Education>();
            lessonManager = uow.GetManager<LessonManager, Lesson>();
            screenShareManager = uow.GetManager<ScreenShareManager, ScreenShareRequest>();
            reviewManager = uow.GetManager<ReviewManager, Review>();
        }

        public TransactionObject AddConnection(Connection conn)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                connectionManager.AddConnection(conn);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public Connection GetConnection(int ID)
        {
            return connectionManager.GetConnection(ID);
        }

        public string GetParticipantIP(int ID, IPType ipType)
        {
            string IP = string.Empty;
            IP = ipType == IPType.Sharer ? connectionManager.GetConnection(ID).SharerIP : connectionManager.GetConnection(ID).ViewerIP;
            return IP;
        }

        public TransactionObject TransferConnectionToWeb(ConnectionEditFormData connFormData)
        {
            TransactionObject response = new TransactionObject();
            Connection conn = GetConnection(connFormData.ID);
            conn.ConnectionString = connFormData.ConnectionString;
            conn.ViewerIP = connFormData.ViewerIP;
            conn.SharerIP = connFormData.SharerIP;
            try
            {
                uow.Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }

            return response;
        }

        public int ControlConnectionForCreation(int userID, int lessonID)
        {
            List<Connection> connectionList = new List<Connection>();
            User user = userManager.GetUser(userID);
            string pendingStatus = user.PendingStatus;

            if (pendingStatus == "Viewer")
            {
                if (lessonID != 0)
                {
                    double avgCurrent = 0;
                    foreach (var edu in user.Student.Educations.Where(w => w.LessonID == lessonID))
                    {
                        avgCurrent += edu.Average;
                    }

                    double avgViewer = 0;


                    connectionList.AddRange(connectionManager.GetConnectionBy(w => w.Viewer == null && w.Sharer != null && w.LessonID == lessonID));


                    foreach (var conn in connectionList)
                    {
                        foreach (var education in conn.Sharer.Student.Educations.Where(w => w.LessonID == lessonID))
                        {
                            avgViewer += education.Average;
                        }
                        //if (avgViewer >= avgCurrent)
                        //{
                        //    connectionList.Remove(conn);
                        //}
                    }
                    if (connectionList.Count == 0)
                    {
                        connectionList.AddRange(connectionManager.GetConnectionBy(w => w.Viewer == null && w.Sharer != null && w.IsConnectionEnded == false));
                    }
                }

                else
                {
                    connectionList.AddRange(connectionManager.GetConnectionBy(w => w.Viewer == null && w.Sharer != null && w.IsConnectionEnded == false));
                }
            }

            else if (pendingStatus == "Sharer")
            {
                if (lessonID != 0)
                {

                    double avgCurrent = 0;
                    foreach (var edu in user.Student.Educations.Where(w => w.LessonID == lessonID))
                    {
                        avgCurrent += edu.Average;


                    }

                    double avgSharer = 0;


                    connectionList.AddRange(connectionManager.GetConnectionBy(w => w.Viewer != null && w.Sharer == null && w.LessonID == lessonID));
                    List<Connection> newConnections = new List<Connection>();


                    foreach (var conn in connectionList)
                    {
                        foreach (var education in conn.Viewer.Student.Educations.Where(w => w.LessonID == lessonID))
                        {
                            avgSharer += education.Average;
                        }
                        if (avgSharer > avgCurrent)
                        {
                            newConnections.Add(conn);
                            //connectionList.Remove(conn);
                        }
                    }
                    if (connectionList.Count == 0)
                    {
                        connectionList.AddRange(connectionManager.GetConnectionBy(w => w.Viewer != null && w.Sharer == null));
                    }
                }

                else
                {
                    connectionList.AddRange(connectionManager.GetConnectionBy(w => w.Viewer != null && w.Sharer == null));
                }
            }

            else
                return -1;

            int randomNumber = -1;

            if (connectionList != null && connectionList.Count != 0)
            {
                randomNumber = FakeData.NumberData.GetNumber(0, connectionList.Count - 1);

                Connection randConnection = connectionList.ElementAt(randomNumber);

                if (pendingStatus == "Viewer")
                {
                    randConnection.Viewer = user;
                    user.ConnectionsAsViewer.Add(randConnection);
                }

                if (pendingStatus == "Sharer")
                {
                    randConnection.Sharer = user;
                    user.ConnectionsAsSharer.Add(randConnection);
                }

                uow.Save();

                return randConnection.ID;
            }
            else
                return -1;


        }

        public int CreateConnection(int ID, string connectionName, int lessonID)
        {
            User _currentUser = userManager.GetUser(ID);
            Lesson lesson = lessonManager.GetLesson(lessonID);

            List<Connection> connections = new List<Connection>();
            connections.AddRange(_currentUser.ConnectionsAsSharer);
            connections.AddRange(_currentUser.ConnectionsAsViewer);

            if (connections.Where(w => w.IsConnectionEnded == false).Count() == 0)
            {
                Connection _newConnection = new Connection();

                _newConnection.ConnectionName = connectionName;
                _newConnection.ConnectionDate = DateTime.Now;

                switch (_currentUser.PendingStatus)
                {
                    case "Viewer":
                        _newConnection.Viewer = _currentUser;
                        _currentUser.ConnectionsAsViewer.Add(_newConnection);
                        lesson.Connections.Add(_newConnection);
                        _newConnection.Lesson = lesson;
                        break;

                    case "Sharer":
                        _newConnection.Sharer = _currentUser;
                        _currentUser.ConnectionsAsSharer.Add(_newConnection);
                        lesson.Connections.Add(_newConnection);
                        _newConnection.Lesson = lesson;
                        break;

                    default:
                        return -1;
                }

                //entities.Users.Attach(_currentUser);

                connectionManager.AddConnection(_newConnection);

                uow.Save();

                return _newConnection.ID;
            }
            else
                return -1;
        }

        public bool ControlConnectionForJoin(string pendingStatus, int connectionID)
        {
            Connection conn = connectionManager.GetConnection(connectionID);

            if (pendingStatus == "Viewer" && conn.SharerID != 0)
            {
                return true;
            }
            else if (pendingStatus == "Sharer" && conn.ViewerID != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TransactionObject SaveInvitationString(int ID, string invitationString)
        {
            TransactionObject response = new TransactionObject();
            Connection conn = GetConnection(ID);
            conn.ConnectionString = invitationString;

            try
            {
                uow.Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public TransactionObject GetInvitationString(int connectionID)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                Connection conn = connectionManager.GetConnection(connectionID);
                response.IsSuccess = true;
                response.Explanation = conn.ConnectionString;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public string GetTag(int currentUserID, int connectionID)
        {
            Connection _connection = connectionManager.GetConnection(connectionID);
            if (currentUserID != -1 || connectionID != -1)
            {
                if (_connection.Viewer != null && _connection.Viewer.ID == currentUserID)
                {
                    return "Viewer";
                }
                else if (_connection.Sharer != null && _connection.Sharer.ID == currentUserID)
                {
                    return "Sharer";
                }
                else
                    return "";
            }
            else
                return "";
        }

        public void Disconnect(int currentUserID, int connectionID)
        {
            Connection currentConnection = connectionManager.GetConnection(connectionID);
            User currentUser = userManager.GetUser(currentUserID);

            currentConnection.IsConnectionEnded = true;
            currentUser.PendingStatus = "none";
            currentConnection.ConnectionDuration = DateTime.Now - currentConnection.ConnectionDate;

            uow.Save();
        }

        public bool HasConnection(int currentUserID)
        {
            User user = userManager.GetUser(currentUserID);
            if (user.PendingStatus == "Viewer" || user.PendingStatus == "Sharer")
                return true;
            else
                return false;
        }

        public Dictionary<int, string> GetAllLessons()
        {
            Dictionary<int, string> categoryDictionary = new Dictionary<int, string>();
            foreach (var lesson in lessonManager.GetAllLessons())
            {
                categoryDictionary.Add(lesson.ID, lesson.Name);
            }
            return categoryDictionary;
        }

        public Dictionary<Dictionary<int, string>, Dictionary<string, string>> GetRequestedConnections(int userID)
        {
            User currentUser = userManager.GetUser(userID);
            Dictionary<int, string> DictionaryIDName = new Dictionary<int, string>();
            Dictionary<string, string> DictionaryUnameCatName = new Dictionary<string, string>();
            Dictionary<Dictionary<int, string>, Dictionary<string, string>> request = new Dictionary<Dictionary<int, string>, Dictionary<string, string>>();

            foreach (var req in currentUser.ReceivedScreenShareRequests.Where(w => w.IsAccepted == false))
            {
                DictionaryIDName.Add(req.ID, req.NewConnection.ConnectionName.Replace("(Repeat)", ""));
                if (!DictionaryUnameCatName.ContainsKey(req.Requester.Username))
                {
                    DictionaryUnameCatName.Add(req.Requester.Username, req.NewConnection.Lesson.Name);
                request.Add(DictionaryIDName, DictionaryUnameCatName);
                }
            }
            return request;
        }

        public bool IsRequestExists(int userID)
        {
            User currentUser = userManager.GetUser(userID);

            if (currentUser.ReceivedScreenShareRequests.Where(w => w.IsAccepted == false).Any() || currentUser.SentScreenShareRequests.Where(w => w.IsAccepted == false).Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LogOff(int userID)
        {
            userManager.GetUser(userID).IsLoginToDesktop = false;
            uow.Save();
        }

        public bool CheckPartnerAvailability(string username)
        {
            User partner = userManager.GetUserByUsername(username);

            if (partner.IsLoginToDesktop == true && !partner.ConnectionsAsSharer.Any(w => w.IsConnectionEnded == false) && !partner.ConnectionsAsViewer.Any(w => w.IsConnectionEnded == false))
            {
                return true;
            }
            else
                return false;
        }

        public Dictionary<Dictionary<int, string>, Dictionary<string, string>> GetSentRequestedConnections(int userID)
        {
            User currentUser = userManager.GetUser(userID);
            Dictionary<int, string> DictionaryIDName = new Dictionary<int, string>();
            Dictionary<string, string> DictionaryUnameCatName = new Dictionary<string, string>();
            Dictionary<Dictionary<int, string>, Dictionary<string, string>> request = new Dictionary<Dictionary<int, string>, Dictionary<string, string>>();

            foreach (var req in currentUser.SentScreenShareRequests.Where(w => w.IsAccepted == false))
            {
                DictionaryIDName.Add(req.ID, req.NewConnection.ConnectionName.Replace("(Repeat)", ""));
                if (!DictionaryUnameCatName.ContainsKey(req.Requester.Username))
                {
                    DictionaryUnameCatName.Add(req.Requester.Username, req.NewConnection.Lesson.Name);
                    request.Add(DictionaryIDName, DictionaryUnameCatName);
                }
            }
            return request;

        }

        public bool GetOnlineStatus(string username)
        {

            return userManager.GetUserByUsername(username).IsLoginToDesktop;

        }

        public int AcceptScreenShareRequest(int screenShareID, int userID)
        {
            ScreenShareRequest request = screenShareManager.GetScreenShareRequest(screenShareID);

            request.IsAccepted = true;

            uow.Save();
            return request.ID;

        }

        public void SetConnectionStarted(int connectionID)
        {

            Connection startedConnection = connectionManager.GetConnection(connectionID);
            startedConnection.IsConnectionStarted = true;
            uow.Save();


        }

        public int CheckAcceptedRequest(int userID)
        {

            User currentUser = userManager.GetUser(userID);

            if (currentUser.SentScreenShareRequests.Any(w => w.IsAccepted == true && w.NewConnection.IsConnectionEnded == false))
            {
                return (int)currentUser.SentScreenShareRequests.FirstOrDefault(w => w.IsAccepted == true && w.NewConnection.IsConnectionEnded == false).NewConnectionID;
            }
            else
            {
                return -1;
            }

        }

        public int CreateScreenShareConnection(int requestID, int userID)
        {

            ScreenShareRequest request = screenShareManager.GetScreenShareRequest(requestID);
            User currentUser = userManager.GetUser(userID);

            Connection newConnection = new Connection();
            newConnection.ConnectionName = request.NewConnection.ConnectionName.Contains("Repeat") ? request.NewConnection.ConnectionName : request.NewConnection.ConnectionName + " (Repeat)";
            newConnection.Lesson = request.NewConnection.Lesson;
            newConnection.ConnectionDate = DateTime.Now;

            request.NewConnection.Lesson.Connections.Add(newConnection);

            newConnection.Sharer = request.RequesterRequestType == RequestType.Sharer ? request.Requester : request.RequestTo;
            newConnection.Viewer = request.RequesterRequestType == RequestType.Sharer ? request.Requester : request.RequestTo;


            newConnection.Sharer.ConnectionsAsSharer.Add(newConnection);
            newConnection.Viewer.ConnectionsAsViewer.Add(newConnection);


            request.NewConnection = newConnection;

            connectionManager.AddConnection(newConnection);

            uow.Save();

            return newConnection.ID;




        }

        public string[] GetAcceptedRequestInfo(int connID, int userID)
        {
            Connection conn = connectionManager.GetConnection(connID);

            string ConnectionName = conn.ConnectionName;
            string AcceptorName = conn.SharerID == userID ? conn.Viewer.Username : conn.Sharer.Username;

            return new string[] { ConnectionName, AcceptorName };

        }

        public void ConnectAsViewer(int userID)
        {
            User sharerUser = userManager.GetUser(userID);


            if (sharerUser.ConnectionsAsSharer.Where(w => w.IsConnectionEnded == false && w.IsConnectionStarted == false).Count() != 0)
            {
                sharerUser.ConnectionsAsSharer.Where(w => w.IsConnectionEnded == false && w.IsConnectionStarted == false).ToList().ForEach(each => each.IsConnectionEnded = true);

            }

            sharerUser.PendingStatus = "Viewer";

            uow.Save();
        }

        public void ConnectAsSharer(int userID)
        {

            User sharerUser = userManager.GetUser(userID);


            if (sharerUser.ConnectionsAsViewer.Where(w => w.IsConnectionEnded == false && w.IsConnectionStarted == false).Count() != 0)
            {
                sharerUser.ConnectionsAsViewer.Where(w => w.IsConnectionEnded == false && w.IsConnectionStarted == false).ToList().ForEach(each => each.IsConnectionEnded = true);
            }


            sharerUser.PendingStatus = "Sharer";

            uow.Save();
        }

        public TransactionObject UpdateConnectionName(int ID, string name)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                Connection connection = GetConnection(ID);
                connection.ConnectionName = name;

                uow.Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }
        
        public TransactionObject CreateReview(int ID, string review,int userID, string vote = "upvote")
        {
            TransactionObject response = new TransactionObject();
            Connection currentConnection = connectionManager.GetConnection(ID);
            User user = userManager.GetUser(userID);

            Review newReview = new Review();
            newReview.Connection = currentConnection;
            newReview.Message = review;
            newReview.Sender = user;

            if (vote == "downvote")
            {
                newReview.Vote = Vote.DownVote;
            }
            else
                newReview.Vote = Vote.Upvote;

            currentConnection.Reviews.Add(newReview);

            reviewManager.AddReview(newReview);

            try
            {
                uow.Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public TransactionObject EstablishPreviousConnection(int ID, string status,int userID)
        {
            TransactionObject response = new TransactionObject();

            User currentUser = userManager.GetUser(userID);
            //currentUser.PendingStatus = "Sharer";
            if (!currentUser.SentScreenShareRequests.Where(w => w.IsAccepted == false && w.NewConnection.IsConnectionEnded == false).Any())
            {
                Connection conn = connectionManager.GetConnection(ID);

                User partnerUser = conn.ViewerID == currentUser.ID ? conn.Sharer : conn.Viewer;

                ScreenShareRequest ssRequest = new ScreenShareRequest();
                ssRequest.Requester = currentUser;
                ssRequest.RequestTo = partnerUser;

                currentUser.SentScreenShareRequests.Add(ssRequest);
                partnerUser.ReceivedScreenShareRequests.Add(ssRequest);

                ssRequest.RequesterRequestType = status == "Sharer" ? RequestType.Sharer : RequestType.Viewer;

                ssRequest.RequestToRequestType = ssRequest.RequesterRequestType == RequestType.Sharer ? RequestType.Viewer : RequestType.Sharer;

                ssRequest.NewConnection = conn;

                screenShareManager.AddScreenShareRequest(ssRequest);

                try
                {
                    uow.Save();
                    response.IsSuccess = true;
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
                response.Explanation="You already have an existing connection pending!";
            }
                return response;

        }

        public TransactionObject DeletePendingConnection(int ID)
        {
            TransactionObject response = new TransactionObject();
            Connection connection = GetConnection(ID);

            connectionManager.DeleteConnection(connection);

            try
            {
                uow.Save();
                response.IsSuccess = true;
            }catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }

            return response;
        }

        public Review GetReview(int ID)
        {
            return reviewManager.GetReview(ID);
        }

        public TransactionObject EditReview(int ID, string review, string vote = "upvote")
        {
            TransactionObject response = new TransactionObject();

            Review editedReview = GetReview(ID);
            editedReview.Message = review;

            if (vote == "downvote")
                editedReview.Vote = Vote.DownVote;

            else
                editedReview.Vote = Vote.Upvote;

            try
            {
                uow.Save();
                response.IsSuccess = true;

            }catch(Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }

            return response;
        }

        
    }
}
