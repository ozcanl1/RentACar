﻿using Core.Entities;

namespace Entities.Concrete;

public class IndividualCustomer : Entity<int>
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    public Customer? Customer { get; set; }

    public IndividualCustomer() { }
    public IndividualCustomer(string firstName, string lastName, string nationalIdentity, Customer? customer, int customerid)
    {
        CustomerId = customerid;
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
        Customer = customer;
    }
}
