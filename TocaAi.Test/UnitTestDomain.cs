using TocaAi.Domain.Entities;
using TocaAi.Domain.Validators;
using TocaAi.Domain.ValueObjects;

namespace TocaAi.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void CreateValidPerson()
        {
            var address = new Address(
                "Rua A",
                "123",
                "Bairro B",
                "Birigui",
                "SP",
                "12345678"
            );

            var person = new Person(
                Guid.NewGuid(),
                "Gustavo Amaral Azevedo",
                "12345678900",
                "18992383234",
                address,
                DateTime.UtcNow
            );

            var validator = new PersonValidator();
            var result = validator.Validate(person);

            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void CreateValidUserAccount()
        {
            // cria Person
            var person = new Person(
                Guid.NewGuid(),
                "Gustavo Amaral Azevedo",
                "12345678900",
                "18992383234",
                new Address(
                "Rua A",
                "123",
                "Bairro B",
                "Birigui",
                "SP",
                "12345678"),
                DateTime.UtcNow
            );

            // cria UserAccount vinculado a Person
            var userAccount = new UserAccount(
                Guid.NewGuid(),
                "gustavo@gmail.com",
                "senha123",
                UserRole.Customer,
                person
            );

            var validator = new UserAccountValidator();
            var result = validator.Validate(userAccount);

            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void CreateValidEquipment()
        {
            // cria Person e dono (UserAccount)
            var person = new Person(
                Guid.NewGuid(),
                "Gustavo Amaral Azevedo",
                "12345678900",
                "18992383234",
                new Address(
                "Rua A",
                "123",
                "Bairro B",
                "Birigui",
                "SP",
                "12345678"),
                DateTime.UtcNow
            );

            var owner = new UserAccount(
                Guid.NewGuid(),
                "gustavo@gmail.com",
                "senha123",
                UserRole.Seller,
                person
            );

            // cria Equipment com dono

            var equipment = new Equipment(
                Guid.NewGuid(),
                owner,
                "Guitarra Fender Stratocaster",
                EquipmentType.Guitar,
                "Fender",
                "Stratocaster",
                "SN987654321",
                "Guitarra elétrica",
                200.00m,
                new DateTime(2022, 4, 18),
                ConservationStatus.Used,
                null
            );

            var validator = new EquipmentValidator();
            var result = validator.Validate(equipment);

            Assert.IsTrue(result.IsValid);
        }

        [TestMethod]
        public void CreateValidRental()
        {
            // cria Person1 e UserAccount
            var person1 = new Person(
                Guid.NewGuid(),
                "Gustavo Amaral Azevedo",
                "12345678900",
                "18992383234",
                new Address(
                "Rua A",
                "123",
                "Bairro B",
                "Birigui",
                "SP",
                "12345678"),
                DateTime.UtcNow
            );

            var customer = new UserAccount(
                Guid.NewGuid(),
                "gustavo@gmail.com",
                "senha123",
                UserRole.Customer,
                person1
            );

            // cria Person2 e Owner
            var person2 = new Person(
                Guid.NewGuid(),
                "João da Silva",
                "98765432100",
                "18994367237",
                new Address(
                "Rua B",
                "321",
                "Bairro C",
                "Birigui",
                "SP",
                "87654321"),
                DateTime.UtcNow
            );

            var seller = new UserAccount(
                Guid.NewGuid(),
                "gustavo@gmail.com",
                "senha123",
                UserRole.Customer,
                person2
            );

            // cria Equipment do vendedor
            var equipment = new Equipment(
                Guid.NewGuid(),
                seller,
                "Guitarra Fender Stratocaster",
                EquipmentType.Guitar,
                "Fender",
                "Stratocaster",
                "SN987654321",
                "Guitarra elétrica",
                200.00m,
                new DateTime(2022, 4, 18),
                ConservationStatus.Used,
                null
            );

            // cria Rental vinculado a UserAccount e Equipment
            var rental = new Rental(
                Guid.NewGuid(),
                customer.Id,
                seller.Id,
                new DateTime(2025, 12, 10),
                new DateTime(2025, 12, 15),
                150.00m,
                "Aluguel para evento"
            );

            var validator = new RentalValidator();
            var result = validator.Validate(rental);

            Assert.IsTrue(result.IsValid);
        }
    }
}
