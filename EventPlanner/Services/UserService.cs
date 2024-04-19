using EventPlanner.Models;
using EventPlanner.Repositories;
using EventPlanner.Repositories.Interfaces;
using EventPlanner.Services.interfaces;
using System.Linq.Expressions;

namespace EventPlanner.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Add(User user)
        {
           _repository.Add(user);
        }

        public void AddRange(IEnumerable<User> user)
        {
            _repository.AddRange(user);
        }

        public int Count()
        {
            return _repository.Count();
        }

        public Task<int> CountAsync()
        {
            return _repository.CountAsync();
        }

        public User? Get(Expression<Func<User, bool>> predicate)
        {
            return (User?) _repository.Get(predicate);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<User?> GetAsync(Expression<Func<User, bool>> predicate)
        {
            return _repository.GetAsync(predicate);
        }

        public User? GetId(long id)
        {
           return _repository.GetId(id);    
        }

        public Task<User?> GetIdAsync(int id)
        {
            return _repository.GetIdAsync(id);  
        }

        public IEnumerable<User> GetList(Expression<Func<User, bool>> predicate)
        {
            return _repository.GetList(predicate);  
        }

        public Task<IEnumerable<User>> GetListAsync(Expression<Func<User, bool>> predicate)
        {
            return _repository.GetListAsync(predicate); 
        }

        public void Remove(User user)
        {
            _repository.Remove(user);
        }

        public void Update(User user)
        {
            _repository.Update(user);
        }
        public IEnumerable<User> getAllWithEvents()
        {
            return _repository.getAllWithEvents();
        }
    }
}
