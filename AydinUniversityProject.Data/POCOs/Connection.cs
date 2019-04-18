using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("ConnectionTable")]
    public class Connection
    {
        public Connection()
        {
            Reviews = new List<Review>();
            //NonBaseRequests = new List<ScreenShareRequest>();
            BaseRequests = new List<ScreenShareRequest>();
            IsConnectionEnded = false;
            IsConnectionStarted = false;

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [ForeignKey("ViewerID")]
        public virtual User Viewer { get; set; }

        [ForeignKey("SharerID")]
        public virtual User Sharer { get; set; }
        
        [ForeignKey("LessonID")]
        public virtual Lesson Lesson { get; set; }

        public string ConnectionString { get; set; }

        public string ConnectionName { get; set; }
        
        public string ViewerIP { get; set; }

        public string SharerIP { get; set; }

        public int? ViewerID { get; set; }

        public int? SharerID { get; set; }

        public bool IsConnectionEnded { get; set; }

        public bool IsConnectionStarted { get; set; }

        public DateTime ConnectionDate { get; set; }

        public TimeSpan ConnectionDuration { get; set; }

        public virtual List<Review> Reviews { get; set; }
        
        public int? LessonID { get; set; }

        public virtual ICollection<ScreenShareRequest> BaseRequests { get; set; }

        //public virtual ICollection<ScreenShareRequest> NonBaseRequests { get; set; }
    }
}
