using System;

class Program
{
    static void Main()
    {
        // Fuel nesnesi için örnek
        FuelService fuelService = new FuelService();
        Fuel fuel1 = new Fuel { Id = 1, Name = "Petrol" };
        Fuel fuel2 = new Fuel { Id = 2, Name = "Dizel" };

        // Aynı isimde birden fazla öğe eklememek için kontrol ekleyebilirsiniz
        if (!fuelService.HasDuplicateName(fuel1.Name))
        {
            fuelService.AddFuel(fuel1);
            Console.WriteLine("Fuel added: " + fuel1.Name);
        }
        else
        {
            Console.WriteLine("Fuel with the same name already exists: " + fuel1.Name);
        }

        if (!fuelService.HasDuplicateName(fuel2.Name))
        {
            fuelService.AddFuel(fuel2);
            Console.WriteLine("Fuel added: " + fuel2.Name);
        }
        else
        {
            Console.WriteLine("Fuel with the same name already exists: " + fuel2.Name);
        }

        // Transmission nesnesi için örnek
        TransmissionService transmissionService = new TransmissionService();
        Transmission transmission1 = new Transmission { Id = 1, Name = "Automatic" };
        Transmission transmission2 = new Transmission { Id = 2, Name = "Manual" };


        if (!transmissionService.HasDuplicateName(transmission1.Name))
        {
            transmissionService.AddTransmission(transmission1);
            Console.WriteLine("Transmission added: " + transmission1.Name);
        }
        else
        {
            Console.WriteLine("Transmission with the same name already exists: " + transmission1.Name);
        }

        if (!transmissionService.HasDuplicateName(transmission2.Name))
        {
            transmissionService.AddTransmission(transmission2);
            Console.WriteLine("Transmission added: " + transmission2.Name);
        }
        else
        {
            Console.WriteLine("Transmission with the same name already exists: " + transmission2.Name);
        }

    }
}
