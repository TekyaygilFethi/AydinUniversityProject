using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("EducationTable")]
    public class Education
    {
        public Education()
        {
            Notes = new List<Note>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        [ForeignKey("LessonID")]
        public virtual Lesson Lesson { get; set; }

        public virtual List<Note> Notes { get; set; }

        public int StudentID { get; set; }

        public int LessonID { get; set; }

        [NotMapped]
        public double avg;

        public double Average { get; set; }
    }
}
