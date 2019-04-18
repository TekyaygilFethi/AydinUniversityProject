using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("ScoreTable")]
    public class Score
    {
        public Score()
        {
            Notes = new List<Note>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("EducationID")]
        public virtual Education Education { get; set; }

        public int EducationID { get; set; }

        public virtual List<Note> Notes { get; set; }

        public double Average
        {
            get
            {
                double avg = 0;
                Notes.ForEach(each => avg += (each.ResultPoint * (each.EffectRate / 100)));
                return avg;
            }
        }
    }
}
