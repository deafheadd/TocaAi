using TocaAi.Domain.Entities;
using TocaAi.Domain.ValueObjects;

namespace TocaAi.Service.Interfaces
{
    public interface IUserService : IBaseService<Person, Guid>
    {
        void UpdateFullProfile(Guid personId, string fullName, string phoneNumber, Address newAddress);
    }
}
