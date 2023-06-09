﻿namespace GameX1.Repository.Helpers;

using System.Collections.Generic;
using System.Threading.Tasks;
using GameX1.Domain.Helpers;
using Microsoft.EntityFrameworkCore;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly DataContext _context;

    protected GenericRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<T> Get(long id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}