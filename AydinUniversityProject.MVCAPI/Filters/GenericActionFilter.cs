using AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AydinUniversityProject.MVCAPI.Filters
{
    public class GenericActionFilter : ActionFilterAttribute
    {
        AccountComplexManager accountManager;

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            accountManager = new AccountComplexManager();
            Student sessionStudent = accountManager.GetStudent((filterContext.HttpContext.Session["Student"] as Student).ID);
            filterContext.HttpContext.Session["Student"] = sessionStudent;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            accountManager = new AccountComplexManager();
            Student sessionStudent = accountManager.GetStudent((filterContext.HttpContext.Session["Student"] as Student).ID);
            filterContext.HttpContext.Session["Student"] = sessionStudent;
        }
    }
}