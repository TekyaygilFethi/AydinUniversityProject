using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.StudentOpsComplexManagers;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.EducationComplexManagerData;
using AydinUniversityProject.MVCAPI.Filters;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    [GenericActionFilter]
    public class StudentController : Controller
    {
        private static EducationOpsComplexManager educationComplexManager = new EducationOpsComplexManager();

        // GET: Student
        public ActionResult AddNote()
        {
            TempData["StudentID"] = (int)Session["Student"];
            return View();
        }

        [HttpPost]
        public JsonResult AddLesson(AddLessonFormData addLessonFormData)
        {
            if (ModelState.IsValid)
            {
                var response = educationComplexManager.AddLesson(addLessonFormData);

                if (response.IsSuccess)
                    return Json(new { IsSuccess = true });

                else
                    return Json(new { IsSuccess = false, Error = response.Explanation });
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

        public ActionResult EditEducation(int ID)
        {
            var education = educationComplexManager.GetEducation(ID);
            return View(education);
        }

        [HttpPost]
        public JsonResult EditNote(EditNoteFormData editedNote)
        {
            TransactionObject response = educationComplexManager.EditNote(editedNote);
            if (response.IsSuccess)
            {
                return Json(new { IsSuccess = true });
            }
            else
            {
                return Json(new { IsSuccess = false, Error = response.Explanation });
            }
        }

        [HttpPost]
        public JsonResult DeleteEducation(int ID)
        {
            TransactionObject response = educationComplexManager.DeleteEducation(ID);

            if (response.IsSuccess)
                return Json(new{ IsSuccess=true});

            else
                return Json(new { IsSuccess = false,Error=response.Explanation }); 
        }

        public JsonResult GetEducationsOfStudent(int ID)
        {
            return Json(educationComplexManager.GetEducationsOfStudent(ID),JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEducation(int ID)
        {
            return Json(educationComplexManager.GetEducation(ID),JsonRequestBehavior.AllowGet);
        }
    }
}