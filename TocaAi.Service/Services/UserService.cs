using AutoMapper;
using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;
using TocaAi.Domain.ValueObjects;
using TocaAi.Service.Interfaces;

namespace TocaAi.Service.Services
{
    public class UserService : BaseService<Person, Guid>, IUserService
    {
        private readonly IBaseRepository<Person, Guid> _personRepository;

        public UserService(IBaseRepository<Person, Guid> personRepository, IMapper mapper)
            : base(personRepository, mapper)
        {
            _personRepository = personRepository;
        }

        public void UpdateFullProfile(Guid personId, string fullName, string phoneNumber, Address newAddress)
        {
            // buscar pessoa no banco
            var person = _personRepository.SelectById(personId);

            if (person == null)
                throw new KeyNotFoundException("Perfil não encontrado no sistema.");

            // atualizar os dados
            person.UpdateDetails(fullName, phoneNumber);
            person.UpdateAddress(newAddress);

            // salvar
            _personRepository.Update(person);
        }
    }
}
