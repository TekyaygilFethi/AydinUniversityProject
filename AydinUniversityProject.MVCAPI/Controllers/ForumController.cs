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
    public class ForumController : Controller
    {
        static int TopicIDCNT = 0;
        // GET: Forum
        public async Task<ActionResult> Index()
        {
            string apiUrl = Url.Action("", "api/Education/GetAllLessons", null, Request.Url.Scheme);
            List<Lesson> data = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    //var stream = await httpClient.GetStreamAsync(url);
                    //stream.CopyToAsync(fileStream)
                     data = await response.Content.ReadAsAsync<List<Lesson>>();
                    //lessons = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Lesson>>(data);
                }
            }
            return View(data);
        }

        public async Task<ActionResult> LessonTopics(int ID, int? page, int? anchoredPostID)
        {

            string apiUrl = Url.Action("", "api/Forum/GetLesson", null, Request.Url.Scheme);
            apiUrl += "?ID=" + ID;
            Lesson lesson = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    lesson = Newtonsoft.Json.JsonConvert.DeserializeObject<Lesson>(data);
                }
            }

            //ForumDepartmentIDCNT = 0;


            int _page = page == null ? 0 : ((int)page - 1);

            int fdID = (int)ID;

            TempData["Page"] = _page;

            return View(lesson);



        }

        public async Task<ActionResult> TopicPosts(int ID, int? page, int? anchoredPostID)
        {
            TopicIDCNT = ID;
            string apiUrl = Url.Action("", "api/Forum/GetTopic", null, Request.Url.Scheme);
            apiUrl += "?ID=" + ID;
            List<ProfilePhotoFormData> ppfdList = new List<ProfilePhotoFormData>();

            List<Post> posts = new List<Post>();
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
            posts = topic.Posts;

            if (Session["Student"]!=null)
            {
                apiUrl = Url.Action("", "api/Account/GetUser", null, Request.Url.Scheme);
                apiUrl += "?userID=" + (int)Session["Student"];

                User user=null;

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
            }

            int _page = page == null ? 0 : ((int)page) - 1;

            int fdID = (int)ID;

            TempData["Page"] = _page;

            if (anchoredPostID != null)
            {
                TempData["anchoredPostID"] = (int)anchoredPostID;

                Post anchoredPost = posts.SingleOrDefault(w => w.ID == anchoredPostID);

                _page = posts.IndexOf(anchoredPost) % 15 == 0 ? posts.IndexOf(anchoredPost) / 15 : (posts.IndexOf(anchoredPost) / 15);
                TempData["Page"] = _page;

            }
            if (posts != null)
            {
                foreach (var item in posts)
                {
                    if (ppfdList.SingleOrDefault(w => w.ID == item.SentFeed.User.ID) == null)
                    {
                        ProfilePhotoFormData ppfd = new ProfilePhotoFormData();
                        ppfd.ID = item.SentFeed.User.ID;
                        ppfd.Base64Image = /*"data:image/png;base64," +*/ item.SentFeed.User.ProfilePhoto;
                        ppfdList.Add(ppfd);
                    }
                }
            }
            TopicPageFormData tpfd = new TopicPageFormData();
            tpfd.Topic = topic;
            tpfd.ProfilePhotoFormDatas = ppfdList;
            return View(tpfd);
        }

        public async Task<ActionResult> CreateNewTopic()
        {
            TempData["UserID"] = (int)Session["Student"];


            string apiUrl = Url.Action("", "api/Education/GetAllLessons", null, Request.Url.Scheme);
            List<Lesson> lessons = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    lessons = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Lesson>>(data);
                }
            }

            ViewData["Lessons"] = lessons.Select(a => new SelectListItem
            {
                Text = a.Name,
                Value = a.ID.ToString()
            });
            return View();
        }

    }
}