using EventPlanner.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EventPlanner.Repositories
{
    public class BaseRepository<T> : IDisposable where T : class
    {
        protected readonly EventPlannerContext _gestionRendezVousContext;

        public BaseRepository(EventPlannerContext gestionRendezVousContext)
        {
            _gestionRendezVousContext= gestionRendezVousContext;
        }

        public void Add(T model)
        {
            _gestionRendezVousContext.Set<T>().Add(model);
            _gestionRendezVousContext.SaveChanges();
        }

        public void AddRange(IEnumerable<T> model)
        {
            _gestionRendezVousContext.Set<T>().AddRange(model);
            _gestionRendezVousContext.SaveChanges();
        }

        public T? GetId(long id)
        {
            return _gestionRendezVousContext.Set<T>().Find(id);
        }

        public async Task<T?> GetIdAsync(int id)
        {
            return await _gestionRendezVousContext.Set<T>().FindAsync(id);
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return _gestionRendezVousContext.Set<T>().FirstOrDefault(predicate);
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _gestionRendezVousContext.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> predicate)
        {
            return _gestionRendezVousContext.Set<T>().Where<T>(predicate).ToList();
        }

        public async Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> predicate)
        {
            return await Task.Run(() => _gestionRendezVousContext.Set<T>().Where<T>(predicate));
        }

        public IEnumerable<T> GetAll()
        {
            return _gestionRendezVousContext.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.Run(() => _gestionRendezVousContext.Set<T>());
        }

        public int Count()
        {
            return _gestionRendezVousContext.Set<T>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await _gestionRendezVousContext.Set<T>().CountAsync();
        }

        public void Update(T objModel)
        {
            _gestionRendezVousContext.Entry(objModel).State = EntityState.Modified;
            _gestionRendezVousContext.SaveChanges();
        }

        public void Remove(T objModel)
        {
            _gestionRendezVousContext.Set<T>().Remove(objModel);
            _gestionRendezVousContext.SaveChanges();
        }

        public void Dispose()
        {
            _gestionRendezVousContext.Dispose();
        }
    }
}