﻿using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int>
{
    public int BrandId { get; set; }
    public string Name { get; set; }
    public short Year { get; set; }

    public Brand? Brand { get; set; } = null;


    public int FuelID { get; set; }
    public string FuelName { get; set; }

    public Fuel? Fuel { get; set; } = null;

}
