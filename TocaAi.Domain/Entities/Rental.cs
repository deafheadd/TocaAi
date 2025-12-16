using TocaAi.Domain.Base;

namespace TocaAi.Domain.Entities
{
    public class Rental : BaseEntity<Guid>
    {
        public Guid UserAccountId { get; private set; }
        public UserAccount UserAccount { get; private set; }
        public Guid EquipmentId { get; private set; }
        public Equipment Equipment { get; private set; }

        public DateTime PickupDate { get; private set; }
        public DateTime ExpectedReturnDate { get; private set; }
        public DateTime? ActualReturnDate { get; private set; }
        public decimal DailyRate { get; private set; }
        public decimal TotalAmount { get; private set; }
        public decimal LateFeeRate { get; private set; }
        public decimal LateFee { get; private set; }
        public RentalStatus RentalStatus { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public string? Notes { get; private set; }

        protected Rental()
        {

        }

        public Rental(Guid id, Guid userAccountId, Guid equipmentId, DateTime pickupDate, DateTime expectedReturnDate, decimal dailyRate, decimal lateFeeRate, PaymentMethod paymentMethod, string? notes) : base(id)
        {
            UserAccountId = userAccountId;
            EquipmentId = equipmentId;
            PickupDate = pickupDate;
            ExpectedReturnDate = expectedReturnDate;
            DailyRate = dailyRate;
            LateFeeRate = lateFeeRate;
            PaymentMethod = paymentMethod;
            Notes = notes;
            RentalStatus = RentalStatus.Open;
            TotalAmount = 0;
            LateFee = 0;
        }

        // calcula o total do aluguel + multa, se houver
        public void CalculeAmounts()
        {
            // calcula o total de dias da locação (somente dias inteiros)
            var rentalDays = (ExpectedReturnDate - PickupDate).Days;
            if (rentalDays == 0) rentalDays = 1; // garante no mínimo 1 dia
            TotalAmount = (decimal)rentalDays * DailyRate;

            // cálculo de multa se houver atraso
            if (ActualReturnDate.HasValue && ActualReturnDate.Value > ExpectedReturnDate)
            {
                // pega apenas dias inteiros de atraso
                var lateDays = (ActualReturnDate.Value - ExpectedReturnDate).Days;
                LateFee = (decimal)lateDays * DailyRate * LateFeeRate;
            }
            else
            {
                LateFee = 0;
            }

            // incluir multa no total final
            TotalAmount += LateFee;
        }

        // registrar devolução
        public void CloseRental(DateTime returnDate)
        {
            ActualReturnDate = returnDate;
            RentalStatus = RentalStatus.Closed;
            CalculeAmounts();
        }
    }
}
