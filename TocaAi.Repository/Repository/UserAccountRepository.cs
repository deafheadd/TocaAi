using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Interfaces;
using TocaAi.Repository.Context;

namespace TocaAi.Repository.Repository
{
    public class UserAccountRepository(TocaAiDbContext context) :
        BaseRepository<UserAccount, Guid>(context), IUserAccountRepository
    {
        public bool EmailExists(string email)
        {
            return _dbSet.Any(u => u.Email == email);
        }

        public UserAccount? GetByEmail(string email)
        {
            return _dbSet
                .Include(u => u.Person)
                    .ThenInclude(p=>p.Address)
                .FirstOrDefault(u => u.Email == email);
        }

        public UserAccount? GetWithRentals(Guid personId)
        {
            return _dbSet.Include(p => p.Rentals).FirstOrDefault(p => p.Id == personId);
        }
    }
}
