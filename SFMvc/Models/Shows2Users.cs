namespace SFMvc.Models
{
    public class Shows2Users
    { 
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public int ShowId { get; set; }
        public Show Show { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
