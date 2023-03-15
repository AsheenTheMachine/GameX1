
using GameX1.Helpers.Interfaces;

namespace GameX1.Helpers.Interfaces { }

public interface IBaseService<T> where T : class
{
    Task<IEnumerable<T>> GetAll();

    Task<T> Get(int id);

    Task<T> Get(Guid id);

    Task<bool> Create(T book);

    Task<bool> Update(T book);

    Task<bool> Delete(int id);
}

