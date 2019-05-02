using AydinUniversityProject.Data.Business.AccountComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return View(new CreateAccountFormData());
        }

        [HttpPost]
        public async Task<JsonResult> Login(int response)
        {
            string apiUrl = Url.Action("", "api/Account/GetUser", null, Request.Url.Scheme);
            apiUrl += "?userID="+response;
            User data = null;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync(apiUrl);
                if (res.IsSuccessStatusCode)
                {
                    //var stream = await httpClient.GetStreamAsync(url);
                    //stream.CopyToAsync(fileStream)
                    data = await res.Content.ReadAsAsync<User>();
                    //lessons = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Lesson>>(data);
                }
            }


            Session["Student"] = response;
            Session["User"] = data;
            
            return Json(new { IsSuccess=true});
        }

        [HttpPost]
        public JsonResult Logoff()
        {
            Session.Abandon();
            Session.Clear();
            return Json(new { IsSuccess = true });
        }
    }
}
