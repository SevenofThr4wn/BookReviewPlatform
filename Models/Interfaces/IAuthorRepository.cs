using BookReviewPlatform.Models.Data;

namespace BookReviewPlatform.Models.Interfaces
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        Author GetAuthorWithBooks(int id);
        IEnumerable<Author> GetAllWithBooks();
    }
}
