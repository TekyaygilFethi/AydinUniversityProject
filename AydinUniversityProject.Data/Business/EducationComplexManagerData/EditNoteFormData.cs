using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.Business.EducationComplexManagerData
{
    public class EditNoteFormData
    {
        public int ID { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double ResultPoint { get; set; }

        [Required]
        [Range(0,100)]
        public double EffectRate { get; set; }
    }
}
