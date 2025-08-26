using System.Linq.Expressions;

namespace BookReviewPlatform.Models.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAllItems();
        T GetItemById(int id);
        IEnumerable<T> FindItem(Expression<Func<T, bool>> predicate);
        void AddItem(T entity);
        void UpdateItem(T entity);
        void DeleteItem(int id);
        void SaveItem();
    }
}
