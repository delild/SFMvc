using SFMvc.Models;

namespace SFMvc.Views.Home
{
    public class PersonalVM
    {
        public MyCommentVM[]? MyComments { get; set; }
        public MyShowVM[]? MyShows { get; set; }
		

    }

    public class MyCommentVM
    {

        public string? Text { get; set; }
        public string Time { get; set; }
        public string? Title { get; set; }

    }
    public class MyShowVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string LogoUrl { get; set; }
        public string ImageUrl { get; set; }
        public string? StreamingUrl { get; set; }
        public int? LengthInMinutes { get; set; }
        public int? NumberOfEpisodes { get; set; }
        public int? NumberOfSeasons { get; set; }
    }
}
