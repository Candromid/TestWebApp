namespace WebApp.Models
{
    public class Friendship
    {
        public int Id { get; set; }
        public string UserAId { get; set; }
        public string UserBId { get; set; }
        public FriendshipStatus Status { get; set; }

        public virtual User UserA { get; set; }
        public virtual User UserB { get; set; }
    }
}
