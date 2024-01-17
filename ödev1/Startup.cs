public void ConfigureServices(IServiceCollection services)
{


    services.AddSingleton<InMemoryFuelDal>(); 
    services.AddSingleton<FuelService>();

    services.AddSingleton<InMemoryTransmissionDal>(); 
    services.AddSingleton<TransmissionService>();
}
