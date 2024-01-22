using DataAccess.Abstract;

namespace Business.BusinessRules;

public class CarBusinessRules
{
    private readonly ICarDal _carDal;

    public CarBusinessRules(ICarDal CarDal)
    {
        _carDal = CarDal;
    }

    public void CheckIfModelNameNotExists(string carName)
    {
        bool isExists = _carDal.GetList().Any(b => b.Name == carName);
        if (isExists)
        {

            throw new Exception("Car already exists.");
        }
    }
}
