namespace TocaAi.App.ViewModels
{
    public record RentalModel(
        Guid Id,
        Guid UserAccountId,
        Guid EquipmentId,
        DateTime PickupDate,
        DateTime ExpectedReturnDate,
        decimal DailyRate,
        decimal TotalAmount,
        decimal LateFeeRate,
        decimal LateFee,
        PaymentMethod PaymentMethod,
        RentalStatus RentalStatus,
        string? Notes
    );
}
