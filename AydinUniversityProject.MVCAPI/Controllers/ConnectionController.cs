using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using AydinUniversityProject.Data.Business.ForumComplexManager;
using AydinUniversityProject.Data.Business.ScreenShareComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    public class ConnectionController : Controller
    {
        ScreenShareOpsComplexManager screenShareManager;

        public ConnectionController()
        {
            screenShareManager = new ScreenShareOpsComplexManager();
        }

        [HttpPost]
        public JsonResult ConnectAsSharer()
        {
            int userID = (Session["Student"] as Student).ID;
            screenShareManager.ConnectAsSharer(userID);

            return Json(new { IsSuccess = true });
        }

        [HttpPost]
        public JsonResult ConnectAsViewer()
        {
            int userID = (Session["Student"] as Student).ID;
            screenShareManager.ConnectAsViewer(userID);

            return Json(new { IsSuccess = true });
        }

        public ActionResult PreviousConnections()
        {
            if (Session["Student"] != null)
            {
                User currentUser = (Session["Student"] as Student).User;

                List<Connection> Connections = new List<Connection>();
                Connections.AddRange(currentUser.ConnectionsAsSharer);
                Connections.AddRange(currentUser.ConnectionsAsViewer);

                return View(Connections);
            }
            else
            {
                return View();
            }
        }

        public ActionResult ConnectionDetails(int ID)
        {
            Connection conn = screenShareManager.GetConnection(ID);

            if ((Session["Student"] as Student).User.ID == conn.SharerID || (Session["Student"] as Student).User.ID == conn.ViewerID)
            {
                TempData["Unauthorized"] = true;
            }
            ConnectionDetailsFormData cdfd = new ConnectionDetailsFormData();
            cdfd.Connection = conn;

            foreach (var review in cdfd.Connection.Reviews)
            {
                ProfilePhotoFormData ppfd = new ProfilePhotoFormData();

                ppfd.ID = review.Sender.ID;
                ppfd.Base64Image = "data:image/png;base64," + review.Sender.ProfilePhoto;
                
                cdfd.ProfilePhotoFormDatas.Add(ppfd);
            }
            return View(cdfd);
        }

        public PartialViewResult EditConnectionNamePartial(int ID)
        {
            Connection connection = screenShareManager.GetConnection(ID);

            TempData["ConnectionName"] = connection.ConnectionName;
            TempData["ConnectionID"] = connection.ID;
            return PartialView();
        }

        [HttpPost]
        public JsonResult UpdateConnectionName(int ID, string name)
        {
            var response = screenShareManager.UpdateConnectionName(ID, name);

            if (response.IsSuccess)
                return Json(new { IsSuccess = true });

            else
                return Json(new { IsSuccess = false, Error = response.Explanation });
        }
        
        public ActionResult CreateReview(int ID)
        {
            Connection connection = screenShareManager.GetConnection(ID);

            return View(connection);
        }

        [HttpPost]
        public JsonResult CreateReview(int ID, string review, string Vote = "upvote")
        {
            int userID = (Session["Student"] as Student).ID;
            var response = screenShareManager.CreateReview(ID, review, userID, Vote);


            if (response.IsSuccess)
                return Json(new { IsSuccess = true });
            else
                return Json(new { IsSuccess = false, Error = response.Explanation });
        }

        [HttpPost]
        public JsonResult EstablishPreviousConnection(int ID, string status)
        {
            int userID = (Session["Student"] as Student).ID;
            var response = screenShareManager.EstablishPreviousConnection(ID, status, userID);

            if (response.IsSuccess)
                return Json(new { IsSuccess = true });
            else
                return Json(new { IsSuccess = false, Explanation = response.Explanation });

        }

        public ActionResult PendingConnection()
        {
            Connection pendingConnection = (Session["Student"] as Student).User.ConnectionsAsSharer.SingleOrDefault(w => w.IsConnectionEnded == false);
            pendingConnection = pendingConnection == null ? (Session["Student"] as Student).User.ConnectionsAsViewer.SingleOrDefault(w => w.IsConnectionEnded == false) : pendingConnection;


            return View(pendingConnection);
        }

        [HttpPost]
        public JsonResult DeletePendingConnection(int ID)
        {

            var response = screenShareManager.DeletePendingConnection(ID);

            if (response.IsSuccess)
                return Json(new { IsSuccess = true });
            else
                return Json(new { IsSuccess = false, Error = response.Explanation });
        }

        public ActionResult EditReview(int ID)
        {
            Review editedReview = screenShareManager.GetReview(ID);

            return View(editedReview);
        }

        [HttpPost]
        public ActionResult EditReview(int ID, string review, string vote = "upvote")
        {
            var response=screenShareManager.EditReview(ID, review, vote);

            if (response.IsSuccess)
                return Json(new { IsSuccess = true });
            else
                return Json(new { IsSuccess = false, Error = response.Explanation });
        }
    }
}