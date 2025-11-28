using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Interfaces;
using TocaAi.Infrastructure.Context;

namespace TocaAi.Infrastructure.Repository
{
    public class RentalRepository(TocaAiDbContext context) :
        BaseRepository<Rental, Guid>(context), IRentalRepository
    {
        public ICollection<Rental> GetOpenRentals()
        {
            return _dbSet.Where(r => r.RentalStatus == RentalStatus.Open).ToList();
        }

        public ICollection<Rental> GetRentalsByCustomer(Guid customerId)
        {
            return _dbSet.Where(r => r.CustomerId == customerId).ToList();
        }

        public ICollection<Rental> GetRentalsByEquipment(Guid equipmentId)
        {
            return _dbSet.Where(r => r.EquipmentId == equipmentId).ToList();
        }

        public bool RentalExists(Guid rentalId)
        {
            return _dbSet.Any(r => r.Id == rentalId);
        }
    }
}
