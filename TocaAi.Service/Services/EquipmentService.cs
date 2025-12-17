using System.ComponentModel.DataAnnotations;
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

        public void UpdateEquipment(Guid id, Equipment eqInput)
        {
            var equipment = _baseRepository.SelectById(id);

            if (equipment == null)
            {
                throw new Exception("Equipamento não encontrado.");
            }

            // atualiza os dados na entidade
            equipment.UpdateDetails(
                eqInput.Name,
                eqInput.Brand,
                eqInput.Model,
                eqInput.Description,
                eqInput.DailyRate,
                eqInput.Type,
                eqInput.ConservationStatus,
                eqInput.Notes
            );

            // valida com o validator
            var validator = new EquipmentValidator();
            var validationResult = validator.Validate(equipment);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors[0].ErrorMessage);
            }

            // salva
            _baseRepository.Update(equipment);
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
