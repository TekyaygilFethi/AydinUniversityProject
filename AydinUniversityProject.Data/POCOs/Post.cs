using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("PostTable")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Content { get; set; }

        public string AttachmentUrl { get; set; }

        [ForeignKey("TopicID")]
        public virtual Topic Topic { get; set; }

        public int TopicID { get; set; }
        
        public DateTime PostDate { get; set; }

        [ForeignKey("SentFeedID")]
        public virtual SentFeeds SentFeed { get; set; }

        public int SentFeedID { get; set; }

        [ForeignKey("FavouriteFeedID")]
        public virtual FavouriteFeeds FavouriteFeed { get; set; }

        public int? FavouriteFeedID { get; set; }

        public int FavouritedCount { get; set; }
    }
}
