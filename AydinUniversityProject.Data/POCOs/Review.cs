using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    public enum Vote
    {
        Upvote,
        DownVote
    }

    
    [Table("ReviewTable")]
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Message { get; set; }

        public int ReviewPoint { get; set; }

        [ForeignKey("SenderID")]
        public virtual User Sender { get; set; }

        public int SenderID { get; set; }

        [ForeignKey("ConnectionID")]
        public virtual Connection Connection { get; set; }

        public int ConnectionID { get; set; }

        public Vote Vote { get; set; }
    }
}
