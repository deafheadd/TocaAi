using System.Text.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Validators;
using TocaAi.Domain.ValueObjects;
using TocaAi.Repository.Context;
using TocaAi.Repository.Repository;
using TocaAi.Service.Interfaces;
using TocaAi.Service.Services;

namespace TocaAi.Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();

            //var connectionString = "Server=GUSTAG15\\SQLEXPRESS;Database=TocaAiDB;User Id=gustavo;Password=1875;TrustServerCertificate=True;";

            /*
            services.AddDbContext<TocaAiDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            */

            // usa banco em memória
            services.AddDbContext<TocaAiDbContext>(options =>
            {
                options.UseInMemoryDatabase("TestDb");
            });

            // UserAccount
            services.AddScoped<IBaseRepository<UserAccount, Guid>, BaseRepository<UserAccount, Guid>>();
            services.AddScoped<IBaseService<UserAccount, Guid>, BaseService<UserAccount, Guid>>();

            // Equipment
            services.AddScoped<IBaseRepository<Equipment, Guid>, BaseRepository<Equipment, Guid>>();
            services.AddScoped<IBaseService<Equipment, Guid>, BaseService<Equipment, Guid>>();

            // Rental
            services.AddScoped<IBaseRepository<Rental, Guid>, BaseRepository<Rental, Guid>>();
            services.AddScoped<IBaseService<Rental, Guid>, BaseService<Rental, Guid>>();


            services.AddAutoMapper(config =>
            {
                config.CreateMap<UserAccount, UserAccount>().ReverseMap();
                config.CreateMap<Equipment, Equipment>().ReverseMap();
                config.CreateMap<Rental, Rental>().ReverseMap();
            });

            services.AddLogging();

            return services.BuildServiceProvider();
        }
        
        [TestMethod]
        public void TestFullFlow_UserEquipmentRental()
        {
            var serviceProvider = ConfigureServices();

            var userService = serviceProvider.GetService<IBaseService<UserAccount, Guid>>();
            var equipmentService = serviceProvider.GetService<IBaseService<Equipment, Guid>>();
            var rentalService = serviceProvider.GetService<IBaseService<Rental, Guid>>();

            Assert.IsNotNull(userService, "Serviço de usuário inválido.");
            Assert.IsNotNull(equipmentService, "Serviço de equipamento inválido.");
            Assert.IsNotNull(rentalService, "Serviço de aluguel inválido.");

            // criação de Person
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

            // criação de UserAccount
            var user = new UserAccount(
                Guid.NewGuid(),
                "joao",
                "teste@gmail.com",
                "123456",
                UserRole.Customer,
                person
            );

            var insertedUser = userService.Add<UserAccount, UserAccount, UserAccountValidator>(user);

            // criação de Equipment
            var equipment = new Equipment(
                Guid.NewGuid(),
                insertedUser.Id,
                "Amplificador Marshall",
                EquipmentType.Amplifier,
                "Marshall",
                "JCM 800",
                "SN123456789",
                "Amplificador profissional",
                300.0m,
                new DateTime(2024, 5, 23),
                ConservationStatus.Used,
                null
            );

            var insertedEquipment = equipmentService.Add<Equipment, Equipment, EquipmentValidator>(equipment);

            // criação de Rental
            var rental = new Rental(
                Guid.NewGuid(),
                insertedUser.Id,
                insertedEquipment.Id,
                DateTime.Now,
                DateTime.Now.AddDays(3),
                insertedEquipment.DailyRate,
                0.5m,
                PaymentMethod.CreditCard,
                null
            );

            var insertedRental = rentalService.Add<Rental, Rental, RentalValidator>(rental);

            // fechar locação
            // simular devolução com atraso
            insertedRental.CloseRental(DateTime.Now.AddDays(5)); // 2 dias de atraso

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve
            };
            Console.WriteLine("User:");
            Console.WriteLine(JsonSerializer.Serialize(insertedUser, options));
            Console.WriteLine("Equipment:");
            Console.WriteLine(JsonSerializer.Serialize(insertedEquipment, options));
            Console.WriteLine("Rental:");
            Console.WriteLine(JsonSerializer.Serialize(insertedRental, options));

            var expectedLateDays = (insertedRental.ActualReturnDate.Value - insertedRental.ExpectedReturnDate).Days;
            var expectedLateFee = insertedRental.DailyRate * expectedLateDays * insertedRental.LateFeeRate;
            var expectedTotalAmount = insertedRental.DailyRate * 3 + expectedLateFee;

            Assert.AreEqual(user.Email, insertedUser.Email);
            Assert.AreEqual(equipment.Name, insertedEquipment.Name);
            Assert.AreEqual(expectedLateFee, insertedRental.LateFee);
            Assert.AreEqual(expectedTotalAmount, insertedRental.TotalAmount);
        }
    }
}
