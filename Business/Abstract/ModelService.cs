using Business.Requests.Brand;
using Business.Requests.Model;
using Business.Responses.Brand;
using Business.Responses.Model;
using Entities.Concrete;

namespace Business.Abstract;

public interface ModelService
{
    public AddModelResponse Add(AddModelResponse request);

    public GetModelByIdResponse GetById(GetModelByIdRequest request);

    public AddModelResponse Add(AddModelRequest request);

    public UpdateModelResponse Update(UpdateModelRequest request);

    public DeleteModelResponse Delete(DeleteModelRequest request);
    IList<Model> GetList();
    void DeleteModel(int id);
}
