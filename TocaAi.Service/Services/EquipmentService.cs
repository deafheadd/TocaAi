using AutoMapper;
using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Validators;
using TocaAi.Service.DTOs;
using TocaAi.Service.Interfaces;

namespace TocaAi.Service.Services
{
    public class EquipmentService : BaseService<Equipment, Guid>, IEquipmentService
    {
        public EquipmentService(IBaseRepository<Equipment, Guid> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
        }

        // método para resolver lógica de OwnerId
        public void Announce(EquipmentInputModel inputModel, Guid ownerId)
        {
            var equipmentEntity = _mapper.Map<Equipment>(inputModel);

            equipmentEntity.SetOwnerId(ownerId);

            // validação
            Validate(equipmentEntity, new EquipmentValidator());

            // chama o repositório
            _baseRepository.Insert(equipmentEntity);
        }
    }
}
