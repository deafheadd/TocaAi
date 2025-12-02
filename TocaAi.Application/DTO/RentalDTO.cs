using TocaAi.Domain.Entities;

public record RentalDTO(
    Guid CustomerId,
    Customer Customer,
    Guid EquipmentId,
    Equipment Equipment,
    DateTime PickupDate,
    DateTime ExpectedReturnDate,
    DateTime? ActualReturnDate,
    decimal DailyRate,
    decimal TotalAmount,
    decimal LateFee,
    RentalStatus RentalStatus,
    string? Notes
);

