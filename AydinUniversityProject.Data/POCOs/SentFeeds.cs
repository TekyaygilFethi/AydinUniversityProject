using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("SentFeedsTable")]
    public class SentFeeds
    {
        public SentFeeds()
        {
            SentTopics = new List<Topic>();
            SentPosts = new List<Post>();
        }
        
        [Key,ForeignKey("User")]
        public int ID { get; set; }
        
        public virtual User User { get; set; }

        public virtual List<Topic> SentTopics { get; set; }

        public virtual List<Post> SentPosts { get; set; }
        
    }
}
