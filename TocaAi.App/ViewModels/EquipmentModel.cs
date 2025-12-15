namespace TocaAi.App.ViewModels
{
    public record EquipmentModel(
        Guid Id,
        Guid OwnerId,
        string OwnerEmail,
        string Name,
        EquipmentType Type,
        string Brand,
        string Model,
        string SerialNumber,
        string Description,
        decimal DailyRate,
        DateTime AcquisitionDate,
        ConservationStatus ConservationStatus,
        string? Notes,
        bool IsAvailable
    );
}
