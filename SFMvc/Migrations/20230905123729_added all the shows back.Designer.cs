﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SFMvc.Models;

#nullable disable

namespace SFMvc.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230905123729_added all the shows back")]
    partial class addedalltheshowsback
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SFMvc.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SFMvc.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SFMvc.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Creators")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImdbLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LengthInMinutes")
                        .HasColumnType("int");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfEpisodes")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfSeasons")
                        .HasColumnType("int");

                    b.Property<string>("StreamingUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cast = "Amy Poehler, Jim O'Heir, Nick Offerman, Chris Pratt, Aubrey Plaza, Aziz Ansari, Retta, Rashida Jones, Adam Scott, Rob Lowe, Jay Jackson, Paul Schneider, Ben Schwartz, Mo Collins, Yvans Jourdain, Jon Glaser, Billy Eichner, James Greene",
                            Creators = "Greg Daniels, Michael Schur",
                            Description = "Leslie Knope, a mid-level bureaucrat in an Indiana Parks and Recreation Department, hopes to beautify her town (and boost her own career) by helping local nurse Ann Perkins turn an abandoned construction site into a community park. However, what should be a fairly simple project is stymied at every turn by oafish bureaucrats, selfish neighbors, governmental red tape, and a myriad of other challenges. Leslie's colleague Tom Haverford, who delights in exploiting his position for personal gain, is as likely to undermine her efforts as to help her, while her boss, Ron Swanson, is adamantly opposed to government in any form, even though he's a bureaucrat.",
                            Format = "Serie",
                            Genres = "Comedy",
                            ImageUrl = "parksandrecreation.jfif",
                            ImdbLink = "https://www.imdb.com/title/tt1266020/",
                            LogoUrl = "netflix.png",
                            NumberOfEpisodes = 124,
                            NumberOfSeasons = 7,
                            StreamingUrl = "https://www.netflix.com/se/",
                            Title = "Parks and Recreation",
                            Year = 2009
                        },
                        new
                        {
                            Id = 2,
                            Cast = "Claire Foy, Olivia Colman, Imelda Staunton, Matt Smith, Tobias Menzies, Dominic West, Lesley Manville, Charles Edwards, Elizabeth Debicki, Jonathan Pryce, Vanessa Kirby, Marion Bailey, Victoria Hamilton, Helena Bonham Carter, Pip Torrens, Sam Phillips, Erin Doherty, Will Keen",
                            Creators = "Peter Morgan",
                            Description = "This show focuses on Queen Elizabeth II as a young newlywed faced with leading the world's most famous monarchy while forging a relationship with legendary Prime Minister Sir Winston Churchill. The British Empire is in decline, the political world is in disarray, but a new era is dawning. Peter Morgan's masterfully-researched scripts reveal the Queen's private journey behind the public façade with daring frankness. Prepare to see into the coveted world of power and privilege behind the locked doors of Westminster and Buckingham Palace. ",
                            Format = "Serie",
                            Genres = "Biography, Drama, History",
                            ImageUrl = "thecrown.jpg",
                            ImdbLink = "https://www.imdb.com/title/tt4786824/",
                            LogoUrl = "netflix.png",
                            NumberOfEpisodes = 60,
                            NumberOfSeasons = 5,
                            StreamingUrl = "https://www.netflix.com/se/",
                            Title = "The Crown",
                            Year = 2016
                        },
                        new
                        {
                            Id = 3,
                            Cast = "Pedro Pascal, Bella Ramsey, Anna Torv, Lamar Johnson, Melanie Lynskey, Nico Parker, Merle Dandridge, Keivonn Woodard, Jeffrey Pierce, John Getz, Gabriel Luna, Samuel Hoeksema, Olivier Ross-Parent, Rutina Wesley, Storm Reid, Scott Shepherd, Ashley Johnson, Nick Offerman",
                            Creators = "Neil Druckmann, Craig Mazin",
                            Description = "20 years after modern civilization has been destroyed, Joel, a hardened survivor, is hired to smuggle Ellie, a 14-year-old girl, out of an oppressive quarantine zone. What starts as a small job soon becomes a brutal heartbreaking journey as they both must traverse the U.S. and depend on each other for survival. ",
                            Format = "Serie",
                            Genres = "Action, Adventure, Drama",
                            ImageUrl = "thelastofus.webp",
                            ImdbLink = "https://www.imdb.com/title/tt3581920/",
                            LogoUrl = "hbo.jfif",
                            NumberOfEpisodes = 10,
                            NumberOfSeasons = 1,
                            StreamingUrl = "https://www.hbomax.com/se/sv",
                            Title = "The Last of us",
                            Year = 2023
                        },
                        new
                        {
                            Id = 4,
                            Cast = "John Wilson",
                            Description = "An anxious New Yorker who attempts to give everyday advice while dealing with his own personal issues.",
                            Director = "John Wilson",
                            Format = "Serie",
                            Genres = "Documentary, Comedy",
                            ImageUrl = "howtowithjohnwilson.jpg",
                            ImdbLink = "https://www.imdb.com/title/tt10801534/",
                            LogoUrl = "hbo.jfif",
                            NumberOfEpisodes = 18,
                            NumberOfSeasons = 3,
                            StreamingUrl = "https://www.hbomax.com/se/sv",
                            Title = "How To with John Wilson",
                            Year = 2020
                        },
                        new
                        {
                            Id = 5,
                            Cast = "John David Washington, Robert Pattinson, Elizabeth Debicki, Juhan Ulfsak, Jefferson Hall, Ivo Uukkivi, Andrew Howard, Rich Ceraulo Ko, Jonathan Camp, Wes Chatham, Sander Rebane, Martin Donovan, Clémence Poésy, Josh Stewart, Dimple Kapadia, Denzil Smith, Jeremy Theobald, Michael Caine",
                            Description = "In a twilight world of international espionage, an unnamed CIA operative, known as The Protagonist, is recruited by a mysterious organization called Tenet to participate in a global assignment that unfolds beyond real time. The mission: prevent Andrei Sator, a renegade Russian oligarch with precognitive abilities, from starting World War III. The Protagonist will soon master the art of \"time inversion\" as a way of countering the threat that is to come.",
                            Director = "Christopher Nolan",
                            Format = "Film",
                            Genres = "Action, Sci-Fi, Thriller",
                            ImageUrl = "tenet.jpg",
                            ImdbLink = "https://www.imdb.com/title/tt6723592/",
                            LengthInMinutes = 150,
                            LogoUrl = "hbo.jfif",
                            StreamingUrl = "https://www.hbomax.com/se/sv",
                            Title = "Tenet",
                            Year = 2020
                        },
                        new
                        {
                            Id = 6,
                            Cast = "Jessie Buckley, Jared Harris, Stellan Skarsgård, Adam Nagaitis, Emily Watson, Paul Ritter, Robert Emms, Sam Troughton, Karl Davies, Michael Socha, Laura Elphinstone, Jan Ricica, Adrian Rawlins, Alan Williams, Con O'Neill, Douggie McMeekin, Nadia Clifford, David Dencik",
                            Creators = "Craig Mazin",
                            Description = "In April 1986, a huge explosion erupted at the Chernobyl nuclear power station in northern Ukraine. This series follows the stories of the men and women, who tried to contain the disaster, as well as those who gave their lives preventing a subsequent and worse one.",
                            Format = "Miniserie",
                            Genres = "Drama, History, Thriller",
                            ImageUrl = "chernobyl.webp",
                            ImdbLink = "https://www.imdb.com/title/tt7366338/",
                            LogoUrl = "hbo.jfif",
                            NumberOfEpisodes = 5,
                            StreamingUrl = "https://www.hbomax.com/se/sv",
                            Title = "Chernobyl",
                            Year = 2019
                        },
                        new
                        {
                            Id = 7,
                            Cast = "Jeremy Allen White, Ebon Moss-Bachrach, Ayo Edebiri, Lionel Boyce, Liza Colón-Zayas, Abby Elliott, Matty Matheson, Edwin Lee Gibson, Corey Hendrix, Richard Esteras, Jose M. Cervantes, Oliver Platt, Chris Witaske, Molly Gordon, Carmen Christopher, Robert Townsend, Joel McHale, Alex Moffat",
                            Creators = "Christopher Storer",
                            Description = "Carmen Berzatto, a brilliant young chef from the fine-dining world is forced to return home to run his local family sandwich shop - the Original Beef of Chicagoland - after a heartbreaking death in his family. A world away from what he's used to, Carmy must balance the soul-crushing reality of trading in Michelinu star restaurants for the small 1business' kitchen filled with strong-willed and obstinate staff and his strained familial relationships, all while grappling with the impact of his brother's suicide.",
                            Format = "Serie",
                            Genres = "Comedy, Drama",
                            ImageUrl = "thebear.webp",
                            ImdbLink = "https://www.imdb.com/title/tt14452776/",
                            LogoUrl = "disney.png",
                            NumberOfEpisodes = 18,
                            NumberOfSeasons = 2,
                            StreamingUrl = "https://www.disneyplus.com/en-se",
                            Title = "The Bear",
                            Year = 2022
                        },
                        new
                        {
                            Id = 8,
                            Cast = "Chris Pratt, Chukwudi Iwuji, Bradley Cooper, Pom Klementieff, Dave Bautista, Karen Gillan, Vin Diesel, Austin Freeman, Stephen Blackehart, Terence Rosemore, Maria Bakalova, Sean Gunn, Sarah Alami, Jasmine Munoz, Giovannie Cruz, Will Poulter, Nico Santos, Miriam Shor",
                            Description = "In Marvel Studios \"Guardians of the Galaxy Vol. 3\" our beloved band of misfits are looking a bit different these days. Peter Quill, still reeling from the loss of Gamora, must rally his team around him to defend the universe along with protecting one of their own. A mission that, if not completed successfully, could quite possibly lead to the end of the Guardians as we know them.",
                            Director = "James Gunn",
                            Format = "Film",
                            Genres = "Action, Adventure, Comedy",
                            ImageUrl = "guardiansvol3.jpg",
                            ImdbLink = "https://www.imdb.com/title/tt6791350/",
                            LengthInMinutes = 150,
                            LogoUrl = "disney.png",
                            StreamingUrl = "https://www.disneyplus.com/en-se",
                            Title = "Guardians of the Galaxy Vol. 3",
                            Year = 2023
                        },
                        new
                        {
                            Id = 9,
                            Cast = "Chris Pratt, Vin Diesel, Bradley Cooper, Zoe Saldana, Lee Pace, Dave Bautista, Michael Rooker, Karen Gillan, Djimon Hounsou, John C. Reilly, Glenn Close, Laura Haddock, Sean Gunn, Peter Serafinowicz, Christopher Fairbank, Krystian Godlewski, Wyatt Oleff ",
                            Description = "After stealing a mysterious orb in the far reaches of outer space, Peter Quill from Earth is now the main target of a manhunt led by the villain known as Ronan the Accuser. To help fight Ronan and his team and save the galaxy from his power, Quill creates a team of space heroes known as the \"Guardians of the Galaxy\" to save the galaxy. ",
                            Director = "James Gunn",
                            Format = "Film",
                            Genres = "Action, Adventure, Comedy",
                            ImageUrl = "guardians.jfif",
                            ImdbLink = "https://www.imdb.com/title/tt2015381/",
                            LengthInMinutes = 122,
                            LogoUrl = "disney.png",
                            StreamingUrl = "https://www.disneyplus.com/en-se",
                            Title = "Guardians of the Galaxy",
                            Year = 2014
                        });
                });

            modelBuilder.Entity("SFMvc.Models.Shows2Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ShowId");

                    b.ToTable("Shows2Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SFMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SFMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SFMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SFMvc.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SFMvc.Models.Comment", b =>
                {
                    b.HasOne("SFMvc.Models.Show", "Show")
                        .WithMany()
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SFMvc.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SFMvc.Models.Shows2Users", b =>
                {
                    b.HasOne("SFMvc.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("MyWatchList")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SFMvc.Models.Show", "Show")
                        .WithMany("UsersThatLikeMe")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("SFMvc.Models.ApplicationUser", b =>
                {
                    b.Navigation("MyWatchList");
                });

            modelBuilder.Entity("SFMvc.Models.Show", b =>
                {
                    b.Navigation("UsersThatLikeMe");
                });
#pragma warning restore 612, 618
        }
    }
}