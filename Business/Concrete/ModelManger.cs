using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Car;
using Business.Requests.Model;
using Business.Requests.Model;
using Business.Responses.Car;
using Business.Responses.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ModelManager : IModelService
{
    private readonly IModelDal _ImodelDal;
    private readonly IMapper _mapper;

    public ModelManager(IModelDal modeldDal, IMapper mapper)
    {
        _ImodelDal = modeldDal;

        _mapper = mapper;
    }
    public AddModelResponse Add(AddModelRequest request)
    {
        Entities.Concrete.Model modelAdd = _mapper.Map<Entities.Concrete.Model>(request);

        _ImodelDal.Add(modelAdd);

        AddModelResponse response = _mapper.Map<AddModelResponse>(modelAdd);
        return response;

    }

    public AddModelResponse Add(AddModelResponse request)
    {
        throw new NotImplementedException();
    }

    public void DeleteCar(int id)
    {
        throw new NotImplementedException();
    }

    public void DeleteModel(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Entities.Concrete.Model> GetList()
    {
        IList<Entities.Concrete.Model> Models = _ImodelDal.GetList();
        return Models;
    }

    public GetModelListResponse GetList(GetModelListResponse request)
    {
        throw new NotImplementedException();
    }
}