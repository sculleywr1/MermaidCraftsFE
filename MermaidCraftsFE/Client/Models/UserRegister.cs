using System.ComponentModel.DataAnnotations;

namespace MermaidCraftsFE.Client.Models
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, StringLength(100, MinimumLength = 8)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage = "The passwords do not match.")]
        public string PasswordConfirmation { get; set; } = string.Empty;
    }
}
