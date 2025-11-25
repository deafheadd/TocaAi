using TocaAi.Domain.Base;

namespace TocaAi.Domain.Entities
{
    public class Equipment : BaseEntity<Guid>
    {
        public string Name { get; private set; }
        public EquipmentType Type { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string SerialNumber { get; private set; }
        public string? Description { get; private set; }
        public decimal DailyRate { get; private set; }
        public DateTime AcquisitionDate { get; private set; }
        public ConservationStatus ConservationStatus { get; private set; }
        public string? Notes { get; private set; }
        public bool IsAvailable { get; private set; }

        protected Equipment()
        {
            
        }

        public Equipment(Guid id, string name, EquipmentType type, string brand, string model, string serialNumber, string? description, decimal dailyRate, DateTime acquisitionDate, ConservationStatus conservationStatus, string? observations, bool isAvailable) : base(id)
        {
            Name = name;
            Type = type;
            Brand = brand;
            Model = model;
            SerialNumber = serialNumber;
            Description = description;
            DailyRate = dailyRate;
            AcquisitionDate = acquisitionDate;
            ConservationStatus = conservationStatus;
            Observations = observations;
            IsAvailable = true;
        }
    }
}
