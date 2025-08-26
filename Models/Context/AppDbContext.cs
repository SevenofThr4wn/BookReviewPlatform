using Microsoft.EntityFrameworkCore;

namespace BookReviewPlatform.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}
