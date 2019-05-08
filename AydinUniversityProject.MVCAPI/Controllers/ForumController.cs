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
        private static ForumComplexManager forumComplexManager;
        private static EducationOpsComplexManager educationComplexManager;
        // GET: Forum
        public ForumController()
        {
            forumComplexManager = new ForumComplexManager();
            educationComplexManager = new EducationOpsComplexManager();
        }

        public ActionResult Index()
        {
            //educationComplexManager = new EducationOpsComplexManager();
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
                    return Json(new { IsSuccess = true, ID = gtffd.contentID }, JsonRequestBehavior.AllowGet);
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

        public JsonResult ToggleFavTopic(GenericToggleFavFormData gtffd)
        {
            if (ModelState.IsValid)
            {
                var response = forumComplexManager.ToggleFavTopic(gtffd.contentID, gtffd.userID);
                if (response.IsSuccess)
                {
                    return Json(new { IsSuccess = true }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { IsSuccess = true, Error = response.Explanation }, JsonRequestBehavior.AllowGet);
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
                return Json(new { IsSuccess = true, Error = message }, JsonRequestBehavior.AllowGet);
            }
        }

        #region Sent and Fav Feed
        //[UserAuthorizationFilter]
        public ActionResult SentPostList()
        {
            User currentUser = (Session["Student"] as Student).User;

            return View(currentUser.SentFeeds.SentPosts);
        }

        //[UserAuthorizationFilter]
        public ActionResult SentTopicList()
        {
            User currentUser = (Session["Student"] as Student).User;
            return View(currentUser.SentFeeds.SentTopics);
        }

        //[UserAuthorizationFilter]
        public ActionResult FavTopicList()
        {
            User currentUser = (Session["Student"] as Student).User;
            return View(currentUser.FavouriteFeeds.FavouriteTopics);
        }

        //[UserAuthorizationFilter]
        public ActionResult FavPostList()
        {
            User currentUser = (Session["Student"] as Student).User;
            return View(currentUser.FavouriteFeeds.FavouritePosts);
        }
        #endregion

        public PartialViewResult EditPostPartial(int ID)
        {
            Post post = forumComplexManager.GetPost(ID);

            TempData["Content"] = post.Content;
            TempData["PostID"] = post.ID;

            return PartialView();
        }

        public PartialViewResult EditTopicPartial(int ID)
        {
            Topic topic = forumComplexManager.GetTopic(ID);

            TempData["Name"] = topic.Name;
            TempData["TopicID"] = topic.ID;

            return PartialView();
        }

        #region Update
        [HttpPost]
        public JsonResult UpdatePost(int ID, string content)
        {
            var response = forumComplexManager.UpdatePost(ID, content);

            if (response.IsSuccess)
            {
                return Json(new { IsSuccess = true });
            }
            else
                return Json(new { IsSuccess = false, Error = response.Explanation });
        }

        [HttpPost]
        public ActionResult UpdateTopic(int ID, string topicName)
        {
            var response = forumComplexManager.UpdateTopic(ID, topicName);

            if (response.IsSuccess)
            {
                return Json(new { IsSuccess = true });
            }
            else
                return Json(new { IsSuccess = false, Error = response.Explanation });
        }
        #endregion

        #region Delete
        [HttpPost]
        public JsonResult DeletePost(int ID)
        {
            var response = forumComplexManager.DeletePost(ID);


            if (response.IsSuccess)
            {
                return Json(new { IsSuccess = true });
            }
            else
                return Json(new { IsSuccess = false, Error = response.Explanation });

            //Post deletedPost = postRepository.GetByIdAsync(ID).Result;
            //Topic topic = deletedPost.Topic;
            //ForumDepartment fd = deletedPost.ForumDepartment;
            //ForumFaculty ff = deletedPost.ForumFaculty;
            //SentFeeds sf = deletedPost.SentFeed;

            //topic.Posts.Remove(deletedPost);
            //fd.Posts.Remove(deletedPost);
            //ff.Posts.Remove(deletedPost);
            //sf.SentPosts.Remove(deletedPost);

            //await postRepository.DeleteAsync(deletedPost);

            //try
            //{
            //    await _uow.SaveChanges();
            //}
            //catch (Exception ex)
            //{

            //}




        }

        [HttpPost]
        public JsonResult DeleteTopic(int ID)
        {
            var response=forumComplexManager.DeleteTopic(ID);

            if (response.IsSuccess)
            {
                return Json(new { IsSuccess = true });
            }
            else
                return Json(new { IsSuccess = false, Error = response.Explanation });
            //Topic deletedTopic = await topicRepository.GetByIdAsync(ID);
            //ForumDepartment fd = deletedTopic.ForumDepartment;
            //ForumFaculty ff = deletedTopic.ForumFaculty;
            //SentFeeds sf = deletedTopic.SentFeed;


            //foreach (var post in deletedTopic.Posts)
            //{
            //    fd.Posts.Remove(post);
            //    ff.Posts.Remove(post);
            //    sf.SentPosts.Remove(post);
            //}

            //await postRepository.DeleteManyAsync(deletedTopic.Posts);

            //await topicRepository.DeleteAsync(deletedTopic);

            //try
            //{
            //    await _uow.SaveChanges();
            //}
            //catch (Exception ex) { }


            //return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
        #endregion
    }
}