using GalleryBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace GalleryRepositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Sp25Prn222Pe2Context _context;
        protected readonly DbSet<T> _dbSet;
        public Repository(Sp25Prn222Pe2Context context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            Save();
        }
        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                Save();
            }

        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
