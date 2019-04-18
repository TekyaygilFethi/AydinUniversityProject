using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("ConversationTable")]
    public class Conversation
    {
        public Conversation()
        {
            Messages = new List<Message>();
            Participants = new List<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public virtual List<Message> Messages { get; set; }

        public DateTime StartTime { get; set; }

        public virtual List<User> Participants { get; set; } //şaibeli
    }
}
