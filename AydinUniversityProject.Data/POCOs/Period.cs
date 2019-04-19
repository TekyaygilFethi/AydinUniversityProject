using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("PeriodTable")]
    public class Period
    {
        public Period()
        {
            Lessons = new List<Lesson>();
            Students = new List<Student>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int Year { get; set; }

        public int Semester { get; set; }

        public virtual List<Lesson> Lessons { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}
