using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("NoteTable")]
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Description { get; set; }

        public double ResultPoint { get; set; }

        [Range(0,100, ErrorMessage = "The effect must be between 0 and 100")]
        public double EffectRate { get; set; }

        [ForeignKey("EducationID")]
        public virtual Education Education { get; set; }

        public int EducationID { get; set; }
    }
}
