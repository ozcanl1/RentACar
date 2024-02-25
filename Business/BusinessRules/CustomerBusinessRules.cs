
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules;

public class CustomerBusinessRules
{
    private readonly ICustomerDal _customerDal;

    public CustomerBusinessRules(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }

    public void CheckIfUserNoExists(int id)
    {
        bool isExists = _customerDal.GetList().Any(a => a.Id == id);
        if (!isExists)
        {
            throw new BusinessException("This id not found");
        }
    }
    public Customer FindId(int id)
    {
        Customer customer = _customerDal.GetList().Where(a => a.Id == id).FirstOrDefault();
        return customer;
    }
}
