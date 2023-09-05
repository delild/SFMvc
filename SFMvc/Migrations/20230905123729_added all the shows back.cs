using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class addedalltheshowsback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Cast", "Creators", "Description", "Director", "Format", "Genres", "ImageUrl", "ImdbLink", "LengthInMinutes", "LogoUrl", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Title", "Year" },
                values: new object[,]
                {
                    { 2, "Claire Foy, Olivia Colman, Imelda Staunton, Matt Smith, Tobias Menzies, Dominic West, Lesley Manville, Charles Edwards, Elizabeth Debicki, Jonathan Pryce, Vanessa Kirby, Marion Bailey, Victoria Hamilton, Helena Bonham Carter, Pip Torrens, Sam Phillips, Erin Doherty, Will Keen", "Peter Morgan", "This show focuses on Queen Elizabeth II as a young newlywed faced with leading the world's most famous monarchy while forging a relationship with legendary Prime Minister Sir Winston Churchill. The British Empire is in decline, the political world is in disarray, but a new era is dawning. Peter Morgan's masterfully-researched scripts reveal the Queen's private journey behind the public façade with daring frankness. Prepare to see into the coveted world of power and privilege behind the locked doors of Westminster and Buckingham Palace. ", null, "Serie", "Biography, Drama, History", "thecrown.jpg", "https://www.imdb.com/title/tt4786824/", null, "netflix.png", 60, 5, "https://www.netflix.com/se/", "The Crown", 2016 },
                    { 3, "Pedro Pascal, Bella Ramsey, Anna Torv, Lamar Johnson, Melanie Lynskey, Nico Parker, Merle Dandridge, Keivonn Woodard, Jeffrey Pierce, John Getz, Gabriel Luna, Samuel Hoeksema, Olivier Ross-Parent, Rutina Wesley, Storm Reid, Scott Shepherd, Ashley Johnson, Nick Offerman", "Neil Druckmann, Craig Mazin", "20 years after modern civilization has been destroyed, Joel, a hardened survivor, is hired to smuggle Ellie, a 14-year-old girl, out of an oppressive quarantine zone. What starts as a small job soon becomes a brutal heartbreaking journey as they both must traverse the U.S. and depend on each other for survival. ", null, "Serie", "Action, Adventure, Drama", "thelastofus.webp", "https://www.imdb.com/title/tt3581920/", null, "hbo.jfif", 10, 1, "https://www.hbomax.com/se/sv", "The Last of us", 2023 },
                    { 4, "John Wilson", null, "An anxious New Yorker who attempts to give everyday advice while dealing with his own personal issues.", "John Wilson", "Serie", "Documentary, Comedy", "howtowithjohnwilson.jpg", "https://www.imdb.com/title/tt10801534/", null, "hbo.jfif", 18, 3, "https://www.hbomax.com/se/sv", "How To with John Wilson", 2020 },
                    { 5, "John David Washington, Robert Pattinson, Elizabeth Debicki, Juhan Ulfsak, Jefferson Hall, Ivo Uukkivi, Andrew Howard, Rich Ceraulo Ko, Jonathan Camp, Wes Chatham, Sander Rebane, Martin Donovan, Clémence Poésy, Josh Stewart, Dimple Kapadia, Denzil Smith, Jeremy Theobald, Michael Caine", null, "In a twilight world of international espionage, an unnamed CIA operative, known as The Protagonist, is recruited by a mysterious organization called Tenet to participate in a global assignment that unfolds beyond real time. The mission: prevent Andrei Sator, a renegade Russian oligarch with precognitive abilities, from starting World War III. The Protagonist will soon master the art of \"time inversion\" as a way of countering the threat that is to come.", "Christopher Nolan", "Film", "Action, Sci-Fi, Thriller", "tenet.jpg", "https://www.imdb.com/title/tt6723592/", 150, "hbo.jfif", null, null, "https://www.hbomax.com/se/sv", "Tenet", 2020 },
                    { 6, "Jessie Buckley, Jared Harris, Stellan Skarsgård, Adam Nagaitis, Emily Watson, Paul Ritter, Robert Emms, Sam Troughton, Karl Davies, Michael Socha, Laura Elphinstone, Jan Ricica, Adrian Rawlins, Alan Williams, Con O'Neill, Douggie McMeekin, Nadia Clifford, David Dencik", "Craig Mazin", "In April 1986, a huge explosion erupted at the Chernobyl nuclear power station in northern Ukraine. This series follows the stories of the men and women, who tried to contain the disaster, as well as those who gave their lives preventing a subsequent and worse one.", null, "Miniserie", "Drama, History, Thriller", "chernobyl.webp", "https://www.imdb.com/title/tt7366338/", null, "hbo.jfif", 5, null, "https://www.hbomax.com/se/sv", "Chernobyl", 2019 },
                    { 7, "Jeremy Allen White, Ebon Moss-Bachrach, Ayo Edebiri, Lionel Boyce, Liza Colón-Zayas, Abby Elliott, Matty Matheson, Edwin Lee Gibson, Corey Hendrix, Richard Esteras, Jose M. Cervantes, Oliver Platt, Chris Witaske, Molly Gordon, Carmen Christopher, Robert Townsend, Joel McHale, Alex Moffat", "Christopher Storer", "Carmen Berzatto, a brilliant young chef from the fine-dining world is forced to return home to run his local family sandwich shop - the Original Beef of Chicagoland - after a heartbreaking death in his family. A world away from what he's used to, Carmy must balance the soul-crushing reality of trading in Michelinu star restaurants for the small 1business' kitchen filled with strong-willed and obstinate staff and his strained familial relationships, all while grappling with the impact of his brother's suicide.", null, "Serie", "Comedy, Drama", "thebear.webp", "https://www.imdb.com/title/tt14452776/", null, "disney.png", 18, 2, "https://www.disneyplus.com/en-se", "The Bear", 2022 },
                    { 8, "Chris Pratt, Chukwudi Iwuji, Bradley Cooper, Pom Klementieff, Dave Bautista, Karen Gillan, Vin Diesel, Austin Freeman, Stephen Blackehart, Terence Rosemore, Maria Bakalova, Sean Gunn, Sarah Alami, Jasmine Munoz, Giovannie Cruz, Will Poulter, Nico Santos, Miriam Shor", null, "In Marvel Studios \"Guardians of the Galaxy Vol. 3\" our beloved band of misfits are looking a bit different these days. Peter Quill, still reeling from the loss of Gamora, must rally his team around him to defend the universe along with protecting one of their own. A mission that, if not completed successfully, could quite possibly lead to the end of the Guardians as we know them.", "James Gunn", "Film", "Action, Adventure, Comedy", "guardiansvol3.jpg", "https://www.imdb.com/title/tt6791350/", 150, "disney.png", null, null, "https://www.disneyplus.com/en-se", "Guardians of the Galaxy Vol. 3", 2023 },
                    { 9, "Chris Pratt, Vin Diesel, Bradley Cooper, Zoe Saldana, Lee Pace, Dave Bautista, Michael Rooker, Karen Gillan, Djimon Hounsou, John C. Reilly, Glenn Close, Laura Haddock, Sean Gunn, Peter Serafinowicz, Christopher Fairbank, Krystian Godlewski, Wyatt Oleff ", null, "After stealing a mysterious orb in the far reaches of outer space, Peter Quill from Earth is now the main target of a manhunt led by the villain known as Ronan the Accuser. To help fight Ronan and his team and save the galaxy from his power, Quill creates a team of space heroes known as the \"Guardians of the Galaxy\" to save the galaxy. ", "James Gunn", "Film", "Action, Adventure, Comedy", "guardians.jfif", "https://www.imdb.com/title/tt2015381/", 122, "disney.png", null, null, "https://www.disneyplus.com/en-se", "Guardians of the Galaxy", 2014 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
