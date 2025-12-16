using Microsoft.EntityFrameworkCore;
using TocaAi.Domain.Entities;
using TocaAi.Domain.ValueObjects;
using TocaAi.Repository.Context;
using TocaAi.Repository.Repository;

namespace TocaAi.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        private TocaAiDbContext GetInMemoryContext()
        {
            // usa banco em memória
            var options = new DbContextOptionsBuilder<TocaAiDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // limpa o DB a cada teste
                .Options;

            return new TocaAiDbContext(options);
        }

        [TestMethod]
        public void Test_InsertUserAccount()
        {
            using var context = GetInMemoryContext();

            var userRepo = new BaseRepository<UserAccount, Guid>(context);

            var person = new Person(
                Guid.NewGuid(),
                "João da Silva",
                "12345678900",
                "11999999999",
                new Address(
                    "Rua X",
                    "123",
                    "Bairro Y",
                    "Cidade Z",
                    "SP",
                    "01234-567",
                    ""
                ),
                DateTime.Now
            );

            var user = new UserAccount(
                Guid.NewGuid(),
                "joao",
                "teste@gmail.com",
                "123456",
                UserRole.Customer,
                person
            );

            userRepo.Insert(user);
            context.SaveChanges();

            Console.WriteLine($"Usuário salvo com ID: {user.Id}");

            Assert.IsTrue(user.Id != Guid.Empty, "ID deveria ter sido gerado");
        }

        // teste de métodos específicos
        [TestMethod]
        public void Test_EquipmentRepository_Methods()
        {
            using var context = GetInMemoryContext();

            var repo = new EquipmentRepository(context);

            var ownerId = Guid.NewGuid();

            var eq1 = new Equipment(
                Guid.NewGuid(),
                ownerId,
                "Guitarra",
                EquipmentType.Guitar,
                "Fender",
                "Stratocaster",
                "SN123456789",
                "",
                100.0m,
                DateTime.Now,
                ConservationStatus.New,
                null
            );

            var eq2 = new Equipment(
                Guid.NewGuid(),
                ownerId,
                "Baixo",
                EquipmentType.Bass,
                "Ibanez",
                "SR",
                "SN234567890",
                "",
                120.0m,
                DateTime.Now,
                ConservationStatus.New,
                null
            );

            // marca o segundo equipamento como não disponível
            eq2.MarkAsUnavaiable();

            repo.Insert(eq1);
            repo.Insert(eq2);
            context.SaveChanges();

            // teste EquipmentExists
            Assert.IsTrue(repo.EquipmentExists(eq1.Id));
            Assert.IsFalse(repo.EquipmentExists(Guid.NewGuid()));

            // teste GetAvailable
            var available = repo.GetAvailable().ToList(); // retorna todos equipamentos com IsAvaiable = true
            Assert.AreEqual(1, available.Count); // eq1
            Assert.IsTrue(available.Any(e => e.Name == "Guitarra"));

            // teste SearchByName
            var newSearch = repo.SearchByName("Guitarra").ToList(); // procura equipamento com nome "Guitarra"
            Assert.AreEqual(1, newSearch.Count); // eq1
            Assert.AreEqual(eq1.Id, newSearch.First().Id);
        }
    }
}