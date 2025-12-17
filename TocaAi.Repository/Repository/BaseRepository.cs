using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Base;
using TocaAi.Repository.Context;

namespace TocaAi.Repository.Repository
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

        public IList<TEntity> Select(bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (!tracking)
                query = query.AsNoTracking();

            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            return query.ToList();
        }

        public TEntity? SelectById(TId id, bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (!tracking)
                query = query.AsNoTracking();

            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            return query.FirstOrDefault(e => e.Id != null && e.Id.Equals(id));
        }

        // implementação da busca com filtro
        public IList<TEntity> Select(
            Expression<Func<TEntity, bool>> predicate,
            bool tracking = true,
            IList<string>? includes = null
        )
        {
            IQueryable<TEntity> query = _dbSet;

            if (!tracking)
                query = query.AsNoTracking();

            if (includes != null)
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            query = query.Where(predicate);

            return query.ToList();
        }
    }
}
