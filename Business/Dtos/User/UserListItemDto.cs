using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UsersListItemDto
{
    public int Id { get; set; }
    public string Email { get; set; }

    public UsersListItemDto() { }
    public UsersListItemDto(int id, string email)
    {
        Id = id;
        Email = email;
    }
}
