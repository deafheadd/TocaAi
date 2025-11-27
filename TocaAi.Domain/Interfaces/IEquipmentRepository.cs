using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;

namespace TocaAi.Domain.Interfaces
{
    public interface IEquipmentRepository : IBaseRepository<Equipment, Guid>
    {
        IEnumerable<Equipment> GetAvailable();
        IEnumerable<Equipment> SearchByName(string name);
        bool EquipmentExists(Guid equipmentId);
    }
}
