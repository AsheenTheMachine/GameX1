namespace GameX1.Repository.Helpers;

public interface IUnitOfWork
{

    IPictureRepository Picture { get; }

    Task<int> Complete();

}
