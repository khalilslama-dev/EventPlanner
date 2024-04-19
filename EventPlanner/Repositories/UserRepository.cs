using EventPlanner.Data;
using EventPlanner.Models;
using EventPlanner.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(GestionRendezVousContext gestionRendezVousContext) : base(gestionRendezVousContext)
        {

        }

        public IEnumerable<User> getAllWithEvents()
        {
           return _gestionRendezVousContext.users.Include(user => user.Events).ToList();
        }
    }
}
