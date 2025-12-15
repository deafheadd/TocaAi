using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Interfaces
{
    public interface IUserAccountRepository : IBaseRepository<UserAccount, Guid>
    {
        UserAccount? GetByEmail(string email);
        UserAccount? GetWithRentals(Guid personId);
        bool EmailExists(string email);
    }
}
