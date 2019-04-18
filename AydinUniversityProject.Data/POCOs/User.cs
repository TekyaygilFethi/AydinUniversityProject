using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AydinUniversityProject.Data.POCOs
{
    [Table("UserTable")]
    public class User
    {
        public User()
        {
            ConnectionsAsViewer = new List<Connection>();
            ConnectionsAsSharer = new List<Connection>();
            Conversations = new List<Conversation>();
            Friends = new List<User>();
            SignalRConnectionID = "";
            PendingStatus = "none";
            SentScreenShareRequests = new List<ScreenShareRequest>();
            ReceivedScreenShareRequests = new List<ScreenShareRequest>();
            SentFriendRequests = new List<FriendRequest>();
            ReceivedFriendRequests = new List<FriendRequest>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(30, ErrorMessage = "Username can not exceed 30 characters!")]
        public string Username { get; set; }

        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string ProfilePhoto { get; set; }

        public virtual List<Connection> ConnectionsAsViewer { get; set; }

        public virtual List<Connection> ConnectionsAsSharer { get; set; }

        public virtual List<Conversation> Conversations { get; set; }

        [ForeignKey("SentFeedsID")]
        public virtual SentFeeds SentFeeds { get; set; }

        [ForeignKey("FavouriteFeedsID")]
        public virtual FavouriteFeeds FavouriteFeeds { get; set; }

        public virtual Student Student { get; set; }

        public virtual ICollection<User> Friends { get; set; }

        public int? SentFeedsID { get; set; }

        public int? FavouriteFeedsID { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsOnline { get; set; }

        public bool IsLoginToDesktop { get; set; }

        public string PendingStatus { get; set; }

        public string SignalRConnectionID { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual ICollection<ScreenShareRequest> SentScreenShareRequests { get; set; }

        public virtual ICollection<ScreenShareRequest> ReceivedScreenShareRequests { get; set; }

        public virtual ICollection<FriendRequest> SentFriendRequests { get; set; }

        public virtual ICollection<FriendRequest> ReceivedFriendRequests { get; set; }
    }
}
