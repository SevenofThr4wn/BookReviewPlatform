using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookReviewPlatform.Models.Data
{
    public class Book
    {
        public int Id { get; set; }

        [Column("title")]
        [Required, MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Column("description")]
        public string Description { get; set; } = string.Empty;

        [Column("price")]
        public double Price { get; set; } = 0.0d;

        public int AuthorId { get; set; }
        public int GenreId { get; set; }

        public virtual Genre? Genre { get; set; }
        public virtual Author? Author { get; set; }

    }
}
