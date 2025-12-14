using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Interfaces
{
    public interface IUserAccountRepository : IBaseRepository<UserAccount, Guid>
    {
        UserAccount? GetByEmail(string email);
        bool EmailExists(string email);
    }
}
