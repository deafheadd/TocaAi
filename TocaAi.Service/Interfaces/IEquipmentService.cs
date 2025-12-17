using TocaAi.Service.DTOs;

namespace TocaAi.Service.Interfaces
{
    public interface IEquipmentService
    {
        void Announce(EquipmentInputModel inputModel, Guid ownerId);
    }
}
