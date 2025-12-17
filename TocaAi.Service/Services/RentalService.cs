using AutoMapper;
using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;
using TocaAi.Service.Interfaces;

namespace TocaAi.Service.Services
{
    public class RentalService : BaseService<Rental, Guid>, IRentalService
    {
        private readonly IBaseRepository<Equipment, Guid> _equipmentRepository;

        public RentalService(
            IBaseRepository<Rental, Guid> baseRepository,
            IBaseRepository<Equipment, Guid> equipmentRepository,
            IMapper mapper): base(baseRepository, mapper)
        {
            _equipmentRepository = equipmentRepository;
        }

        public void Rent(Guid equipmentId, Guid customerId, DateTime expectedReturnDate, PaymentMethod paymentMethod, string? notes)
        {
            // buscar equipamento para conseguir a taxa diária atual
            var equipment = _equipmentRepository.SelectById(equipmentId);

            if (equipment == null)
                throw new KeyNotFoundException("Equipamento não encontrado.");

            if (!equipment.IsAvailable)
                throw new InvalidOperationException("Equipamento já está alugado ou indisponível.");

            var pickupDate = DateTime.Now;
            // mudança de lógica do aplicativo
            // lateFeeRate vai ter q ser implementado em equipamento
            // temp fixo
            var lateFeeRate = 0.10m; // 10% de multa por dia de atraso

            var rental = new Rental(
                Guid.NewGuid(),
                customerId,
                equipmentId,
                pickupDate,
                expectedReturnDate,
                equipment.DailyRate,
                lateFeeRate,
                paymentMethod,
                notes
            );

            // calcular valor inicial
            rental.CalculeAmounts();

            // inserir
            _baseRepository.Insert(rental);

            // atualizar status
            equipment.MarkAsUnavaiable();
            _equipmentRepository.Update(equipment);
        }
        public IList<Rental> GetMyRentals(Guid customerId)
        {
            // retornar aluguéis filtrados pelo usuário logado
            return _baseRepository.Select(r => r.UserAccountId == customerId);
        }
    }
}
