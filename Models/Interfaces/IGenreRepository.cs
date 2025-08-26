using BookReviewPlatform.Models.Data;

namespace BookReviewPlatform.Models.Interfaces
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        Genre GetGenreWithBooks(int id);
        IEnumerable<Genre> GetAllWithBooks();
    }
}
