using EventPlanner.Models;

namespace EventPlanner.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        public IEnumerable<User> getAllWithEvents();
    }
}