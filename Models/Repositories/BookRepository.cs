using BookReviewPlatform.Models.Context;
using BookReviewPlatform.Models.Data;
using BookReviewPlatform.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookReviewPlatform.Models.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Book? GetBookWithAuthorAndGenre(int id)
        {
            var book = _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .FirstOrDefault(b => b.Id == id);
            return book;
        }

        public IEnumerable<Book> GetAllWithAuthorAndGenre()
        {
            var book = _context.Books
                .Include(b => b.Author)
                .Include(b => b.Genre)
                .ToList();
            return book;
        }
    }
}
