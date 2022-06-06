using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        // [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$", 
        // ErrorMessage = "Password must contain at least 1 letter, 1 number and at least 6 characters")]
        public string Password { get; set; }
    }
}