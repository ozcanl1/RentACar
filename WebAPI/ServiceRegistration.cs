using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Requests.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Fuel.Requests;
using Fuel.Responses;

namespace WebAPI;

public static class ServiceRegistration
{
    public static readonly IBrandDal BrandDal = new InMemoryBrandDal();
    public static readonly IFuelDal FuelDal = new InMemoryFuelDal();
    public static readonly ITransmissionDal TransmissionDal = new InMemoryTransmissionDal();

    public static readonly BrandBusinessRules BrandBusinessRules = new BrandBusinessRules(BrandDal);


    public static IMapper Mapper = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<AddBrandRequest, Brand>();
        cfg.CreateMap<Brand, AddBrandResponse>();
        cfg.CreateMap<AddFuelRequest, Entities.Concrete.Fuel>();
        cfg.CreateMap<Entities.Concrete.Fuel, AddFuelResponse>();
        cfg.CreateMap<AddTransmissionRequest, Entities.Concrete.Transmission>();
        cfg.CreateMap<Entities.Concrete.Transmission, AddTransmissionResponse>();
    }).CreateMapper();

    public static readonly IBrandService BrandService = new BrandManager(
        BrandDal,
        BrandBusinessRules,
        Mapper
    );
    public static readonly IFuelService FuelService = new Fuel.Concrete.FuelManager(
        FuelDal,
        Mapper
    );

    public static readonly ITransmissionService TransmissionService = new Transmission.Concrete.TransmissionManager(TransmissionDal, Mapper);
} // IoC Container yapımızı kurduğumuz Dependency Injection ile daha verimli hale getiricez.

