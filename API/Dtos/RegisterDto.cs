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
        [RegularExpression("^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{6,15}$", 
        ErrorMessage = "Password must contain at least 1 letter, 1 number and at least 6 characters")]
        public string Password { get; set; }
    }
}