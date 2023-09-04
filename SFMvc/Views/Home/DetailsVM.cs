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
        
        public string? Text { get; set; }
        public DateTime? Time { get; set; }
        public string? UserName { get; set; }

    }

    public class ShowVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string LogoUrl { get; set; }
        public string ImageUrl { get; set; }
    }
}
