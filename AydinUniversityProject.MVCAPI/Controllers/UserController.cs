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
        // GET: User
        public async Task<ActionResult> UserProfile(int ID)
        {
            Student student = null;

            if (((Student)Session["Student"]) != null && ID == ((Student)Session["Student"]).ID)
            {
                TempData["IsLocalUser"] = true;
                student = ((Student)Session["Student"]);
                TempData["IsFavFeedNull"] = student.User.FavouriteFeeds == null;
                TempData["IsSentFeedNull"] = student.User.SentFeeds == null;
                //kendi profili
            }
            else
            {
                TempData["IsLocalUser"] = false;

                if (((Student)Session["Student"]) != null)
                {
                    TempData["IsLogged"] = true;
                    student = (Student)Session["Student"];
                    TempData["IsSentRequest"] = student.User.SentFriendRequests.Any(w => w.RequestToID == ID && w.IsAccepted == false);
                    TempData["IsFriend"] = student.User.FriendRelationship.Friends.Any(w => w.ID == ID);
                }
                else
                {
                    TempData["IsLogged"] = false;

                    string apiUrl = Url.Action("", "api/Account/GetStudent/" + ID, null, Request.Url.Scheme);

                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(apiUrl);
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                        HttpResponseMessage response = await client.GetAsync(apiUrl);
                        if (response.IsSuccessStatusCode)
                        {
                            var data = await response.Content.ReadAsStringAsync();
                            student = Newtonsoft.Json.JsonConvert.DeserializeObject<Student>(data);
                        }
                    }
                }

                TempData["IsFavFeedNull"] = student.User.FavouriteFeeds == null;
                TempData["IsSentFeedNull"] = student.User.SentFeeds == null;
            }
            return View(student);
        }
    }
}