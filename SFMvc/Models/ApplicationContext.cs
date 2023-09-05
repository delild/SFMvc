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
        public DbSet<Comment> Comments { get; set; }

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
                      Description = "Leslie Knope, a mid-level bureaucrat in an Indiana Parks and Recreation Department, hopes to beautify her town (and boost her own career) by helping local nurse Ann Perkins turn an abandoned construction site into a community park. However, what should be a fairly simple project is stymied at every turn by oafish bureaucrats, selfish neighbors, governmental red tape, and a myriad of other challenges. Leslie's colleague Tom Haverford, who delights in exploiting his position for personal gain, is as likely to undermine her efforts as to help her, while her boss, Ron Swanson, is adamantly opposed to government in any form, even though he's a bureaucrat.",
                      Format = "Serie",
                      ImageUrl = "parksandrecreation.jfif",
                      LogoUrl = "netflix.png",
                      StreamingUrl = "https://www.netflix.com/se/",
                      NumberOfEpisodes = 124,
                      NumberOfSeasons = 7,
                      Year = 2009,
                      Cast =  "Amy Poehler, Jim O'Heir, Nick Offerman, Chris Pratt, Aubrey Plaza, Aziz Ansari, Retta, Rashida Jones, Adam Scott, Rob Lowe, Jay Jackson, Paul Schneider, Ben Schwartz, Mo Collins, Yvans Jourdain, Jon Glaser, Billy Eichner, James Greene",
                      Creators = "Greg Daniels, Michael Schur",
                      ImdbLink = "https://www.imdb.com/title/tt1266020/",
                      Genres =  "Comedy" 
                  },

                  new Show
                  {
                      Id = 2,
                      Title = "The Crown",
                      Description = "This show focuses on Queen Elizabeth II as a young newlywed faced with leading the world's most famous monarchy while forging a relationship with legendary Prime Minister Sir Winston Churchill. The British Empire is in decline, the political world is in disarray, but a new era is dawning. Peter Morgan's masterfully-researched scripts reveal the Queen's private journey behind the public façade with daring frankness. Prepare to see into the coveted world of power and privilege behind the locked doors of Westminster and Buckingham Palace. ",
                      Format = "Serie",
                      ImageUrl = "thecrown.jpg",
                      LogoUrl = "netflix.png",
                      StreamingUrl = "https://www.netflix.com/se/",
                      NumberOfEpisodes = 60,
                      NumberOfSeasons = 5,
                      Year = 2016,
                      Cast = "Claire Foy, Olivia Colman, Imelda Staunton, Matt Smith, Tobias Menzies, Dominic West, Lesley Manville, Charles Edwards, Elizabeth Debicki, Jonathan Pryce, Vanessa Kirby, Marion Bailey, Victoria Hamilton, Helena Bonham Carter, Pip Torrens, Sam Phillips, Erin Doherty, Will Keen",
                      Creators =  "Peter Morgan" ,
                      ImdbLink = "https://www.imdb.com/title/tt4786824/",
                      Genres = "Biography, Drama, History"
                  },

                  new Show
                  {
                      Id = 3,
                      Title = "The Last of us",
                      Description = "20 years after modern civilization has been destroyed, Joel, a hardened survivor, is hired to smuggle Ellie, a 14-year-old girl, out of an oppressive quarantine zone. What starts as a small job soon becomes a brutal heartbreaking journey as they both must traverse the U.S. and depend on each other for survival. ",
                      Format = "Serie",
                      ImageUrl = "thelastofus.webp",
                      LogoUrl = "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      NumberOfEpisodes = 10,
                      NumberOfSeasons = 1,
                      Year = 2023,
                      Cast = "Pedro Pascal, Bella Ramsey, Anna Torv, Lamar Johnson, Melanie Lynskey, Nico Parker, Merle Dandridge, Keivonn Woodard, Jeffrey Pierce, John Getz, Gabriel Luna, Samuel Hoeksema, Olivier Ross-Parent, Rutina Wesley, Storm Reid, Scott Shepherd, Ashley Johnson, Nick Offerman",
                      Creators = "Neil Druckmann, Craig Mazin",
                      ImdbLink = "https://www.imdb.com/title/tt3581920/",
                      Genres = "Action, Adventure, Drama" 
                  },

                  new Show
                  {
                      Id = 4,
                      Title = "How To with John Wilson",
                      Description = "An anxious New Yorker who attempts to give everyday advice while dealing with his own personal issues.",
                      Format = "Serie",
                      ImageUrl = "howtowithjohnwilson.jpg",
                      LogoUrl = "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      NumberOfEpisodes = 18,
                      NumberOfSeasons = 3,
                      Year = 2020,
                      Cast = "John Wilson",
                      Director = "John Wilson",
                      ImdbLink = "https://www.imdb.com/title/tt10801534/",
                      Genres = "Documentary, Comedy" 
                  },

                  new Show
                  {
                      Id = 5,
                      Title = "Tenet",
                      Description = "In a twilight world of international espionage, an unnamed CIA operative, known as The Protagonist, is recruited by a mysterious organization called Tenet to participate in a global assignment that unfolds beyond real time. The mission: prevent Andrei Sator, a renegade Russian oligarch with precognitive abilities, from starting World War III. The Protagonist will soon master the art of \"time inversion\" as a way of countering the threat that is to come.",
                      Format = "Film",
                      ImageUrl = "tenet.jpg",
                      LogoUrl = "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      LengthInMinutes = 150,
                      Year = 2020,
                      Cast = "John David Washington, Robert Pattinson, Elizabeth Debicki, Juhan Ulfsak, Jefferson Hall, Ivo Uukkivi, Andrew Howard, Rich Ceraulo Ko, Jonathan Camp, Wes Chatham, Sander Rebane, Martin Donovan, Clémence Poésy, Josh Stewart, Dimple Kapadia, Denzil Smith, Jeremy Theobald, Michael Caine",
                      Director = "Christopher Nolan",
                      ImdbLink = "https://www.imdb.com/title/tt6723592/",
                      Genres = "Action, Sci-Fi, Thriller" 
                  },

                  new Show
                  {
                      Id = 6,
                      Title = "Chernobyl",
                      Description = "In April 1986, a huge explosion erupted at the Chernobyl nuclear power station in northern Ukraine. This series follows the stories of the men and women, who tried to contain the disaster, as well as those who gave their lives preventing a subsequent and worse one.",
                      Format = "Miniserie",
                      ImageUrl = "chernobyl.webp",
                      LogoUrl = "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      NumberOfEpisodes = 5,
                      Year = 2019,
                      Cast = "Jessie Buckley, Jared Harris, Stellan Skarsgård, Adam Nagaitis, Emily Watson, Paul Ritter, Robert Emms, Sam Troughton, Karl Davies, Michael Socha, Laura Elphinstone, Jan Ricica, Adrian Rawlins, Alan Williams, Con O'Neill, Douggie McMeekin, Nadia Clifford, David Dencik",
                      Creators = "Craig Mazin",
                      ImdbLink = "https://www.imdb.com/title/tt7366338/",
                      Genres = "Drama, History, Thriller"
                  },

                  new Show
                  {
                      Id = 7,
                      Title = "The Bear",
                      Description = "Carmen Berzatto, a brilliant young chef from the fine-dining world is forced to return home to run his local family sandwich shop - the Original Beef of Chicagoland - after a heartbreaking death in his family. A world away from what he's used to, Carmy must balance the soul-crushing reality of trading in Michelinu star restaurants for the small 1business' kitchen filled with strong-willed and obstinate staff and his strained familial relationships, all while grappling with the impact of his brother's suicide.",
                      Format = "Serie",
                      ImageUrl = "thebear.webp",
                      LogoUrl = "disney.png",
                      StreamingUrl = "https://www.disneyplus.com/en-se",
                      NumberOfEpisodes = 18,
                      NumberOfSeasons = 2,
                      Year = 2022,
                      Cast = "Jeremy Allen White, Ebon Moss-Bachrach, Ayo Edebiri, Lionel Boyce, Liza Colón-Zayas, Abby Elliott, Matty Matheson, Edwin Lee Gibson, Corey Hendrix, Richard Esteras, Jose M. Cervantes, Oliver Platt, Chris Witaske, Molly Gordon, Carmen Christopher, Robert Townsend, Joel McHale, Alex Moffat",
                      Creators = "Christopher Storer",
                      ImdbLink = "https://www.imdb.com/title/tt14452776/",
                      Genres = "Comedy, Drama"
                  },

                  new Show
                  {
                      Id = 8,
                      Title = "Guardians of the Galaxy Vol. 3",
                      Description = "In Marvel Studios \"Guardians of the Galaxy Vol. 3\" our beloved band of misfits are looking a bit different these days. Peter Quill, still reeling from the loss of Gamora, must rally his team around him to defend the universe along with protecting one of their own. A mission that, if not completed successfully, could quite possibly lead to the end of the Guardians as we know them.",
                      Format = "Film",
                      ImageUrl = "guardiansvol3.jpg",
                      LogoUrl = "disney.png",
                      StreamingUrl = "https://www.disneyplus.com/en-se",
                      LengthInMinutes = 150,
                      Year = 2023,
                      Cast =  "Chris Pratt, Chukwudi Iwuji, Bradley Cooper, Pom Klementieff, Dave Bautista, Karen Gillan, Vin Diesel, Austin Freeman, Stephen Blackehart, Terence Rosemore, Maria Bakalova, Sean Gunn, Sarah Alami, Jasmine Munoz, Giovannie Cruz, Will Poulter, Nico Santos, Miriam Shor",
                      Director = "James Gunn",
                      ImdbLink = "https://www.imdb.com/title/tt6791350/",
                      Genres = "Action, Adventure, Comedy"
                  },

                  new Show
                  {
                      Id = 9,
                      Title = "Guardians of the Galaxy",
                      Description = "After stealing a mysterious orb in the far reaches of outer space, Peter Quill from Earth is now the main target of a manhunt led by the villain known as Ronan the Accuser. To help fight Ronan and his team and save the galaxy from his power, Quill creates a team of space heroes known as the \"Guardians of the Galaxy\" to save the galaxy. ",
                      Format = "Film",
                      ImageUrl = "guardians.jfif",
                      LogoUrl = "disney.png",
                      StreamingUrl = "https://www.disneyplus.com/en-se",
                      LengthInMinutes = 122,
                      Year = 2014,
                      Cast = "Chris Pratt, Vin Diesel, Bradley Cooper, Zoe Saldana, Lee Pace, Dave Bautista, Michael Rooker, Karen Gillan, Djimon Hounsou, John C. Reilly, Glenn Close, Laura Haddock, Sean Gunn, Peter Serafinowicz, Christopher Fairbank, Krystian Godlewski, Wyatt Oleff ",
                      Director = "James Gunn",
                      ImdbLink = "https://www.imdb.com/title/tt2015381/",
                      Genres = "Action, Adventure, Comedy"
                  }
                  //new Show
                  //{
                  //    Id = ,
                  //    Title = "",
                  //    Description = "",
                  //    Format = "",
                  //    ImageUrl = "",
                  //    LogoUrl = "",
                  //    StreamingUrl = "",
                  //    LengthInMinutes = ,
                  //    Year = ,
                  //    Cast = { "" },
                  //    Creators = { "" },
                  //    ImdbLink = "",
                  //    Genres = { "" }
                  //}
                );
        }
    }
}
