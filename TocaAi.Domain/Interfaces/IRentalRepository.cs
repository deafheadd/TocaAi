using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Interfaces
{
    public interface IRentalRepository : IBaseRepository<Rental, Guid>
    {
        ICollection<Rental> GetRentalsByCustomer(Guid customerId);
        ICollection<Rental> GetRentalsByEquipment(Guid equipmentId);
        ICollection<Rental> GetOpenRentals(Guid rentalId);
        bool RentalExists(Guid rentalId);
    }
}
