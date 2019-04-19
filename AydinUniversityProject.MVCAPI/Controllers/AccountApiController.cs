using AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers;
using AydinUniversityProject.Data.Business.AccountComplexManagerData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    [RoutePrefix("api/Account")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AccountApiController : ApiController
    {
        private static AccountComplexManager accountManager = new AccountComplexManager();

        [HttpPost]
        [Route("CreateAccount")]
        public IHttpActionResult CreateAccount(CreateAccountFormData newAccountInfo)
        {
            if (ModelState.IsValid)
            {
                var response = accountManager.CreateAccount(newAccountInfo);

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

        [HttpPost]
        [Route("Login")]
        public IHttpActionResult Login(LoginFormData lgnData)
        {
            var response = accountManager.Login(lgnData);
            if (response.TransactionObject.IsSuccess)
            {
                //var serializer = new JsonSerializer();
                //serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                //var jsonResponse = JsonConvert.SerializeObject(response.Student, Formatting.Indented,
                //    new JsonSerializerSettings
                //    {
                //        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                //    });


                //return Ok(JsonConvert.SerializeObject(response, Formatting.Indent, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }));
                return Ok(response.Student);
            }
            else
                return BadRequest(response.TransactionObject.Explanation);

        }

        [HttpPost]
        [Route("LogOff")]
        public IHttpActionResult LogOff([FromBody]LogOffFormData logOffFormData)
        {
            var response = accountManager.LogOff(logOffFormData.UserID);

            if (response.IsSuccess)
                return Ok();
            else
                return BadRequest(response.Explanation);
        }

        [HttpGet]
        [Route("GetStudent/{studentID}")]
        public IHttpActionResult GetStudent([FromUri]int studentID)
        {
            return Ok(accountManager.GetStudent(studentID));
        }

        //[Route("GetUser")]
        //public IHttpActionResult GetUser(int userID)
        //{
        //    return Ok(accountManager.GetUser(userID));
        //}
        
        [HttpGet]
        [Route("GetAllUsernames")]
        public IHttpActionResult GetAllUsernames()
        {
            return Ok(accountManager.GetAllUsernames());
        }

        [HttpGet]
        [Route("GetIDByUsername")]
        public IHttpActionResult GetIDByUsername([FromUri]string username)
        {
            return Ok(accountManager.GetUserIDByUsername(username));
        }
    }
}
