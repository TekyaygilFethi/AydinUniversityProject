using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    public enum RequestType
    {
        Sharer,
        Viewer
    }

    [Table("ScreenShareRequestTable")]
    public class ScreenShareRequest
    {
        public ScreenShareRequest()
        {
            IsAccepted = false;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("NewConnectionID")]
        public virtual Connection NewConnection { get; set; }

        public int? NewConnectionID { get; set; }

        public bool IsAccepted { get; set; }

        [ForeignKey("RequesterID")]
        public virtual User Requester { get; set; }

        public int RequesterID { get; set; }

        [ForeignKey("RequestToID")]
        public virtual User RequestTo { get; set; }

        public int RequestToID { get; set; }

        public RequestType RequesterRequestType { get; set; }

        public RequestType RequestToRequestType { get; set; }
    }
}
