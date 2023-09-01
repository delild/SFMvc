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
            modelBuilder.Entity<Show>().HasData
                (
                  new Show 
                  { 
                      Id = 1,
                      Title = "Parks and Recreation",
                      Description = "Följ de offentliga tjänstemännen i staden Pawnee...",
                      Format = "Serie",
                      ImageUrl= "parksandrecreation.jfif",
                      LogoUrl= "netflix.png",
                      StreamingUrl= "https://www.netflix.com/se/",
                      NumberOfEpisodes=124 ,
                      NumberOfSeasons=7,
                      Year=2009
                  },

                  new Show
                  { 
                      Id = 2,
                      Title = "The Crown",
                      Description = "I detta drama skildras politiskt maktspel och romantik...",
                      Format = "Serie",
                      ImageUrl= "thecrown.jpg",
                      LogoUrl= "netflix.png",
                      StreamingUrl = "https://www.netflix.com/se/",
                      NumberOfEpisodes =60 ,
                      NumberOfSeasons =5,
                      Year =2016
                  },

                  new Show 
                  {
                      Id = 3,
                      Title = "The Last of us",
                      Description= "20 år efter att ett muterat svampspor-virus förvandlat större delen av...",
                      Format = "Serie",
                      ImageUrl= "thelastofus.webp",
                      LogoUrl= "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      NumberOfEpisodes =10 ,
                      NumberOfSeasons =1,
                      Year = 2023
                  },

                  new Show
                  {
                      Id = 4,
                      Title = "How To with John Wilson",
                      Description= "In a uniquely hilarious odyssey of self-discovery and cultural observation",
                      Format = "Serie",
                      ImageUrl= "howtowithjohnwilson.jpg",
                      LogoUrl= "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      NumberOfEpisodes =18 ,
                      NumberOfSeasons =3,
                      Year =2020
                  },

                  new Show
                  {
                      Id = 5,
                      Title = "Tenet",
                      Description= "Beväpnad med bara ett ord - \"Tenet\" - reser protagonisten i en skuggvärld...",
                      Format = "Film",
                      ImageUrl= "tenet.jpg",
                      LogoUrl= "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      LengthInMinutes =150,
                      Year =2020
                  },

                  new Show
                  {
                      Id = 6,
                      Title = "Chernobyl",
                      Description= "En dramaserie från HBO i fem delar som följer händelserna kring kärnkraftsolyckan i Tjernobyl...",
                      Format = "Miniserie",
                      ImageUrl= "chernobyl.webp",
                      LogoUrl= "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      NumberOfEpisodes =5,
                      Year = 2019
                  },

                  new Show 
                  { 
                      Id = 7,
                      Title = "The Bear",
                      Description= "Efter att hans bror har tagit livet av sig tar stjärnkocken Carmy...",
                      Format = "Serie",
                      ImageUrl= "thebear.webp",
                      LogoUrl= "disney.png" ,
                      StreamingUrl = "https://www.disneyplus.com/en-se",
                      NumberOfEpisodes =18 ,
                      NumberOfSeasons =2,
                      Year = 2022
                  },

                  new Show
                  { 
                      Id = 8,
                      Title = "Guardians of the Galaxy Vol. 3",
                      Description= "Peter Quill, som fortfarande sörjer förlusten av Gamora, måste ...",
                      Format = "Film",
                      ImageUrl= "guardiansvol3.jpg",
                      LogoUrl= "disney.png",
                      StreamingUrl = "https://www.disneyplus.com/en-se",
                      LengthInMinutes =150,
                      Year =2023 
                  },

                  new Show
                  { 
                      Id = 9,
                      Title = "Guardians of the Galaxy",
                      Description= "Äventyraren Peter Quill stjäl en eftertraktad himlakropp från Ronan, s...",
                      Format = "Film",
                      ImageUrl= "guardians.jfif",
                      LogoUrl= "disney.png",
                      StreamingUrl = "https://www.disneyplus.com/en-se",
                      LengthInMinutes =122,
                      Year =2014 
                  }
                );
        }
    }
}
