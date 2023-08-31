using System.ComponentModel.DataAnnotations;

namespace SFMvc.Views.Home

{
    public class RegisterVM
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Repeat password")]
        [Compare(nameof(Password))]
        public string PasswordRepeat { get; set; }
    }
}
