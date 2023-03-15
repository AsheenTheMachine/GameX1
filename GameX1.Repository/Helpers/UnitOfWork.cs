namespace GameX1.Repository.Helpers;

using System;
using GameX1.Domain.Helpers;
using System.Threading.Tasks;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContext _context;

    public IPictureRepository Picture { get; }

    public UnitOfWork(DataContext dataContext,
        IPictureRepository pictureRepository )
    {
        this._context = dataContext;
        this.Picture = pictureRepository;
    }

    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
    }
}