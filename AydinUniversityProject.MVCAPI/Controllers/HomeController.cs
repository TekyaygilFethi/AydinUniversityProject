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

        public ActionResult Login(Student responseStudent)
        {
            Session["Student"] = responseStudent;
            
            return RedirectToAction("Index");
        }

    }
}
