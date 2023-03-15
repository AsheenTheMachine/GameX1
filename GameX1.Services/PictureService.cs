namespace GameX1.Services { }

public class PictureService : BaseService<PictureModel>, IPictureService
{
    public PictureService(string baseUrl) : base(baseUrl, "api/Picture/")
    {
    }
}
