using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.StudentOpsComplexManagers;
using AydinUniversityProject.Data.Business.EducationComplexManagerData;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    [RoutePrefix("api/Education")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EducationApiController : ApiController
    {
        private static EducationOpsComplexManager educationComplexManager = new EducationOpsComplexManager();

        [HttpGet]
        [Route("GetPeriod")]
        public IHttpActionResult GetPeriod([FromUri]GetPeriodFormData gpFormData)
        {
            return Ok(educationComplexManager.GetPeriod(gpFormData.Year, gpFormData.Term));
        }

        [HttpPost]
        [Route("AddLesson")]
        public IHttpActionResult AddLesson([FromBody]AddLessonFormData addLessonFormData)
        {
            if (ModelState.IsValid)
            {
                var response = educationComplexManager.AddLesson(addLessonFormData);

                if (response.IsSuccess)
                    return Ok();

                else
                    return BadRequest(response.Explanation);
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
                return BadRequest(message);
            }
        }

        [HttpGet]
        [Route("GetLessons")]
        public IHttpActionResult GetLessons([FromUri]GetPeriodFormData gpFormData)
        {
            return Ok(educationComplexManager.GetLesson(gpFormData.Year,gpFormData.Term));
        }
    }
}
