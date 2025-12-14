using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Interfaces
{
    public interface ICustomerRepository : IBaseRepository<Customer, Guid>
    {
        IEnumerable<Customer> SearchByName(string fullName);
        Customer? GetWithRentals(Guid customerId);
    }
}
