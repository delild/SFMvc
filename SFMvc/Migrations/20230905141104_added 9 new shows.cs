using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SFMvc.Migrations
{
    /// <inheritdoc />
    public partial class added9newshows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shows",
                columns: new[] { "Id", "Cast", "Creators", "Description", "Director", "Format", "Genres", "ImageUrl", "ImdbLink", "LengthInMinutes", "LogoUrl", "NumberOfEpisodes", "NumberOfSeasons", "StreamingUrl", "Title", "Year" },
                values: new object[,]
                {
                    { 10, "Mayumi Tanaka, Laurent Vernin, Tony Beck, Akemi Okamura, Kazuya Nakai, Kappei Yamaguchi, Hiroaki Hirata, Ikue Ôtani, Colleen Clinkenbeard, Yuriko Yamaguchi, Mahito Ôba, Kazuki Yao, Chikao Ôtsuka, Luci Christian, Christopher Sabat, Sonny Strait, Eric Vale, Chô", "Eiichirô Oda", "There once lived a pirate named Gol D. Roger. He obtained wealth, fame, and power to earn the title of Pirate King. When he was captured and about to be executed, he revealed that his treasure called One Piece was hidden somewhere at the Grand Line. This made all people set out to search and uncover the One Piece treasure, but no one ever found the location of Gol D. Roger's treasure, and the Grand Line was too dangerous a place to overcome. Twenty-two years after Gol D. Roger's death, a boy named Monkey D. Luffy decided to become a pirate and search for Gol D. Roger's treasure to become the next Pirate King.", null, "Serie", "Animation, Action, Adventure", "one-piece.jpg", "https://www.imdb.com/title/tt0388629/", null, "crunchyroll-logo.png", 1081, 20, "https://www.crunchyroll.com/", "One Piece", 1999 },
                    { 11, "Alexandre Crepet, Junko Takeuchi, Maile Flanagan, Kate Higgins, Chie Nakamura, Dave Wittenberg, Kazuhiko Inoue, Kyle Hebert, Yuri Lowenthal, Noriaki Sugiyama, Masako Katsuki, Debi Mae West, Colleen O'Shaughnessey, Steve Blum, Stephanie Sheh, Shôtarô Morikubo, Tom Gibis, Rikiya Koyama", "Masashi Kishimoto", "Naruto Uzumaki wants to be the best ninja in the land. He's done well so far, but with the looming danger posed by the mysterious Akatsuki organization, Naruto knows he must train harder than ever and leaves his village for intense exercises that will push him to his limits.", null, "Serie", "Animation, Action, Adventure", "naruto.jpg", "https://www.imdb.com/title/tt0988824/", null, "crunchyroll-logo.png", 500, 21, "https://www.crunchyroll.com/", "Naruto: Shippûden", 2007 },
                    { 12, "Margot Robbie, Ryan Gosling, Issa Rae, Kate McKinnon, Alexandra Shipp, Emma Mackey, Hari Nef, Sharon Rooney, Ana Cruz Kayne, Ritu Arya, Dua Lipa, Nicola Coughlan, Emerald Fennell, Simu Liu, Kingsley Ben-Adir, Ncuti Gatwa, Scott Evans, John Cena", null, "Barbie suffers a crisis that leads her to question her world and her existence.", "Greta Gerwig", "Film", "Adventure, Comedy, Fantasy", "barbie.jpg", "https://www.imdb.com/title/tt1517268/", 114, "hbo.jfif", null, null, "https://www.hbomax.com/se/sv", "Barbie", 2023 },
                    { 13, "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine, Maggie Gyllenhaal, Gary Oldman, Morgan Freeman, Monique Gabriela Curnen, Ron Dean, Cillian Murphy, Chin Han, Nestor Carbonell, Eric Roberts, Ritchie Coster, Anthony Michael Hall, Keith Szarabajka, Colin McFarlane, Joshua Harto", null, "Set within a year after the events of Batman Begins (2005), Batman, Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin to round up the criminals that plague Gotham City, until a mysterious and sadistic criminal mastermind known only as \"The Joker\" appears in Gotham, creating a new wave of chaos. Batman's struggle against The Joker becomes deeply personal, forcing him to \"confront everything he believes\" and improve his technology to stop him. A love triangle develops between Bruce Wayne, Dent, and Rachel Dawes.", "Christopher Nolan", "Film", "Action, Crime, Drama", "the-dark-knight.jpg", "https://www.imdb.com/title/tt0468569/", 152, "hbo.jfif", null, null, "https://www.hbomax.com/se/sv", "The Dark Knight", 2008 },
                    { 14, "Matthew McConaughey, Anne Hathaway, Jessica Chastain, Mackenzie Foy, Ellen Burstyn, John Lithgow, Timothée Chalamet, David Oyelowo, Collette Wolfe, Francis X. McCarthy, Bill Irwin, Andrew Borba, Wes Bentley, William Devane, Michael Caine, David Gyasi, Josh Stewart, Casey Affleck", null, "Earth's future has been riddled by disasters, famines, and droughts. There is only one way to ensure mankind's survival: Interstellar travel. A newly discovered wormhole in the far reaches of our solar system allows a team of astronauts to go where no man has gone before, a planet that may have the right environment to sustain human life.", "Christopher Nolan", "Film", "Adventure, Drama, Sci-Fi", "interstellar.jpg", "https://www.imdb.com/title/tt0816692/", 169, "prime-video-logo.png", null, null, "https://www.primevideo.com/offers/nonprimehomepage/ref=atv_nb_lcl_sv_SE?ie=UTF8", "Interstellar", 2014 },
                    { 15, "Steve Martin, Martin Short, Selena Gomez, Michael Cyril Creighton, Amy Ryan, Jackie Hoffman, Teddy Coluca, Jayne Houdyshell, Aaron Dominguez, Cara Delevingne, Ryan Broussard, Vanessa Aspillaga, Tina Fey, Adina Verson, Da'Vine Joy Randolph, Jason Veasey, Nathan Lane, Russell G. Jones", "John Hoffman, Steve Martin", "\"Only Murders in the Building\" follows three strangers (Steve Martin, Martin Short, and Selena Gomez) who share an obsession with true crime and suddenly find themselves wrapped up in one. When a grisly death occurs inside their exclusive Upper West Side apartment building, the trio suspects murder and employs their precise knowledge of true crime to investigate the truth. As they record a podcast of their own to document the case, the three unravel the complex secrets of the building which stretch back years. Perhaps even more explosive are the lies they tell one another. Soon, the endangered trio comes to realize a killer might be living amongst them as they race to decipher the mounting clues before it's too late.", null, "Serie", "Comedy, Crime, Drama", "only-murders.jpg", "https://www.imdb.com/title/tt11691774/", null, "disney.png", 30, 3, "https://www.disneyplus.com/en-se", "Only Murders in the Building", 2021 },
                    { 16, "Josh Grelle, Bryce Papenbrook, Yûki Kaji, Yui Ishikawa, Marina Inoue, Trina Nishimura, Kishô Taniyama, Hiro Shimono, Clifford Chapin, Mike McFarland, Romi Park, Matthew Mercer, Jessica Calvello, Hiroshi Kamiya, Yoshimasa Hosoya, Yû Kobayashi, Robert McCollum, Ashly Burch", "Hajime Isayama", "Humans are nearly exterminated by giant creatures called Titans. Titans are typically several stories tall, seem to have no intelligence, devour human beings and, worst of all, seem to do it for the pleasure rather than as a food source. A small percentage of humanity survived by walling themselves in a land protected by extremely high walls, even taller than the biggest of titans. Flash forward to the present, and mankind has not seen a titan in over 100 years. One day, 10 year old Eren and his childhood friend Mikasa witness something horrific as the city walls are destroyed by a colossal titan that appears out of thin air. As the smaller titans flood the city, the two kids watch in horror as Eren's mother is eaten alive. Eren vows that he will murder every single titan and take revenge for all of mankind.", null, "Serie", "Animation, Action, Adventure", "attack-on-titan.jpg", "https://www.imdb.com/title/tt2560140/", null, "crunchyroll-logo.png", 98, 4, "https://www.crunchyroll.com/", "Attack on Titan", 2013 },
                    { 17, "Steve Carell, Jenna Fischer, John Krasinski, Rainn Wilson, Leslie David Baker, Brian Baumgartner, Angela Kinsey, Kate Flannery, Phyllis Smith, Creed Bratton, Oscar Nuñez, B.J. Novak, Mindy Kaling, Ed Helms, Paul Lieberstein, Craig Robinson, Ellie Kemper, Zach Woods", "Greg Daniels, Ricky Gervais, Stephen Merchant", "A mediocre paper company in the hands of Scranton, PA branch manager Michael Scott. This mockumentary follows the everyday lives of the manager and the employees he \"manages.\" The crew follows the employees around 24/7 and captures their quite humorous and bizarre encounters as they will do what it takes to keep the company thriving.", null, "Serie", "Comedy", "the-office.jpg", "https://www.imdb.com/title/tt0386676/", null, "prime-video-logo.png", 188, 9, "https://www.primevideo.com/offers/nonprimehomepage/ref=atv_nb_lcl_sv_SE?ie=UTF8", "The Office", 2005 },
                    { 18, "Zach Braff, Donald Faison, Sarah Chalke, John C. McGinley, Ken Jenkins, Neil Flynn, Judy Reyes, Robert Maschio, Sam Lloyd, Aloma Wright, Christa Miller, Johnny Kastl, Travis Schuldt, Eliza Coupe, Frank Encarnacao, Charles Rahi Chun, Mike Schwartz, Elizabeth Banks", "Bill Lawrence", "Set in the fictional Sacred Heart hospital in California, John \"J.D\" Dorian makes his way through the overwhelming world of medicine, with the help of his best friend, his fellow rookie doctors, and the arrogant, but brilliant attending physician he views as his mentor.", null, "Serie", "Comedy, Drama", "scrubs.jpg", "https://www.imdb.com/title/tt0285403/", null, "disney.png", 169, 8, "https://www.disneyplus.com/en-se", "Scrubs", 2001 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shows",
                keyColumn: "Id",
                keyValue: 18);
        }
    }
}
