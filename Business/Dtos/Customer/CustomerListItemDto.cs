﻿
namespace Business.Dtos.Customer;

public class CustomerListItemDto
{
    public int Id { get; set; }
    public CustomerListItemDto() { }
    public CustomerListItemDto(int id)
    {
        Id = id;
    }
}
