﻿using System.Collections.Generic;
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
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }
        
        public virtual List<Education> Educations { get; set; }

        public virtual List<Connection> Connections { get; set; }

        public virtual List<Topic> Topics { get; set; }        
    }
}