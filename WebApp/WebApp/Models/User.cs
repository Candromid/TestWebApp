using Microsoft.AspNetCore.Identity;
using static System.Net.Mime.MediaTypeNames;

namespace WebApp.Models
{
    public class User : IdentityUser
    {
        public virtual ICollection<Friendship> Friendships { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }

}