using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission
{
    public class GetTransmissionListRequest
    {
        public string Name { get; set; }
        public GetTransmissionListRequest(string name)
        {
            Name = name;
        }
    }
}
