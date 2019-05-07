using AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    public class UserController : Controller
    {
        private static AccountComplexManager accountManager = new AccountComplexManager();
        // GET: User
        public ActionResult UserProfile(int ID)
        {
            Student student = Session["Student"] as Student;
            

            if (Session["Student"] != null && ID == ((Student)Session["Student"]).ID)
            {
                TempData["IsLocalUser"] = true;
               
                TempData["IsFavFeedNull"] = student.User.FavouriteFeeds == null;
                TempData["IsSentFeedNull"] = student.User.SentFeeds == null;
                //kendi profili
            }
            else
            {
                TempData["IsLocalUser"] = false;
                student = accountManager.GetStudent(ID);

                if (Session["Student"] != null)
                {
                    TempData["IsLogged"] = true;
                                        
                    TempData["IsSentRequest"] = student.User.SentFriendRequests.Any(w => w.RequestToID == ID && w.IsAccepted == false);
                    TempData["IsFriend"] = student.User.FriendRelationship.Friends.Any(w => w.ID == ID);
                }
                else
                {
                    TempData["IsLogged"] = false;
                    
                }

                TempData["IsFavFeedNull"] = student.User.FavouriteFeeds == null;
                TempData["IsSentFeedNull"] = student.User.SentFeeds == null;
            }
            return View(student);
        }

        public JsonResult GetAllUsernames()
        {
            return Json(accountManager.GetAllUsernames(),JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetIDByUsername(string username)
        {
            return Json(accountManager.GetUserIDByUsername(username),JsonRequestBehavior.AllowGet);
        }

    }
}