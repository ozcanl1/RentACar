using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class IndividualCustomer : Entity<int>
    {
        public IndividualCustomer() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } = null;
        public User? User { get; set; } = null;
    }
}
