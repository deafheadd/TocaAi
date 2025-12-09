using TocaAi.Domain.Entities;
using TocaAi.Domain.Validators;
using TocaAi.Domain.ValueObjects;

namespace TocaAi.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void CreateValidCustomer()
        {
            var address = new Address(
                "Rua A",
                "123",
                "Bairro B",
                "Birigui",
                "SP",
                "12345678"
            );

            var customer = new Customer(
                Guid.NewGuid(),
                "Gustavo",
                "gusta.azv18@gmail.com",
                "40043323898",
                "18997253124",
                address,
                DateTime.UtcNow
            );

            var validator = new CustomerValidator();
            var result = validator.Validate(customer);

            Assert.IsTrue(result.IsValid);
        }
        
        [TestMethod]
        public void CreateValidEquipment()
        {
            var equipment = new Equipment(
                Guid.NewGuid(),
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
            var customerId = Guid.NewGuid();
            var equipmentId = Guid.NewGuid();

            var rental = new Rental(
                Guid.NewGuid(),
                customerId,
                equipmentId,
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
