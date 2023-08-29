using Microsoft.AspNetCore.Identity;

namespace SFMvc.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Shows2Users> MyWatchList { get; set; }
    }
}
