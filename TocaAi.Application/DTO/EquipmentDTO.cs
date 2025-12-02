using TocaAi.Domain.Entities;

public record EquipmentDTO(
    string Name,
    EquipmentType Type,
    string Brand,
    string Model,
    string SerialNumber,
    string? Description,
    decimal DailyRate,
    DateTime AcquisitionDate,
    ConservationStatus ConservationStatus,
    string? Notes,
    bool IsAvailable
);