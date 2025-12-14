using TocaAi.Domain.Base;

namespace TocaAi.Domain.Entities
{
    public class UserAccount : BaseEntity<Guid>
    {
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public UserRole Role { get; private set; }
        public Person Person { get; private set; }
        public bool isActive { get; private set; }

        protected UserAccount()
        {

        }

        public UserAccount(Guid id, string email, string passwordHash, UserRole role, Person person) : base(id)
        {
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
            Person = person;
            isActive = true;
        }
    }
}
