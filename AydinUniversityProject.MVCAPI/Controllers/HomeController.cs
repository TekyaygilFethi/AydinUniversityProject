using AydinUniversityProject.Data.Business.AccountComplexManagerData;
using AydinUniversityProject.Data.POCOs;
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
        public JsonResult Login(Student response)
        {
            Session["Student"] = (Student)response;
            
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
