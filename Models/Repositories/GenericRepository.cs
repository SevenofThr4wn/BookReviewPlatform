using BookReviewPlatform.Models.Context;
using BookReviewPlatform.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookReviewPlatform.Models.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAllItems() => _dbSet.ToList();

        public T GetItemById(int id) => _dbSet.Find(id)!;

        public IEnumerable<T> FindItem(Expression<Func<T, bool>> predicate)
            => _dbSet.Where(predicate);

        public void AddItem(T entity) => _dbSet.Add(entity);

        public void UpdateItem(T entity) => _dbSet.Update(entity);

        public void DeleteItem(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
                _dbSet.Remove(entity);
        }

        public void SaveItem() => _context.SaveChanges();
    }
}
