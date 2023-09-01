namespace SFMvc.Models
{
	public class Comment
	{
        public int Id { get; set; }
        public string Text { get; set; }
		public DateTime Time { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public Show Show { get; set; }
        public int ShowId { get; set; }
    }
}
