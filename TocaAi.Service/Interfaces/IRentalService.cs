using TocaAi.Domain.Entities;

namespace TocaAi.Service.Interfaces
{
    public interface IRentalService
    {
        // realiza aluguel
        void Rent(Guid equipmentId, Guid customerId, DateTime expectedReturnDate, PaymentMethod paymentMethod, string? notes);
        // buscar aluguéis do usuário logado
        IList<Rental> GetMyRentals(Guid customerId);
    }
}
