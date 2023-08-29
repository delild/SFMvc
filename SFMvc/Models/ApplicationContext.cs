using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SFMvc.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Show> Shows { get; set; }
        public DbSet<Shows2Users> Shows2Users { get; set; }

    }
}
