public class InMemoryBrandDal
{
    private static List<Brand> brands;

    static InMemoryBrandDal()
    {
        brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "Togg" },
        };
    }

    public List<Brand> GetAll()
    {
        return brands;
    }

    public Brand GetById(int id)
    {
        return brands.FirstOrDefault(b => b.Id == id);
    }

    public void Add(Brand brand)
    {
        if (brands.Any(b => b.Name == brand.Name))
        {
            throw new InvalidOperationException("");
        }

        brand.Id = brands.Count + 1;
        brands.Add(brand);
    }
}
