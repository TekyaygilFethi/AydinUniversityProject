using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.ForumComplexManager
{
    public class NewTopicFormData
    {
        [Required]
        public string TopicName { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int LessonID { get; set; }

        [Required]
        public int UserID { get; set; }
    }
}
