using TocaAi.Domain.Base;

namespace TocaAi.Domain.Entities
{
    public class Customer : BaseEntity<Guid>
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public string Address { get; private set; }
        public DateTime RegisterDate { get; private set; }
        public bool IsActive { get; private set; }

        protected Customer()
        {
            
        }

        public Customer(Guid id, string fullName, string email, string cpf, string address, DateTime registerDate) : base(id)
        {
            FullName = fullName;
            Email = email;
            CPF = cpf;
            Address = address;
            RegisterDate = registerDate;
            IsActive = true;
        }
    }
}
