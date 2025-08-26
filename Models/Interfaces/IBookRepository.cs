using BookReviewPlatform.Models.Data;

namespace BookReviewPlatform.Models.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Book? GetBookWithAuthorAndGenre(int id);
        IEnumerable<Book> GetAllWithAuthorAndGenre();
    }
}
