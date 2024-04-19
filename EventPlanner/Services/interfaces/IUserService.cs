using EventPlanner.Models;
using System.Linq.Expressions;

namespace EventPlanner.Services.interfaces
{
    public interface IUserService
    {
        void Add(User user);
        void AddRange(IEnumerable<User> user);
        User? GetId(long id);
        Task<User?> GetIdAsync(int id);
        User? Get(Expression<Func<User, bool>> predicate);
        Task<User?> GetAsync(Expression<Func<User, bool>> predicate);
        IEnumerable<User> GetList(Expression<Func<User, bool>> predicate);
        Task<IEnumerable<User>> GetListAsync(Expression<Func<User, bool>> predicate);
        IEnumerable<User> GetAll();
        Task<IEnumerable<User>> GetAllAsync();
        int Count();
        Task<int> CountAsync();
        void Update(User user);
        void Remove(User user);
        public IEnumerable<User> getAllWithEvents();
    }
}
