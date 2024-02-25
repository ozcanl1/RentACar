using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.DependencyResolvers;

public static class ServiceCollectionBusinessExtension
{
    // Extension method
    // Metodun ve barındığı class'ın static olması gerekiyor
    // İlk parametere genişleteceğimiz tip olmalı ve başında this keyword'ü olmalı.
    public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services
            //Brand
            .AddScoped<IBrandService, BrandManager>()
            .AddScoped<IBrandDal, EfBrandDal>()
            .AddScoped<BrandBusinessRules>()
            //Model
            .AddScoped<IModelService, ModelManager>()
            .AddScoped<IModelDal, EfModelDal>()
            .AddScoped<ModelBusinessRules>()
            .AddSingleton<List<Model>>()
            //Fuel
            .AddScoped<IFuelDal, EfFuelDal>()
            .AddScoped<IFuelService, FuelManager>()
            .AddScoped<FuelBusinessRules>()
            //Transmission
            .AddScoped<ITransmissionDal, EfTransmissionDal>()
            .AddScoped<ITransmissionService, TransmissionManager>()
            .AddScoped<TransmissionBusinessRules>()
            //Car
            .AddSingleton<ICarService, CarManager>()
            .AddSingleton<ICarDal, InMemoryCarDal>()
            .AddSingleton<CarBusinessRules>()
            //User
            .AddScoped<IUserService, UserManager>()
            .AddScoped<IUserDal, EfUserDal>()
            .AddScoped<UserRules>()
            //Customer
            .AddScoped<ICustomersService, CustomerManager>()
            .AddScoped<ICustomerDal, EfCustomerDal>()
            .AddScoped<CustomerBusinessRules>()
            //IndividualCustomer
            .AddScoped<IIndividualCustomerService, IndividualCustomerManager>()
            .AddScoped<IIndividualCustomerDal, EfIndividualCustomerDal>()
            .AddScoped<IndividualCustomerBusinessRules>()
            //CorporateCustomer
            .AddScoped<ICorporateCustomerService, CorporateCustomerManager>()
            .AddScoped<ICorporateCustomerDal, EfCorporateCustomerDal>()
            .AddScoped<CorporateCustomerBusinessRules>()
            //userjwt
            .AddScoped<ITokenHelper, JwtTokenHelper>();
    
        services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
        // Reflection yöntemiyle Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

        services.AddDbContext<RentACarContext>(options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL19")));
        return services;
    }
}