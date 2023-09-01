using SFMvc.Models;

namespace SFMvc.Views.Home
{
    public class DetailsVM
    {
        public ShowVM Show { get; set; }
        public CommentVM[]? Comments { get; set; }
        //public List<string>? CommentsText { get; set; }
        //public List<string>? CommentsAuthor { get; set; }
        public string Text { get; set; }
    }

    public class CommentVM
    {
        public int? Id { get; set; }
        public string? Text { get; set; }
        public DateTime? Time { get; set; }
        public ApplicationUser? User { get; set; }
        public string? UserId { get; set; }
        public Show? Show { get; set; }
        public int? ShowId { get; set; }
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
