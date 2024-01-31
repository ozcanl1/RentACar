using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CorporateCustomer : Entity<int>
    {
        public CorporateCustomer() { }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public Customer? Customer { get; set; } = null;
        public User? User { get; set; } = null;
    }
}
