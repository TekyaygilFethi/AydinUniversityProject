using System.ComponentModel.DataAnnotations;

namespace AydinUniversityProject.Data.Business.EducationComplexManagerData
{
    public class AddLessonFormData
    {
        public int LessonID { get; set; }
        
        public int StudentID { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Range(0,100,ErrorMessage ="Please enter a valid Rate : 0 - 100")]
        public double Effect { get; set; }

        public double Result { get; set; }
    }
}
