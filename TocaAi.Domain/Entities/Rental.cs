using TocaAi.Domain.Base;
using TocaAi.Domain.Enums;

namespace TocaAi.Domain.Entities
{
    public class Rental : BaseEntity<Guid>
    {
        public DateTime data { get; private set; }
        public DateTime ExpectedReturnDate { get; private set; }
        public DateTime ActualReturnDate { get; private set; }
        public decimal DailyRate { get; private set; }
        public decimal TotalAmount { get; private set; }
        public RentalStatus RentalStatus { get; private set; }
        public decimal LateFee { get; private set; }
        public string? Notes { get; private set; }
    }
}
