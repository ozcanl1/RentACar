using System.Reflection;
using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ModelManager : ModelService
{
    private readonly IModelDal _modelDal;
    private readonly ModelBusinessRules _modelBusinessRules;
    private readonly IMapper _mapper;

    public ModelManager(IModelDal modelDal, IMapper mapper)
    {
    }

    public ModelManager(IModelDal modelDal, ModelBusinessRules modelBusinessRules, IMapper mapper)
    {
        _modelDal = modelDal;
        _modelBusinessRules = modelBusinessRules;
        _mapper = mapper;
    }

    public AddModelResponse Add(AddModelRequest request)
    {
       
        if (request.Name.Length < 2)
            throw new Exception("Name must be at least 2 characters long.");
        if (request.Name.Length > 50)
            throw new Exception("Name cannot be longer than 50 characters.");
        if (request.DailyPrice > 0)
            throw new Exception("Daily price must be greater than 0.");
        
        _modelBusinessRules.CheckIfModelNameExists(request.Name);

       
        var modelToAdd = _mapper.Map<Model>(request);

       
        Model updatedModel = _modelDal.Add(modelToAdd);

       
        var response = _mapper.Map<AddModelResponse>(updatedModel);
        return response;
    }

    public DeleteModelResponse Delete(DeleteModelRequest request)
    {
        throw new NotImplementedException();
    }

    public void DeleteModel(int id)
    {
        throw new NotImplementedException();
    }

    public GetModelByIdResponse GetById(GetModelByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public GetModelListResponse GetList(GetModelListRequest request)
    {
       

        IList<Model> modelList = _modelDal.GetList(
            predicate: model =>
                (request.FilterByBrandId == null || model.BrandId == request.FilterByBrandId)
                && (request.FilterByFuelId == null || model.FuelId == request.FilterByFuelId)
                && (
                    request.FilterByTransmissionId == null
                    || model.TransmissionId == request.FilterByTransmissionId
                )
        );


        var response = _mapper.Map<GetModelListResponse>(modelList);
        
        return response;
    }

    public IList<Model> GetList()
    {
        throw new NotImplementedException();
    }

    public UpdateModelResponse Update(UpdateModelRequest request)
    {
        throw new NotImplementedException();
    }

    AddModelResponse ModelService.Add(AddModelResponse request)
    {
        throw new NotImplementedException();
    }
}
