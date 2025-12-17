using TocaAi.Service.DTOs;

namespace TocaAi.Service.Interfaces
{
    public interface IEquipmentService
    {
        // método para resolver lógica de OwnerId
        void Announce(EquipmentInputModel inputModel, Guid ownerId);
        // método para buscar a lista de anúncios por OwnerId
        IList<EquipmentOutputModel> GetByOwnerId(Guid ownerId);
        // método para buscar todos os equipamentos disponíveis
        IList<EquipmentOutputModel> GetAllAvailable();
        // método pra deletar um equipamento
        void Delete(Guid equipmentId, Guid ownerId);
    }
}
