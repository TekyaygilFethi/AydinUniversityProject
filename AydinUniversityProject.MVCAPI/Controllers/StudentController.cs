using AydinUniversityProject.Data.Business.ForumComplexManager;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    public class StudentController : Controller
    {

        // GET: Student
        public ActionResult AddNote()
        {
            TempData["StudentID"] = (int)Session["Student"];
            return View();
        }

        public ActionResult ListEducations()
        {
            TempData["StudentID"] = (int)Session["Student"];
            return View();
        }

        public ActionResult EducationDetails(int ID)
        {
            TempData["educationID"] = ID;
            return View();
        }

        public async Task<ActionResult> EditEducation(int ID)
        {
            string apiUrl = Url.Action("", "api/Education/GetEducation", null, Request.Url.Scheme);
            apiUrl += "?ID=" + ID;
            Education education = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    education = Newtonsoft.Json.JsonConvert.DeserializeObject<Education>(data);
                }
            }
            return View(education);
        }

        public async Task<ActionResult> TopicPosts(int ID, int? page, int? anchoredPostID)
        {
            string apiUrl = Url.Action("", "api/Education/GetTopic", null, Request.Url.Scheme);
            apiUrl += "?ID=" + ID;
            Topic topic = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    topic = Newtonsoft.Json.JsonConvert.DeserializeObject<Topic>(data);
                }
            }


            apiUrl = Url.Action("", "api/Education/GetUser", null, Request.Url.Scheme);
            apiUrl += "?ID=" + ID;
            User user = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    user = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(data);
                }
            }

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
    }
}