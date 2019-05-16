using System;
using System.ComponentModel.DataAnnotations;

namespace AydinUniversityProject.Data.Business.AccountComplexManagerData
{
    public class CreateAccountFormData
    {

        [Required]
        [MaxLength(30, ErrorMessage = "Name can not exceed 30 characters!")]
        public string Name { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Surname can not exceed 30 characters!")]
        public string Surname { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Birthday { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Username can not exceeed 50 characters!")]
        public string Username { get; set; }

        public string ProfilePhoto { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Email can not exceeed 50 characters!")]
        [RegularExpression("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int Year { get; set; }

        public int Term { get; set; }

    }
}
