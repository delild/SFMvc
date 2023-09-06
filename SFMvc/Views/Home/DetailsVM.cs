using SFMvc.Models;

namespace SFMvc.Views.Home
{
    public class DetailsVM
    {
        public ShowVM Show { get; set; }
        public CommentVM[]? Comments { get; set; }
        public string Text { get; set; }
    }

    public class CommentVM
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public string Time { get; set; }
        public string? UserName { get; set; }
        public int ShowId { get; set; }

    }

    public class ShowVM
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
        public int Year { get; set; }
        public string Cast { get; set; }
        public string? Director { get; set; } // för film
        public string? Creators { get; set; } // för serier som har många directors
        public string ImdbLink { get; set; }
        public string Genres { get; set; }
    }
}
