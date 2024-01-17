public class BrandService
{
    private readonly InMemoryBrandDal _brandDal;

    public BrandService(InMemoryBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public List<Brand> GetAllBrands()
    {
        return _brandDal.GetAll();
    }

    public Brand GetBrandById(int id)
    {
        return _brandDal.GetById(id);
    }

    public void AddBrand(Brand brand)
    {
        _brandDal.Add(brand);
    }
}
