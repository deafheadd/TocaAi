using TocaAi.Domain.Entities;
using TocaAi.Service.DTOs;

namespace TocaAi.Service.Interfaces
{
    public interface IEquipmentService : IBaseService<Equipment, Guid>
    {
        // resolver lógica de OwnerId
        void Announce(EquipmentInputModel inputModel, Guid ownerId);
        // buscar a lista de anúncios por OwnerId
        IList<EquipmentOutputModel> GetByOwnerId(Guid ownerId);
        // buscar todos os equipamentos disponíveis
        IList<EquipmentOutputModel> GetAllAvailable();
        // atualizar um equipamento
        void UpdateEquipment(Guid id, Equipment eqInput);
        // deletar um equipamento
        void Delete(Guid equipmentId, Guid ownerId);
    }
}
