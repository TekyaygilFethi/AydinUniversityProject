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
            string apiUrl = Url.Action("", "api/Account/GetStudent/", null, Request.Url.Scheme);
            Student student = null;

            if (Session["Student"] != null && ID == (int)Session["Student"])
            {
                TempData["IsLocalUser"] = true;

                apiUrl +=  + (int)Session["Student"];
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


                TempData["IsFavFeedNull"] = student.User.FavouriteFeeds == null;
                TempData["IsSentFeedNull"] = student.User.SentFeeds == null;
                //kendi profili
            }
            else
            {
                TempData["IsLocalUser"] = false;

                apiUrl += "?ID=" + ID;
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
    }
}