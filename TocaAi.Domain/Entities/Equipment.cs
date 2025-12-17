using TocaAi.Domain.Base;

namespace TocaAi.Domain.Entities
{
    public class Equipment : BaseEntity<Guid>
    {
        public Guid OwnerId { get; private set; }
        public UserAccount Owner { get; private set; }

        public string Name { get; private set; }
        public EquipmentType Type { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string SerialNumber { get; private set; }
        public string Description { get; private set; }
        public decimal DailyRate { get; private set; }
        public DateTime AcquisitionDate { get; private set; }
        public ConservationStatus ConservationStatus { get; private set; }
        public string? Notes { get; private set; }
        public bool IsAvailable { get; private set; }

        protected Equipment()
        {

        }

        public Equipment(Guid id, Guid ownerId, string name, EquipmentType type, string brand, string model, string serialNumber, string description, decimal dailyRate, DateTime acquisitionDate, ConservationStatus conservationStatus, string? notes) : base(id)
        {
            OwnerId = ownerId;
            Name = name;
            Type = type;
            Brand = brand;
            Model = model;
            SerialNumber = serialNumber;
            Description = description;
            DailyRate = dailyRate;
            AcquisitionDate = acquisitionDate;
            ConservationStatus = conservationStatus;
            Notes = notes;
            IsAvailable = true;
        }

        // altera disponibilidade
        public void MarkAsUnavaiable() => IsAvailable = false;
        public void MarkAsAvaiable() => IsAvailable = true;

        // permite ao serviço definir o ID
        public void SetOwnerId(Guid ownerId)
        {
            if (ownerId == Guid.Empty)
                throw new ArgumentException("Owner id can not be null.", nameof(ownerId));

            this.OwnerId = ownerId;
        }
    }
}
