using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Base;
using TocaAi.Infrastructure.Context;

namespace TocaAi.Infrastructure.Repository
{
    public class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> where TEntity : BaseEntity<TId>
    {
        protected readonly TocaAiDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(TocaAiDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void AttachObject(object obj)
        {
            _context.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _context.ChangeTracker.Clear();
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(object id)
        {
            var entity = _dbSet.Find(id);

            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public IList<TEntity> Select(List<string>? includes = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            return query.ToList();
        }

        public TEntity? SelectById(TId id, IList<string>? includes = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if(includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            return query.FirstOrDefault(e => e.Id.Equals(id));
        }
    }
}
