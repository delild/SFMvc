using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace SFMvc.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Show> Shows { get; set; }
        public DbSet<Shows2Users> Shows2Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Specificerar data som en specific tabellska för-populeras med
            modelBuilder.Entity<Show>().HasData(
                new Show { Id = 1, Title = "Parks and Recreation", Description = "Följ de offentliga tjänstemännen i staden Pawnee...", Format = "Serie", ImageUrl= "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", LogoUrl= "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456" },
                new Show { Id = 2, Title = "The Crown", Description = "I detta drama skildras politiskt maktspel och romantik...", Format = "Serie", ImageUrl= "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", LogoUrl= "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456" },
                new Show { Id = 3, Title = "The Last of us", Description= "20 år efter att ett muterat svampspor-virus förvandlat större delen av...", Format = "Serie", ImageUrl= "https://s2.dmcdn.net/v/UNvgl1ZRLtcvhWl5m/x480", LogoUrl= "https://images.ctfassets.net/4cd45et68cgf/Rx83JoRDMkYNlMC9MKzcB/2b14d5a59fc3937afd3f03191e19502d/Netflix-Symbol.png?w=700&h=456" });
        }
    }
}
