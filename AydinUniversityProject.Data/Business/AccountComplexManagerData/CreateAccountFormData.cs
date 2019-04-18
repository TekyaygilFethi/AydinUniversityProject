using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.AccountComplexManagerData
{
    public class CreateAccountFormData
    {
        [MaxLength(30, ErrorMessage = "Name can not exceed 30 characters!")]
        public string Name { get; set; }

        [MaxLength(30, ErrorMessage = "Surname can not exceed 30 characters!")]
        public string Surname { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public DateTime Birthday { get; set; }

        [MaxLength(50,ErrorMessage ="Username can not exceeed 50 characters!")]
        public string Username { get; set; }

        public string ProfilePhoto { get; set; }

        [MaxLength(50, ErrorMessage = "Email can not exceeed 50 characters!")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}
