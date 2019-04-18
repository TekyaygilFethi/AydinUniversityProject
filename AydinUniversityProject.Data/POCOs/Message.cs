using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("MessageTable")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string MessageContent { get; set; }

        [ForeignKey("UserID")]
        public virtual User Sender { get; set; }

        [ForeignKey("ConversationID")]
        public virtual Conversation Conversation { get; set; }

        public DateTime SendTime { get; set; }
        
        public int UserID { get; set; }

        public int ConversationID { get; set; }
    }
}
