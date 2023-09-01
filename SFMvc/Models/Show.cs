namespace SFMvc.Models
{
    public class Show
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string ImageUrl { get; set; }
        public string LogoUrl { get; set; }
        public string? StreamingUrl { get; set; }
        public int? LengthInMinutes { get; set; }
        public int? NumberOfEpisodes { get; set; }
        public int? NumberOfSeasons { get; set; }
        public int Year { get; set; }
        public List<Shows2Users> UsersThatLikeMe { get; set; }
        public List<Comment> Comments { get; set; }








    }
}
