using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("MessageTable")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string MessageContent { get; set; }

        [ForeignKey("SenderUserID")]
        public virtual User SenderUser { get; set; }

        [ForeignKey("ReceiverUserID")]
        public virtual User ReceiverUser { get; set; }

        public DateTime SendTime { get; set; }

        public int SenderUserID { get; set; }

        public int ReceiverUserID { get; set; }
    }
}
