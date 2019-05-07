using AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers;
using AydinUniversityProject.Data.Business.AccountComplexManagerData;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    
    public class HomeController : Controller
    {
        private static AccountComplexManager accountManager = new AccountComplexManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return View(new CreateAccountFormData());
        }

        [HttpPost]
        public JsonResult CreateAccount(CreateAccountFormData newAccountInfo)
        {
            if (ModelState.IsValid)
            {
                var response = accountManager.CreateAccount(newAccountInfo);

                if (response.IsSuccess)
                    return Json(new { IsSuccess=true});

                else
                    return Json(new { IsSuccess = false,Error= response.Explanation });
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

        [HttpPost]
        public JsonResult Login(LoginFormData lgnData)
        {
            var response = accountManager.Login(lgnData);
            Session["Student"] = accountManager.GetStudent(response.ID);
            if (response.TransactionObject.IsSuccess)
            {
                return Json(new { IsSuccess = true });
            }
            else
                return Json(new { IsSuccess = false, Error = response.TransactionObject.Explanation });

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
