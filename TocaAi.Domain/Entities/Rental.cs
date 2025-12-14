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
        public decimal LateFee { get; private set; }
        public RentalStatus RentalStatus { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public string? Notes { get; private set; }

        protected Rental()
        {
            
        }

        public Rental(Guid id, Guid userAccountId, Guid equipmentId, DateTime pickupDate, DateTime expectedReturnDate, decimal dailyRate, string? notes) : base(id)
        {
            UserAccountId = userAccountId;
            EquipmentId = equipmentId;
            PickupDate = pickupDate;
            ExpectedReturnDate = expectedReturnDate;
            DailyRate = dailyRate;
            Notes = notes;
            RentalStatus = RentalStatus.Open;
            TotalAmount = 0;
            LateFee = 0;
        }
    }
}
