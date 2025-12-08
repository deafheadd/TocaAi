using TocaAi.Domain.Base;
using TocaAi.Domain.ValueObjects;

namespace TocaAi.Domain.Entities
{
    public class Customer : BaseEntity<Guid>
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string DocumentNumber { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public DateTime RegisterDate { get; private set; }
        public bool IsActive { get; private set; }
        public ICollection<Rental> Rentals { get; private set; }

        protected Customer()
        {
            
        }

        public Customer(Guid id, string fullName, string email, string documentNumber, string phoneNumber, Address address, DateTime registerDate) : base(id)
        {
            FullName = fullName;
            Email = email;
            DocumentNumber = documentNumber;
            PhoneNumber = phoneNumber;
            Address = address;
            RegisterDate = registerDate;
            IsActive = true;
            Rentals = new List<Rental>();
        }
    }
}
