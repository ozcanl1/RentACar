using AutoMapper;
using Business.Dtos.Transmission;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Entities.Concrete;
using Fuel.Requests;
using Fuel.Responses;

namespace Business.Profiles.Mapping.AutoMapper;

public class TransmissionMapperProfiles : Profile
{
    public TransmissionMapperProfiles()
    {
        CreateMap<AddTransmissionRequest, Transmission>();
        CreateMap<Transmission, AddTransmissionResponse>();

        CreateMap<Transmission, TransmissionListItemDto>();
        CreateMap<IList<Transmission>, GetTransmissionListResponse>();
          
        CreateMap<Transmission, DeleteTransmissionResponse>();
        CreateMap<UpdateTransmissionRequest, Transmission>();
        CreateMap<Transmission, UpdateTransmissionResponse>()
           .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}
