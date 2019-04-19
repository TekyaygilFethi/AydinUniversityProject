using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("FriendRelationshipTable")]
    public class FriendRelationship
    {
        public FriendRelationship()
        {
            Friends = new List<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public virtual List<User> Friends { get; set; }
        
        
    }
}
