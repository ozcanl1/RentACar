using Business.Requests.Brand;
using Business.Requests.Model;
using Business.Responses.Brand;
using Business.Responses.Model;
using Entities.Concrete;

namespace Business.Abstract;

public interface IModelService
{
    public AddModelResponse Add(AddModelResponse request);

    public IList<Model> GetList();

    public void DeleteCar(int id);
    public GetModelListResponse GetList(GetModelListResponse request);
    void DeleteModel(int id);
    AddModelResponse Add(AddModelRequest request);
}
