using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Interfaces;
using TocaAi.Repository.Context;

namespace TocaAi.Repository.Repository
{
    public class EquipmentRepository(TocaAiDbContext context) :
        BaseRepository<Equipment, Guid>(context), IEquipmentRepository
    {
        public bool EquipmentExists(Guid equipmentId)
        {
            return _dbSet.Any(e => e.Id == equipmentId);
        }

        public IEnumerable<Equipment> GetAvailable()
        {
            return _dbSet.Where(e => e.IsAvailable).ToList();
        }

        public IEnumerable<Equipment> SearchByName(string name)
        {
            return _dbSet.Where(e => e.Name == name).ToList();
        }
    }
}
