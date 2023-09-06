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
                      Cast = "Amy Poehler, Jim O'Heir, Nick Offerman, Chris Pratt, Aubrey Plaza, Aziz Ansari, Retta, Rashida Jones, Adam Scott, Rob Lowe, Jay Jackson, Paul Schneider, Ben Schwartz, Mo Collins, Yvans Jourdain, Jon Glaser, Billy Eichner, James Greene",
                      Creators = "Greg Daniels, Michael Schur",
                      ImdbLink = "https://www.imdb.com/title/tt1266020/",
                      Genres = "Comedy"
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
                      Creators = "Peter Morgan",
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
                      ImageUrl = "howtowithjohnwilson2.jpg",
                      LogoUrl = "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      NumberOfEpisodes = 18,
                      NumberOfSeasons = 3,
                      Year = 2020,
                      Cast = "John Wilson",
                      Creators = "John Wilson",
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
                      Cast = "Chris Pratt, Chukwudi Iwuji, Bradley Cooper, Pom Klementieff, Dave Bautista, Karen Gillan, Vin Diesel, Austin Freeman, Stephen Blackehart, Terence Rosemore, Maria Bakalova, Sean Gunn, Sarah Alami, Jasmine Munoz, Giovannie Cruz, Will Poulter, Nico Santos, Miriam Shor",
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
                  },
                  new Show
                  {
                      Id = 10,
                      Title = "One Piece",
                      Description = "There once lived a pirate named Gol D. Roger. He obtained wealth, fame, and power to earn the title of Pirate King. When he was captured and about to be executed, he revealed that his treasure called One Piece was hidden somewhere at the Grand Line. This made all people set out to search and uncover the One Piece treasure, but no one ever found the location of Gol D. Roger's treasure, and the Grand Line was too dangerous a place to overcome. Twenty-two years after Gol D. Roger's death, a boy named Monkey D. Luffy decided to become a pirate and search for Gol D. Roger's treasure to become the next Pirate King.",
                      Format = "Serie",
                      ImageUrl = "one-piece.jpg", 
                      LogoUrl = "Crunchyroll_logo_2.png", 
                      StreamingUrl = "https://www.crunchyroll.com/",
                      NumberOfEpisodes = 1081,
                      NumberOfSeasons = 20,
                      Year = 1999,
                      Cast = "Mayumi Tanaka, Laurent Vernin, Tony Beck, Akemi Okamura, Kazuya Nakai, Kappei Yamaguchi, Hiroaki Hirata, Ikue Ôtani, Colleen Clinkenbeard, Yuriko Yamaguchi, Mahito Ôba, Kazuki Yao, Chikao Ôtsuka, Luci Christian, Christopher Sabat, Sonny Strait, Eric Vale, Chô",
                      Creators = "Eiichirô Oda",
                      ImdbLink = "https://www.imdb.com/title/tt0388629/",
                      Genres = "Animation, Action, Adventure" 
                  },
                  new Show
                  {
                      Id = 11,
                      Title = "Naruto: Shippûden",
                      Description = "Naruto Uzumaki wants to be the best ninja in the land. He's done well so far, but with the looming danger posed by the mysterious Akatsuki organization, Naruto knows he must train harder than ever and leaves his village for intense exercises that will push him to his limits.",
                      Format = "Serie",
                      ImageUrl = "naruto.jpg",
                      LogoUrl = "Crunchyroll_logo_2.png",
                      StreamingUrl = "https://www.crunchyroll.com/",
                      NumberOfEpisodes = 500,
                      NumberOfSeasons = 21,
                      Year = 2007,
                      Cast = "Alexandre Crepet, Junko Takeuchi, Maile Flanagan, Kate Higgins, Chie Nakamura, Dave Wittenberg, Kazuhiko Inoue, Kyle Hebert, Yuri Lowenthal, Noriaki Sugiyama, Masako Katsuki, Debi Mae West, Colleen O'Shaughnessey, Steve Blum, Stephanie Sheh, Shôtarô Morikubo, Tom Gibis, Rikiya Koyama",
                      Creators = "Masashi Kishimoto",
                      ImdbLink = "https://www.imdb.com/title/tt0988824/",
                      Genres = "Animation, Action, Adventure"
                  },
                  new Show
                  {
                      Id = 12,
                      Title = "Barbie",
                      Description = "Barbie suffers a crisis that leads her to question her world and her existence.",
                      Format = "Film",
                      ImageUrl = "barbie2.webp",
                      LogoUrl = "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv", //oklart om den streamar ännu här, lägga till att den inte streamas ännu?
                      LengthInMinutes = 114,
                      Year = 2023,
                      Cast = "Margot Robbie, Ryan Gosling, Issa Rae, Kate McKinnon, Alexandra Shipp, Emma Mackey, Hari Nef, Sharon Rooney, Ana Cruz Kayne, Ritu Arya, Dua Lipa, Nicola Coughlan, Emerald Fennell, Simu Liu, Kingsley Ben-Adir, Ncuti Gatwa, Scott Evans, John Cena",
                      Director = "Greta Gerwig",
                      ImdbLink = "https://www.imdb.com/title/tt1517268/",
                      Genres = "Adventure, Comedy, Fantasy"
                  },
                  new Show
                  {
                      Id = 13,
                      Title = "The Dark Knight",
                      Description = "Set within a year after the events of Batman Begins (2005), Batman, Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin to round up the criminals that plague Gotham City, until a mysterious and sadistic criminal mastermind known only as \"The Joker\" appears in Gotham, creating a new wave of chaos. Batman's struggle against The Joker becomes deeply personal, forcing him to \"confront everything he believes\" and improve his technology to stop him. A love triangle develops between Bruce Wayne, Dent, and Rachel Dawes.",
                      Format = "Film",
                      ImageUrl = "the-dark-knight2.jpg",
                      LogoUrl = "hbo.jfif",
                      StreamingUrl = "https://www.hbomax.com/se/sv",
                      LengthInMinutes = 152,
                      Year = 2008,
                      Cast = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine, Maggie Gyllenhaal, Gary Oldman, Morgan Freeman, Monique Gabriela Curnen, Ron Dean, Cillian Murphy, Chin Han, Nestor Carbonell, Eric Roberts, Ritchie Coster, Anthony Michael Hall, Keith Szarabajka, Colin McFarlane, Joshua Harto",
                      Director = "Christopher Nolan",
                      ImdbLink = "https://www.imdb.com/title/tt0468569/",
                      Genres = "Action, Crime, Drama"
                  },
                  new Show
                  {
                      Id = 14,
                      Title = "Interstellar",
                      Description = "Earth's future has been riddled by disasters, famines, and droughts. There is only one way to ensure mankind's survival: Interstellar travel. A newly discovered wormhole in the far reaches of our solar system allows a team of astronauts to go where no man has gone before, a planet that may have the right environment to sustain human life.",
                      Format = "Film",
                      ImageUrl = "interstellar2.jpg",
                      LogoUrl = "prime-video-logo.png",
                      StreamingUrl = "https://www.primevideo.com/offers/nonprimehomepage/ref=atv_nb_lcl_sv_SE?ie=UTF8",
                      LengthInMinutes = 169,
                      Year = 2014,
                      Cast = "Matthew McConaughey, Anne Hathaway, Jessica Chastain, Mackenzie Foy, Ellen Burstyn, John Lithgow, Timothée Chalamet, David Oyelowo, Collette Wolfe, Francis X. McCarthy, Bill Irwin, Andrew Borba, Wes Bentley, William Devane, Michael Caine, David Gyasi, Josh Stewart, Casey Affleck",
                      Director = "Christopher Nolan",
                      ImdbLink = "https://www.imdb.com/title/tt0816692/",
                      Genres = "Adventure, Drama, Sci-Fi"
                  },
                  new Show
                  {
                      Id = 15,
                      Title = "Only Murders in the Building",
                      Description = "\"Only Murders in the Building\" follows three strangers (Steve Martin, Martin Short, and Selena Gomez) who share an obsession with true crime and suddenly find themselves wrapped up in one. When a grisly death occurs inside their exclusive Upper West Side apartment building, the trio suspects murder and employs their precise knowledge of true crime to investigate the truth. As they record a podcast of their own to document the case, the three unravel the complex secrets of the building which stretch back years. Perhaps even more explosive are the lies they tell one another. Soon, the endangered trio comes to realize a killer might be living amongst them as they race to decipher the mounting clues before it's too late.",
                      Format = "Serie",
                      ImageUrl = "only-murders2.jpg",
                      LogoUrl = "disney.png",
                      StreamingUrl = "https://www.disneyplus.com/en-se",
                      NumberOfEpisodes = 30,
                      NumberOfSeasons = 3,
                      Year = 2021,
                      Cast = "Steve Martin, Martin Short, Selena Gomez, Michael Cyril Creighton, Amy Ryan, Jackie Hoffman, Teddy Coluca, Jayne Houdyshell, Aaron Dominguez, Cara Delevingne, Ryan Broussard, Vanessa Aspillaga, Tina Fey, Adina Verson, Da'Vine Joy Randolph, Jason Veasey, Nathan Lane, Russell G. Jones",
                      Creators = "John Hoffman, Steve Martin",
                      ImdbLink = "https://www.imdb.com/title/tt11691774/",
                      Genres = "Comedy, Crime, Drama"
                  },
                  new Show
                  {
                      Id = 16,
                      Title = "Attack on Titan",
                      Description = "Humans are nearly exterminated by giant creatures called Titans. Titans are typically several stories tall, seem to have no intelligence, devour human beings and, worst of all, seem to do it for the pleasure rather than as a food source. A small percentage of humanity survived by walling themselves in a land protected by extremely high walls, even taller than the biggest of titans. Flash forward to the present, and mankind has not seen a titan in over 100 years. One day, 10 year old Eren and his childhood friend Mikasa witness something horrific as the city walls are destroyed by a colossal titan that appears out of thin air. As the smaller titans flood the city, the two kids watch in horror as Eren's mother is eaten alive. Eren vows that he will murder every single titan and take revenge for all of mankind.",
                      Format = "Serie",
                      ImageUrl = "attack-on-titan2.jpg",
                      LogoUrl = "Crunchyroll_logo_2.png",
                      StreamingUrl = "https://www.crunchyroll.com/",
                      NumberOfEpisodes = 98,
                      NumberOfSeasons = 4,
                      Year = 2013,
                      Cast = "Josh Grelle, Bryce Papenbrook, Yûki Kaji, Yui Ishikawa, Marina Inoue, Trina Nishimura, Kishô Taniyama, Hiro Shimono, Clifford Chapin, Mike McFarland, Romi Park, Matthew Mercer, Jessica Calvello, Hiroshi Kamiya, Yoshimasa Hosoya, Yû Kobayashi, Robert McCollum, Ashly Burch",
                      Creators = "Hajime Isayama",
                      ImdbLink = "https://www.imdb.com/title/tt2560140/",
                      Genres = "Animation, Action, Adventure"
                  },
                  new Show
                  {
                      Id = 17,
                      Title = "The Office",
                      Description = "A mediocre paper company in the hands of Scranton, PA branch manager Michael Scott. This mockumentary follows the everyday lives of the manager and the employees he \"manages.\" The crew follows the employees around 24/7 and captures their quite humorous and bizarre encounters as they will do what it takes to keep the company thriving.",
                      Format = "Serie",
                      ImageUrl = "the-office2.jpg",
                      LogoUrl = "prime-video-logo.png",
                      StreamingUrl = "https://www.primevideo.com/offers/nonprimehomepage/ref=atv_nb_lcl_sv_SE?ie=UTF8",
                      NumberOfEpisodes = 188,
                      NumberOfSeasons = 9,
                      Year = 2005,
                      Cast = "Steve Carell, Jenna Fischer, John Krasinski, Rainn Wilson, Leslie David Baker, Brian Baumgartner, Angela Kinsey, Kate Flannery, Phyllis Smith, Creed Bratton, Oscar Nuñez, B.J. Novak, Mindy Kaling, Ed Helms, Paul Lieberstein, Craig Robinson, Ellie Kemper, Zach Woods",
                      Creators = "Greg Daniels, Ricky Gervais, Stephen Merchant",
                      ImdbLink = "https://www.imdb.com/title/tt0386676/",
                      Genres = "Comedy"
                  },
                  new Show
                  {
                      Id = 18,
                      Title = "Scrubs",
                      Description = "Set in the fictional Sacred Heart hospital in California, John \"J.D\" Dorian makes his way through the overwhelming world of medicine, with the help of his best friend, his fellow rookie doctors, and the arrogant, but brilliant attending physician he views as his mentor.",
                      Format = "Serie",
                      ImageUrl = "scrubs2.jpg",
                      LogoUrl = "disney.png",
                      StreamingUrl = "https://www.disneyplus.com/en-se",
                      NumberOfEpisodes = 169,
                      NumberOfSeasons = 8,
                      Year = 2001,
                      Cast = "Zach Braff, Donald Faison, Sarah Chalke, John C. McGinley, Ken Jenkins, Neil Flynn, Judy Reyes, Robert Maschio, Sam Lloyd, Aloma Wright, Christa Miller, Johnny Kastl, Travis Schuldt, Eliza Coupe, Frank Encarnacao, Charles Rahi Chun, Mike Schwartz, Elizabeth Banks",
                      Creators = "Bill Lawrence",
                      ImdbLink = "https://www.imdb.com/title/tt0285403/",
                      Genres = "Comedy, Drama"
                  }


                );
        }
    }
}
