using GameX1.Domain.Helpers;
using GameX1.Repository.Helpers;

namespace GameX1.Repository { }

public class PictureRepository : GenericRepository<Picture>, IPictureRepository
{
    public PictureRepository(DataContext context) : base(context) { }

}
