using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("FriendRequestTable")]
    public class FriendRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("RequesterID")]
        public virtual User Requester { get; set; }

        public int RequesterID { get; set; }


        [ForeignKey("RequestToID")]
        public virtual User RequestTo { get; set; }

        public int RequestToID { get; set; }

        public bool IsAccepted { get; set; }
        


    }
}
