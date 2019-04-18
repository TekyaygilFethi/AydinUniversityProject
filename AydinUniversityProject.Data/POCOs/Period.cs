using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("PeriodTable")]
    public class Period
    {
        public Period()
        {
            Educations = new List<Education>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int Year { get; set; }

        public int Semester { get; set; }

        public virtual List<Education> Educations { get; set; }
            }
}
