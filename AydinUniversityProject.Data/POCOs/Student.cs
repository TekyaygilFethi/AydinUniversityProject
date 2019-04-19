using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("StudentTable")]
    public class Student
    {
        public Student()
        {
            Educations = new List<Education>();
        }

        [Key,ForeignKey("User")]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birthday { get; set; }
        
        public virtual User User { get; set; }
        
        public virtual List<Education> Educations { get; set; }

        [ForeignKey("PeriodID")]
        public virtual Period Period { get; set; }

        public int PeriodID { get; set; }

        [NotMapped]
        public string NameSurname
        {
            get
            {
                return Name + " " + Surname;
            }
        }
        

    }
}
