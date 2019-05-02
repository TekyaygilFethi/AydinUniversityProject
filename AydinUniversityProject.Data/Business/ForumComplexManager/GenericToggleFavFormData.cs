using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.ForumComplexManager
{
    public class GenericToggleFavFormData
    {
        [Required]
        public int contentID { get; set; }
        
        [Required]
        public int userID { get; set; }
    }
}
