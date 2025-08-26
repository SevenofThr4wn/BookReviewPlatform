﻿namespace BookReviewPlatform.Models.Data
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<Book> Books { get; set; }
    }
}
