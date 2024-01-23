namespace Business;

public class GetCarListRequest
{
    public int? FilterByBrandId { get; set; }
    public int? FilterByFuelId { get; set; }
    public int? FilterByTransmissionId { get; set; }
}
