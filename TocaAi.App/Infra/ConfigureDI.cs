using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TocaAi.App.Pages;
using TocaAi.App.Validators;
using TocaAi.App.ViewModels;
using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Interfaces;
using TocaAi.Domain.Validators;
using TocaAi.Repository.Context;
using TocaAi.Repository.Repository;
using TocaAi.Service.DTOs;
using TocaAi.Service.Interfaces;
using TocaAi.Service.Services;

namespace TocaAi.App.Infra
{
    public static class ConfigureDI
    {
        //public static ServiceProvider serviceProvider;

        public static IServiceProvider ConfigureService()
        {
            var dbConfigFile = "Config/DbConfig.txt";
            var dbConnectionString = File.ReadAllText(dbConfigFile);

            var services = new ServiceCollection();

            services.AddDbContext<TocaAiDbContext>(options =>
            {
                options.LogTo(Console.WriteLine);
                options.UseSqlServer(dbConnectionString);
            });

            #region Repositories
            services.AddScoped<IBaseRepository<UserAccount, Guid>, BaseRepository<UserAccount, Guid>>();
            services.AddScoped<IUserAccountRepository, UserAccountRepository>();

            services.AddScoped<IBaseRepository<Person, Guid>, BaseRepository<Person, Guid>>();
            services.AddScoped<IBaseRepository<Equipment, Guid>, BaseRepository<Equipment, Guid>>();
            services.AddScoped<IBaseRepository<Rental, Guid>, BaseRepository<Rental, Guid>>();
            #endregion

            #region Services
            services.AddScoped<IBaseService<UserAccount, Guid>, BaseService<UserAccount, Guid>>();
            services.AddScoped<IBaseService<Person, Guid>, BaseService<Person, Guid>>();
            services.AddScoped<IBaseService<Equipment, Guid>, BaseService<Equipment, Guid>>();
            services.AddScoped<IBaseService<Rental, Guid>, BaseService<Rental, Guid>>();
            services.AddScoped<IEquipmentService, EquipmentService>();
            services.AddScoped<IRentalService, RentalService>();
            #endregion

            services.AddLogging();

            #region Validators
            services.AddScoped<IValidator<UserAccount>, UserAccountValidator>();
            services.AddScoped<IValidator<Person>, PersonValidator>();
            services.AddScoped<IValidator<RegisterUserModel>, RegisterUserModelValidator>();
            services.AddScoped<IValidator<Equipment>, EquipmentValidator>();
            #endregion

            #region Mappers
            services.AddAutoMapper(config =>
            {
                config.CreateMap<UserAccount, UserAccountModel>();
                config.CreateMap<Person, PersonModel>()
                    .ForMember(d => d.Street, o => o.MapFrom(s => s.Address.Street))
                    .ForMember(d => d.Number, o => o.MapFrom(s => s.Address.Number))
                    .ForMember(d => d.Neighborhood, o => o.MapFrom(s => s.Address.Neighborhood))
                    .ForMember(d => d.City, o => o.MapFrom(s => s.Address.City))
                    .ForMember(d => d.State, o => o.MapFrom(s => s.Address.State))
                    .ForMember(d => d.PostalCode, o => o.MapFrom(s => s.Address.PostalCode));
                config.CreateMap<Equipment, EquipmentOutputModel>()
                    .ForMember(d => d.OwnerEmail, o => o.MapFrom(s => s.Owner.Email));
                // mapeamento de entrada
                config.CreateMap<EquipmentInputModel, Equipment>();
                config.CreateMap<Rental, RentalModel>();
            });
            #endregion

            #region Forms
            services.AddTransient<LoginForm>();
            services.AddTransient<RegisterForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<CreateAdForm>();
            #endregion

            //serviceProvider = services.BuildServiceProvider();
            return services.BuildServiceProvider();
        }
    }
}
