using TocaAi.Domain.Base;
using TocaAi.Domain.ValueObjects;

namespace TocaAi.Domain.Entities
{
    public class Person : BaseEntity<Guid>
    {
        public string FullName { get; private set; }
        public string DocumentNumber { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public DateTime RegisterDate { get; private set; }

        // alugueis
        public ICollection<Rental> Rentals { get; private set; }

        // equipamentos
        public ICollection<Equipment> EquipmentOwned { get; private set; }

        // login
        public Guid UserAccountId { get; private set; } // fk

        protected Person()
        {

        }

        public Person(Guid id, string fullName, string documentNumber, string phoneNumber, Address address, DateTime registerDate) : base(id)
        {
            FullName = fullName;
            DocumentNumber = documentNumber;
            PhoneNumber = phoneNumber;
            Address = address;
            RegisterDate = registerDate;
            Rentals = new List<Rental>();
            EquipmentOwned = new List<Equipment>();
        }
    }
}
