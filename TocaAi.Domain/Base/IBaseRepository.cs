namespace TocaAi.Domain.Base
{
    public interface IBaseRepository<TEntity, TId> where TEntity : IBaseEntity<TId>
    {
        void ClearChangeTracker();
        void AttachObject(object obj);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        IList<TEntity> Select(List<string>? includes = null);
        TEntity? SelectById(TId id, IList<string>? includes = null);
    }
}
