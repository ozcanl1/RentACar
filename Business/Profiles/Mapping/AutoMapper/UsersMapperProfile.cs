using AutoMapper;
using Business.Dtos.User;
using Business.Requests.Users;
using Business.Responses.Users;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class UsersMapperProfile : Profile
    {
        public UsersMapperProfile()
        {
            CreateMap<AddUsersRequest, User>();
            CreateMap<User, UserListItemDto>();

            CreateMap<IList<User>, GetUsersListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<User, DeleteUsersResponse>();

            CreateMap<UpdateUsersRequest, User>();
            CreateMap<User, UpdateUserResponse>();
        }
    }
}
