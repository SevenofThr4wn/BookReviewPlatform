using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewPlatform.Models.Data
{
    public class Review
    {
        [Column("review_id")]
        public int Id { get; set; }

        [Range(1, 5), Column("rating")]
        public int Rating { get; set; }

        [Required, MaxLength(1000), Column("review_text")]
        public string ReviewText { get; set; } = string.Empty;

        public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
    }
}
