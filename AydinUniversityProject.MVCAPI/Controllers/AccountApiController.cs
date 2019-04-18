using AydinUniversityProject.Business.ComplexManagers.UserOpsComplexManagers;
using AydinUniversityProject.Data.Business.AccountComplexManagerData;
using System.Web.Http;

namespace AydinUniversityProject.MVCAPI.Controllers
{
    public class AccountApiController : ApiController
    {
        private static AccountComplexManager accountManager = new AccountComplexManager();

        [HttpPost]
        public IHttpActionResult CreateAccount(CreateAccountFormData newAccountInfo)
        {
            var response = accountManager.CreateAccount(newAccountInfo);
            
            if (response.IsSuccess)
                return Ok();

            else
                return BadRequest(response.Explanation);
        }

        [HttpPost]
        public IHttpActionResult Login(string username,string password)
        {
            var response = accountManager.Login(username,password);
            if (response.TransactionObject.IsSuccess)
                return Ok(response.Student);
            else
                return BadRequest(response.TransactionObject.Explanation);

        }

        public IHttpActionResult LogOff(int userID)
        {
            var response = accountManager.LogOff(userID);

            if (response.IsSuccess)
                return Ok();
            else
                return BadRequest(response.Explanation);
        }

        public IHttpActionResult GetStudent(int studentID)
        {
            return Ok(accountManager.GetStudent(studentID));
        }

    }
}
