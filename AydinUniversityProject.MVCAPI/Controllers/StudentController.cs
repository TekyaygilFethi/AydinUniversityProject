using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    public class StudentController : Controller
    {

        // GET: Student
        public ActionResult AddNote()
        {
            TempData["StudentID"]=(Session["Student"] as Student).ID;
            return View();
        }
    }
}