﻿
using Core.Entities;

namespace Entities.Concrete;

public class Customer : Entity<int>
{
    public int UserId { get; set; }
    public User User { get; set; }

    public Customer() { }

    public Customer(User? user, int userid)
    {
        UserId = userid;
        User = user;
    }
}
