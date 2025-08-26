using Microsoft.EntityFrameworkCore;
using BookReviewPlatform.Models.Context;
using BookReviewPlatform.Models.Data;
using BookReviewPlatform.Models.Interfaces;

namespace BookReviewPlatform.Models.Repositories
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        private readonly AppDbContext _context;
        public GenreRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Genre GetGenreWithBooks(int id)
        {
            var genre = _context.Genres
                .Include(g => g.Books)
                .ThenInclude(b => b.Author)
                .FirstOrDefault(g => g.Id == id);
            return genre!;
        }

        public IEnumerable<Genre> GetAllWithBooks()
        {
            var genre = _context.Genres
                .Include(g => g.Books)
                .ThenInclude(b => b.Author)
                .ToList();
            return genre;
        }
    }
}
