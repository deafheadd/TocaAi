using TocaAi.Domain.Base;

namespace TocaAi.Domain.Entities
{
    public class UserAccount : BaseEntity<Guid>
    {
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public UserRole Role { get; private set; }
        public Guid? CustomerId { get; private set; }
        public Customer? Customer { get; private set; }

        protected UserAccount()
        {

        }

        public UserAccount(Guid id, string email, string passwordHash, UserRole role) : base(id)
        {
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
        }
    }
}
