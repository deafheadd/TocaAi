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
        
        public void Announce(EquipmentInputModel inputModel, Guid ownerId)
        {
            var equipmentEntity = _mapper.Map<Equipment>(inputModel);

            equipmentEntity.SetOwnerId(ownerId);

            // validação
            Validate(equipmentEntity, new EquipmentValidator());

            // chama o repositório
            _baseRepository.Insert(equipmentEntity);
        }
        public IList<EquipmentOutputModel> GetByOwnerId(Guid ownerId)
        {
            var equipmentList = _baseRepository.Select(e => e.OwnerId == ownerId);

            return _mapper.Map<IList<EquipmentOutputModel>>(equipmentList);
        }

        public IList<EquipmentOutputModel> GetAllAvailable()
        {
            var allEquipmentList = _baseRepository.Select();

            return _mapper.Map<IList<EquipmentOutputModel>>(allEquipmentList);
        }

        public void Delete(Guid equipmentId, Guid ownerId)
        {
            var equipment = _baseRepository.SelectById(equipmentId);

            // valida existência
            if (equipment == null)
            {
                throw new KeyNotFoundException("Equipamento não encontrado.");
            }

            // valida autorização
            if (equipment.OwnerId != ownerId)
            {
                throw new UnauthorizedAccessException("Você não tem permissão para excluir este anúncio.");
            }

            _baseRepository.Delete(equipmentId);
        }
    }
}
