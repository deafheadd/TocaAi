using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Interfaces;
using TocaAi.Repository.Context;

namespace TocaAi.Repository.Repository
{
    public class PersonRepository(TocaAiDbContext context) :
        BaseRepository<Person, Guid>(context), IPersonRepository
    {
        public IEnumerable<Person> SearchByName(string fullName)
        {
            return _dbSet.Where(p => p.FullName == fullName).ToList();
        }
    }
}
