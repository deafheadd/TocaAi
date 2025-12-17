using System;
using System.Linq.Expressions;

namespace TocaAi.Domain.Base
{
    public interface IBaseRepository<TEntity, TId> where TEntity : IBaseEntity<TId>
    {
        void ClearChangeTracker();
        void AttachObject(object obj);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        IList<TEntity> Select(bool tracking = true, IList<string>? includes = null);
        TEntity? SelectById(TId id, bool tracking = true, IList<string>? includes = null);

        // select para incluir filtro (predicate)
        IList<TEntity> Select(Expression<Func<TEntity, bool>> predicate, bool tracking = true, IList<string>? includes = null);
    }
}
