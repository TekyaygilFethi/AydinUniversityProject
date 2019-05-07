using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.StudentOpsComplexManagers;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.EducationComplexManagerData;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Web.Helpers;
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
            return Ok(educationComplexManager.GetLessonsOfTerm(gpFormData.Year, gpFormData.Term));
        }

        [HttpGet]
        [Route("GetAllLessons")]
        public IHttpActionResult GetAllLessons()
        {
            var list = educationComplexManager.GetAllLessons()[0];
                return Ok(list);
        }

        [HttpGet]
        [Route("GetEducationsOfStudent")]
        public IHttpActionResult GetEducationsOfStudent([FromUri]int ID)
        {
            return Ok(educationComplexManager.GetEducationsOfStudent(ID));
        }

        [HttpGet]
        [Route("GetEducation")]
        public IHttpActionResult GetEducation([FromUri]int ID)
        {
            return Ok(educationComplexManager.GetEducation(ID));
        }

        [HttpGet]
        [Route("DeleteEducation/{ID}")]
        public IHttpActionResult DeleteEducation(int ID)
        {
            TransactionObject response = educationComplexManager.DeleteEducation(ID);

            if (response.IsSuccess)
                return Ok();

            else
                return BadRequest(response.Explanation);
        }

        [HttpDelete]
        [Route("DeleteNote")]
        public IHttpActionResult DeleteNote(int ID)
        {
            return Ok(educationComplexManager.DeleteNote(ID));
        }

        [HttpPost]
        [Route("EditNote")]
        public IHttpActionResult EditNote(EditNoteFormData editedNote)
        {
            TransactionObject response = educationComplexManager.EditNote(editedNote);
            if (response.IsSuccess)
            {
                return Ok();
            }
            else
            {
                return BadRequest(response.Explanation);
            }
        }
    }
}
