using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("TopicTable")]
    public class Topic
    {
        public Topic()
        {
            Posts = new List<Post>();
            FavouriteFeeds = new List<FavouriteFeeds>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }

        public virtual List<FavouriteFeeds> FavouriteFeeds { get; set; }

        [ForeignKey("LessonID")]
        public virtual Lesson Lesson { get; set; }

        [ForeignKey("SentFeedID")]
        public virtual SentFeeds SentFeed { get; set; }

        public int SentFeedID { get; set; }

        public int FavouritedCount { get; set; }

        public int LessonID { get; set; }
    }
}
