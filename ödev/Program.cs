class Program
{
    static void Main()
    {

        FuelInMemoryDal fuelInMemoryDal = new FuelInMemoryDal();

      

        FuelService fuelService = new FuelService();
        
    
        
        fuelService.Equals(new Fuel { Id = 1, Name = ""});
        fuelService.Equals(new Fuel { Id = 2, Name = "" });

        fuelService.Equals(new Fuel { Id = 3, Name = "" });

        TransmissionService transmissionService = new TransmissionService();
        transmissionService.Equals(new Transmission { Id = 1, Name = "" });
        transmissionService.Equals(new Transmission { Id = 2, Name = "" });
        transmissionService.Equals(new Transmission { Id = 3, Name = "" });
    }
}
