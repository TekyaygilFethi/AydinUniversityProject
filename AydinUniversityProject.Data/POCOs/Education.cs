using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("EducationTable")]
    public class Education
    {
        public Education()
        {
            Scores = new List<Score>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        [ForeignKey("PeriodID")]
        public virtual Period Period { get; set; }

        [ForeignKey("LessonID")]
        public virtual Lesson Lesson { get; set; }

        public virtual List<Score> Scores { get; set; }
        
        public int StudentID { get; set; }

        public int LessonID { get; set; }

        public int PeriodID { get; set; }
    }
}
