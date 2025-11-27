namespace TocaAi.Domain.Base
{
    public interface IBaseEntity<TId>
    {
        TId Id { get; }
    }
}
