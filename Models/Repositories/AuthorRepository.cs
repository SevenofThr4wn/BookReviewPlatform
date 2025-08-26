using Microsoft.EntityFrameworkCore;
using BookReviewPlatform.Models.Context;
using BookReviewPlatform.Models.Data;
using BookReviewPlatform.Models.Interfaces;

namespace BookReviewPlatform.Models.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        private readonly AppDbContext _context;
        public AuthorRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public Author GetAuthorWithBooks(int id)
        {
            var author = _context.Authors
                .Include(a => a.Books)
                .ThenInclude(b => b.Genre)
                .FirstOrDefault(a => a.Id == id);
            return author!;
        }
        public IEnumerable<Author> GetAllWithBooks()
        {
            var author = _context.Authors
                .Include(a => a.Books)
                .ThenInclude(b => b.Genre)
                .ToList();
            return author;
        }
    }
}
