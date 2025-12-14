using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Interfaces;
using TocaAi.Repository.Context;

namespace TocaAi.Repository.Repository
{
    public class CustomerRepository(TocaAiDbContext context) :
        BaseRepository<Customer, Guid>(context), ICustomerRepository
    {
        public Customer? GetWithRentals(Guid customerId)
        {
            return _dbSet.Include(c => c.Rentals).FirstOrDefault(c => c.Id == customerId);
        }

        public IEnumerable<Customer> SearchByName(string fullName)
        {
            return _dbSet.Where(c => c.FullName == fullName).ToList();
        }
    }
}
