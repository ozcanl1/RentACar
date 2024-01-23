using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel.Requests
{
    public class AddFuelRequest
    {
      //  public int Id { get; set; }
        public string Name { get; set; }
       

        public AddFuelRequest(string name)
        {
            Name = name;
      
        }
    }
}
