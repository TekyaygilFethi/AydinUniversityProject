using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("FavouriteFeedsTable")]
    public class FavouriteFeeds
    {
        public FavouriteFeeds()
        {
            FavouritePosts = new List<Post>();
            FavouriteTopics = new List<Topic>();
        }

        [Key,ForeignKey("User")]
        public int ID { get; set; }
        
        public virtual User User { get; set; }

        public virtual List<Topic> FavouriteTopics { get; set; }

        public virtual List<Post> FavouritePosts { get; set; }
    }
}
