namespace TocaAi.Service.DTOs
{
    public record EquipmentInputModel(
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
        bool IsAvailable = true
    );
}
