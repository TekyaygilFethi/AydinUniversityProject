using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ForumOpsComplexManagers;
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.StudentOpsComplexManagers;
using AydinUniversityProject.Data.Business.ForumComplexManager;
using AydinUniversityProject.Data.POCOs;
using AydinUniversityProject.MVCAPI.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    [GenericActionFilter]
    public class ForumController : Controller
    {
        private static int TopicIDCNT = 0;
        private static ForumComplexManager forumComplexManager = new ForumComplexManager();
        private static EducationOpsComplexManager educationComplexManager = new EducationOpsComplexManager();
        // GET: Forum
        public ActionResult Index()
        {
            List<Lesson> lessons = educationComplexManager.GetAllLessons();

            return View(lessons);
        }

        public ActionResult LessonTopics(int ID, int? page, int? anchoredPostID)
        {
            Lesson lesson = educationComplexManager.GetLesson(ID);


            int _page = page == null ? 0 : ((int)page - 1);

            int fdID = (int)ID;

            TempData["Page"] = _page;

            return View(lesson);
        }

        public ActionResult TopicPosts(int ID, int? page, int? anchoredPostID)
        {
            Topic topic = forumComplexManager.GetTopic(ID);

            User user = (Session["Student"] as Student).User;

            ViewData["User"] = user;

            int _page = page == null ? 0 : page.Value - 1;

            TempData["Page"] = _page;
            List<ProfilePhotoFormData> ppfdList = new List<ProfilePhotoFormData>();

            if (anchoredPostID != null)
            {
                TempData["anchoredPostID"] = (int)anchoredPostID;

                Post anchoredPost = topic.Posts.SingleOrDefault(w => w.ID == anchoredPostID);

                _page = topic.Posts.IndexOf(anchoredPost) % 15 == 0 ? topic.Posts.IndexOf(anchoredPost) / 15 : (topic.Posts.IndexOf(anchoredPost) / 15);
                TempData["Page"] = _page;

            }
            if (topic.Posts != null)
            {
                foreach (var item in topic.Posts)
                {
                    if (ppfdList.SingleOrDefault(w => w.ID == item.SentFeed.User.ID) == null)
                    {
                        ProfilePhotoFormData ppfd = new ProfilePhotoFormData();
                        ppfd.ID = item.SentFeed.User.ID;
                        ppfd.Base64Image = item.SentFeed.User.ProfilePhoto;
                        ppfdList.Add(ppfd);
                    }
                }
            }
            TopicPageFormData tpfd = new TopicPageFormData();
            tpfd.Topic = topic;
            tpfd.ProfilePhotoFormDatas = ppfdList;
            return View(tpfd);
        }

        public ActionResult CreateNewTopic()
        {
            List<Lesson> lessons = educationComplexManager.GetAllLessons();

            ViewData["Lessons"] = lessons.Select(a => new SelectListItem
            {
                Text = a.Name,
                Value = a.ID.ToString()
            });
            return View();
        }

        [HttpPost]
        public JsonResult CreateNewTopic(NewTopicFormData ntfd)
        {
            if (ModelState.IsValid)
            {
                var response = forumComplexManager.CreateNewTopic(ntfd);
                if (!(response.IsSuccess))
                    return Json(new { IsSuccess = false, Error = response.Explanation });

                return Json(new { IsSuccess = true, ID = int.Parse(response.Explanation) });
            }
            else
            {
                string message = string.Empty;
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        message += error.ErrorMessage + "\n";
                    }
                }
                return Json(new { IsSuccess = false, Error = message });
            }
        }

        public JsonResult DeleteTopic(int ID)
        {
            forumComplexManager.DeleteTopic(ID);

            return Json(new { IsSuccess = true });
        }

        public JsonResult SendPost(int topicID, string postContent)
        {
            var response = forumComplexManager.SendPost(topicID, (Session["Student"] as Student).ID, postContent);

            if (response.IsSuccess)
                return Json(new { IsSuccess = true });
            else
                return Json(new { IsSuccess = false, Error = response.Explanation });
        }

        public JsonResult ToggleFavPost(GenericToggleFavFormData gtffd)
        {
            if (ModelState.IsValid)
            {
                var response = forumComplexManager.ToggleFavPost(gtffd.contentID, gtffd.userID);
                if (response.IsSuccess)
                {
                    return Json(new { IsSuccess = true, ID = gtffd.contentID },JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { IsSuccess = false, Error = response.Explanation }, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                string message = string.Empty;
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        message += error.ErrorMessage + "\n";
                    }
                }
                return Json(new { IsSuccess = false, Error = message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}