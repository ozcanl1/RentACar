using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Requests.Brand;
using Business.Requests.Car;
using Business.Requests.Model;
using Business.Responses.Brand;
using Business.Responses.Car;
using Business.Responses.Model;
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
    public static readonly IModelDal ModelDal = new InMemoryModelDal();
    public static readonly ICarDal CarDal = new InMemoryCarDal();


    public static readonly BrandBusinessRules BrandBusinessRules = new BrandBusinessRules(BrandDal);


    public static IMapper Mapper = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<AddBrandRequest, Brand>();
        cfg.CreateMap<Brand, AddBrandResponse>();
        cfg.CreateMap<AddFuelRequest, Entities.Concrete.Fuel>();
        cfg.CreateMap<Entities.Concrete.Fuel, AddFuelResponse>();
        cfg.CreateMap<AddTransmissionRequest, Entities.Concrete.Transmission>();
        cfg.CreateMap<Entities.Concrete.Transmission, AddTransmissionResponse>();
        cfg.CreateMap<AddModelRequest,Model>();
        cfg.CreateMap<Model, AddModelResponse>();
        cfg.CreateMap<AddCarRequest, Car>();
        cfg.CreateMap<Car, AddCarResponse>();



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

    public static readonly ITransmissionService TransmissionService = new Transmission.Concrete.TransmissionManager(TransmissionDal, Mapper
    );

    public static IModelService ModelService { get; } = new ModelManager(
     ModelDal,
     Mapper
     );

    public static readonly ICarService CarService = new CarManager(
            CarDal,
            Mapper
      );
} // IoC Container yapımızı kurduğumuz Dependency Injection ile daha verimli hale getiricez.

