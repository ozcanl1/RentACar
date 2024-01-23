﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BrandManager : BrandService
{
    private readonly IBrandDal _brandDal;
    private readonly BrandBusinessRules _brandBusinessRules;
    private readonly IMapper _mapper;

    public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper)
    {
        _brandDal = brandDal; //new InMemoryBrandDal(); // Başka katmanların class'ları new'lenmez. Bu yüzden dependency injection kullanıyoruz.
        _brandBusinessRules = brandBusinessRules;
        _mapper = mapper;
    }

    public AddBrandResponse Add(AddBrandRequest request)
    {
        // İş Kuralları
        _brandBusinessRules.CheckIfBrandNameNotExists(request.Name);

        // Validation
        // Yetki kontrolü
        // Cache
        // Transaction

        //Brand brandToAdd = new(request.Name)
        Brand brandToAdd = _mapper.Map<Brand>(request); // Mapping

        _brandDal.Add(brandToAdd);

        AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
        return response;
    }

   


    public void DeleteBrand(int id)
    {
        var result = _brandDal.GetList(id);
        if (result != null)
            _brandDal.Delete(result);
    }

    public IList<Brand> GetList()
    {
        // İş Kuralları
        // Validation
        // Yetki kontrolü
        // Cache
        // Transaction

        IList<Brand> brandList = _brandDal.GetList();
        // brandList.Items diye bir alan yok, bu yüzden mapping konfigurasyonu yapmamız gerekiyor.

        // Brand -> BrandListItemDto
         //IList<Brand> newbrand = GetBrandListResponse()
        return brandList;
      

    }
    public GetBrandListResponse GetList(GetBrandListRequest request)
    {
        throw new NotImplementedException();
    }
}
