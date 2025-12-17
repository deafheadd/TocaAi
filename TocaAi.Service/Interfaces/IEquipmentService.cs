using TocaAi.Service.DTOs;

namespace TocaAi.Service.Interfaces
{
    public interface IEquipmentService
    {
        // resolver lógica de OwnerId
        void Announce(EquipmentInputModel inputModel, Guid ownerId);
        // buscar a lista de anúncios por OwnerId
        IList<EquipmentOutputModel> GetByOwnerId(Guid ownerId);
        // buscar todos os equipamentos disponíveis
        IList<EquipmentOutputModel> GetAllAvailable();
        // deletar um equipamento
        void Delete(Guid equipmentId, Guid ownerId);
    }
}
