using System.ComponentModel.DataAnnotations;
using static BookReviewPlatform.Models.Data.Enums;

namespace BookReviewPlatform.Models.Data
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Username { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.Guest;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;
    }
}
