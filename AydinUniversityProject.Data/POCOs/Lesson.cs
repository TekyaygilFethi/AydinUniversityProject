using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("LessonTable")]
    public class Lesson
    {
        public Lesson()
        {
            Educations = new List<Education>();
            Connections = new List<Connection>();
            Topics = new List<Topic>();
            Posts = new List<Post>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual List<Education> Educations { get; set; }

        public virtual List<Connection> Connections { get; set; }

        public virtual List<Topic> Topics { get; set; }

        public virtual List<Post> Posts { get; set; }

        [ForeignKey("PeriodID")]
        public virtual Period Period { get; set; }

        public int PeriodID { get; set; }

        public double Credit { get; set; }

        public double ECTSCredit { get; set; }

        public int PostCount
        {
            get
            {
                int x = 0;
                Topics.ForEach(topic => x += topic.Posts.Count);
                return x;
            }
        }

    }
}
