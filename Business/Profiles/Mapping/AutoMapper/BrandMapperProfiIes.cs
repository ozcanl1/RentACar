﻿using AutoMapper;
using Business.Dtos.Brand;
using Business.Requests.Brand;
using Business.Responses.Brand;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper;

public class BrandMapperProfiles : Profile
{
    public BrandMapperProfiles()
    {
        CreateMap<AddBrandRequest, Brand>();
        CreateMap<Brand, AddBrandResponse>();

        CreateMap<Brand, BrandListItemDto>();
        CreateMap<IList<Brand>, GetBrandListResponse>()
            .ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        CreateMap<DeleteBrandRequest, Brand>();
        CreateMap<Brand, DeleteBrandResponse>()
           .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        CreateMap<UpdateBrandRequest, Brand>();
        CreateMap<Brand, UpdateBrandResponse>()
           .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
    }
}