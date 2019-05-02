using AydinUniversityProject.Business.ManagerFolder.ComplexManagers.ForumOpsComplexManagers;
using AydinUniversityProject.Data.Business.ForumComplexManager;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    [RoutePrefix("api/Forum")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ForumApiController : ApiController
    {
        private static ForumComplexManager forumComplexManager = new ForumComplexManager();

        [HttpGet]
        [Route("TopicPosts")]
        public IHttpActionResult TopicPosts(int ID)
        {
            return Ok(forumComplexManager.TopicPosts(ID));
        }

        [HttpGet]
        [Route("LessonTopics")]
        public IHttpActionResult LessonTopics(int ID)
        {
            return Ok(forumComplexManager.LessonTopics(ID));
        }

        [HttpGet]
        [Route("GetLessonTopic")]
        public IHttpActionResult GetLessonTopic(int ID)
        {
            return Ok(forumComplexManager.LessonTopics(ID));
        }

        [HttpGet]
        [Route("GetTopic")]
        public IHttpActionResult GetTopic(int ID)
        {
            return Ok(forumComplexManager.GetTopic(ID));
        }

        [HttpGet]
        [Route("GetLesson")]
        public IHttpActionResult GetLesson(int ID)
        {
            return Ok(forumComplexManager.GetLesson(ID));
        }

        [HttpGet]
        [Route("GetAllTopics")]
        public IHttpActionResult GetAllTopics()
        {
            return Ok(forumComplexManager.GetAllTopics());
        }

        //[HttpGet]
        //[Route("GetAllLessons")]
        //public IHttpActionResult GetAllLessons()
        //{
        //    return Ok(forumComplexManager.GetAllLessons());
        //}

        [HttpPost]
        [Route("CreateNewTopic")]
        public IHttpActionResult CreateNewTopic([FromBody]NewTopicFormData ntfd)
        {
            if (ModelState.IsValid)
            {
                var response = forumComplexManager.CreateNewTopic(ntfd);
                if (!(response.IsSuccess))
                    return BadRequest(response.Explanation);

                return Ok(int.Parse(response.Explanation));
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
        [Route("ToggleFavTopic")]
        public IHttpActionResult ToggleFavTopic([FromUri]GenericToggleFavFormData gtffd)
        {
            if (ModelState.IsValid)
            {
                var response = forumComplexManager.ToggleFavTopic(gtffd.contentID, gtffd.userID);
                if (response.IsSuccess)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(response.Explanation);
                }
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
        [Route("ToggleFavPost")]
        public IHttpActionResult ToggleFavPost([FromUri]GenericToggleFavFormData gtffd)
        {
            if (ModelState.IsValid)
            {
                var response = forumComplexManager.ToggleFavPost(gtffd.contentID, gtffd.userID);
                if (response.IsSuccess)
                {
                    return Ok(gtffd.contentID);
                }
                else
                {
                    return BadRequest(response.Explanation);
                }
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

        [HttpPost]
        [Route("DeleteTopic")]
        public IHttpActionResult DeleteTopic([FromBody]GenericToggleFavFormData gtffd)
        {
            if (ModelState.IsValid)
            {
                var response = forumComplexManager.ToggleFavPost(gtffd.contentID, gtffd.userID);
                if (response.IsSuccess)
                {
                    return Ok(gtffd.contentID);
                }
                else
                {
                    return BadRequest(response.Explanation);
                }
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
        [Route("GetTopicCountOfStudent")]
        public IHttpActionResult GetTopicCountOfStudent(int ID)
        {
            var response = forumComplexManager.GetTopicCountOfStudent(ID);

            if (response.IsSuccess)
            {
                return Ok(response.Explanation);
            }
            else
            {
                return BadRequest(response.Explanation);
            }
        }

        [HttpGet]
        [Route("GetPostCountOfStudent")]
        public IHttpActionResult GetPostCountOfStudent(int ID)
        {
            var response = forumComplexManager.GetPostCountOfStudent(ID);

            if (response.IsSuccess)
            {
                return Ok(response.Explanation);
            }
            else
            {
                return BadRequest(response.Explanation);
            }
        }

        [HttpGet]
        [Route("GetFavPostCountOfStudent")]
        public IHttpActionResult GetFavPostCountOfStudent(int ID)
        {
            var response = forumComplexManager.GetFavPostCountOfStudent(ID);

            if (response.IsSuccess)
            {
                return Ok(response.Explanation);
            }
            else
            {
                return BadRequest(response.Explanation);
            }
        }

        [HttpGet]
        [Route("GetFavTopicCountOfStudent")]
        public IHttpActionResult GetFavTopicCountOfStudent(int ID)
        {
            var response = forumComplexManager.GetFavTopicCountOfStudent(ID);

            if (response.IsSuccess)
            {
                return Ok(response.Explanation);
            }
            else
            {
                return BadRequest(response.Explanation);
            }
        }
    }
}
