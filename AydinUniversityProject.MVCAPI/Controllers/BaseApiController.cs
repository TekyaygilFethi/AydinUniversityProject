using AydinUniversityProject.Business.UnitOfWorkFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    public class BaseApiController<T> : ApiController where T:class
    {
       
    }
}
