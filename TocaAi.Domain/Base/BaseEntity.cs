namespace TocaAi.Domain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity<TId>
    {
        protected BaseEntity()
        {
            
        }

        protected BaseEntity(TId id)
        {
            Id = id;
        }

        public TId Id { get; private set; }
    }
}
