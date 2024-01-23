using Business.Requests.Brand;
using Business.Responses.Brand;
using Entities.Concrete;

namespace Business.Abstract;

public interface BrandService
{
    public AddBrandResponse Add(AddBrandRequest request);

    public IList<Brand> GetList();

    public void DeleteBrand(int id);
    public GetBrandListResponse GetList(GetBrandListRequest request);
}
