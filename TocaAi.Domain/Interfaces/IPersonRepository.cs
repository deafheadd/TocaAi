using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Interfaces
{
    public interface IPersonRepository : IBaseRepository<Person, Guid>
    {
        IEnumerable<Person> SearchByName(string fullName);
    }
}
