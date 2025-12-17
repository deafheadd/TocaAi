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
        }

        // atualizar informações
        public void UpdateDetails(string fullName, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name must not be empty.", nameof(fullName));

            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number must not be empty.", nameof(phoneNumber));

            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        // atualizar endereço
        public void UpdateAddress(Address address)
        {
            Address = address ?? throw new ArgumentNullException(nameof(address), "Address cannot be null");
        }
    }
}
