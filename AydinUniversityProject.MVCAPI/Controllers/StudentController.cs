using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ScreenShareOpsComplexManagers;
using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.StudentOpsComplexManagers;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.EducationComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using AydinUniversityProject.MVCAPI.Filters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    [GenericActionFilter]
    public class StudentController : Controller
    {
        private static EducationOpsComplexManager educationComplexManager = new EducationOpsComplexManager();
        private static ScreenShareOpsComplexManager screenShareComplexManager = new ScreenShareOpsComplexManager();
        // GET: Student
        public ActionResult AddNote()
        {
            TempData["StudentID"] = ((Student)Session["Student"]).ID;
            List<Lesson> lessons = educationComplexManager.GetAllLessons();

            ViewData["Lessons"] = lessons.Select(a => new SelectListItem
            {
                Text = a.Name,
                Value = a.ID.ToString()
            });
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
            TempData["StudentID"] = ((Student)Session["Student"]).ID;
            return View(educationComplexManager.GetEducationsOfStudent(((Student)Session["Student"]).ID));
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

        public JsonResult GetLessons(int Year,int Term)
        {
            var result = JsonConvert.SerializeObject(educationComplexManager.GetLessonsOfTerm(Year, Term), Formatting.Indented,
                           new JsonSerializerSettings
                           {
                               ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                           });

            return Json(result,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult ConnectAsSharer()
        {
            int userID = (Session["Student"] as Student).ID;
            screenShareComplexManager.ConnectAsSharer(userID);

            return  Json(new { Success=true});
        }

        [HttpPost]
        public JsonResult ConnectAsViewer()
        {
            int userID = (Session["Student"] as Student).ID;

            screenShareComplexManager.ConnectAsViewer(userID);

            return  Json(new { Success = true });
        }

    }
}